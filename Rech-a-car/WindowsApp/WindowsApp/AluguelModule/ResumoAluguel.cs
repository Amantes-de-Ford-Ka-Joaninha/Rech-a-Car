using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using WindowsApp.Shared;
using WindowsApp.ClienteModule;
using WindowsApp.VeiculoModule;
using System;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule;
using Dominio.ServicoModule;
using Controladores.ServicoModule;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using Dominio.VeiculoModule;

namespace WindowsApp.AluguelModule
{
    public partial class ResumoAluguel : CadastroEntidade<Aluguel>
    {
        private double PrecoParcial { set { lbValor.Text = value.ToString(); } get { return Convert.ToDouble(lbValor.Text); } }
        public ResumoAluguel(Aluguel aluguel = null)
        {
            if (aluguel == null)
                entidade = new Aluguel();
            InitializeComponent();

            if (entidade?.Veiculo != null)
                PopulaVeiculo(entidade.Veiculo);

            if (entidade?.Cliente != null)
                PopulaCliente(aluguel.Cliente);

            PopulaServicos(new ControladorServico().ServicosDisponiveis());
            cbPlano.SelectedIndex = 0;
            bt_RemoveServico.Enabled = false;
        }

        public override Controlador<Aluguel> Controlador => new ControladorAluguel();
        public override Aluguel GetNovaEntidade()
        {
            DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dataAluguel);
            DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dataDevolucao);

            entidade.Condutor = cb_motoristas.SelectedItem is null ? (Condutor)entidade.Cliente : (Condutor)cb_motoristas.SelectedItem;
            entidade.TipoPlano = (Plano)cbPlano.SelectedIndex;
            entidade.Funcionario = TelaPrincipal.Instancia.FuncionarioLogado;
            entidade.DataAluguel = dataAluguel;
            entidade.DataDevolucao = dataDevolucao;

            return entidade;
        }
        protected override IEditavel ConfigurarEditar()
        {
            tbCliente.Text = entidade.Cliente.Nome;
            tbDocumento.Text = entidade.Cliente.Documento;
            tbEndereço.Text = entidade.Cliente.Endereco;
            tbTelefone.Text = entidade.Cliente.Telefone;
            tbMarca.Text = entidade.Veiculo.Marca;
            tbModelo.Text = entidade.Veiculo.Modelo;
            tbPlaca.Text = entidade.Veiculo.Placa;
            cbPlano.SelectedItem = entidade.TipoPlano.ToString();

            SetCondutor();

            tbDt_Emprestimo.Text = entidade.DataAluguel.ToString("d");
            tbDt_Devolucao.Text = entidade.DataDevolucao.ToString("d");
            PopulaServicos(new ControladorServico().Registros);
            return this;
        }
        private void SetCondutor()
        {
            if (entidade.Cliente is ClientePJ)
                PopulaMotoristas();
            else
                cb_motoristas.Enabled = false;
        }

        private void PopulaVeiculo(Veiculo veiculo)
        {
            entidade.Veiculo = veiculo;
            tbMarca.Text = entidade.Veiculo.Marca;
            tbModelo.Text = entidade.Veiculo.Modelo;
            tbPlaca.Text = entidade.Veiculo.Placa;
        }
        private void PopulaCliente(ICliente cliente)
        {
            entidade.Cliente = cliente;
            tbCliente.Text = entidade.Cliente.Nome;
            tbDocumento.Text = entidade.Cliente.Documento;
            tbEndereço.Text = entidade.Cliente.Endereco;
            tbTelefone.Text = entidade.Cliente.Telefone;

            SetCondutor();
        }
        private void PopulaMotoristas()
        {
            cb_motoristas.Items.AddRange(((ClientePJ)entidade.Cliente).Motoristas.ToArray());
        }
        private void PopulaServicos(List<Servico> servicos)
        {
            listServicos.Items.Clear();
            listServicos.Items.AddRange(servicos.ToArray());
        }

        private void AdicionarServico()
        {
            entidade.Servicos.Add((Servico)listServicos.SelectedItem);
            listServicos.Items.Remove(listServicos.SelectedItem);
            CalcularPrecoParcial();
        }
        private void RemoverServico()
        {
            entidade.Servicos.Remove((Servico)listServicos.SelectedItem);
            CalcularPrecoParcial();
        }
        private void CalcularPrecoParcial()
        {
            PrecoParcial = 0;
            entidade.Servicos.ForEach(x => PrecoParcial += x.Taxa);

            if (!VerificaCamposDatas())
                return;

            var Categoria = entidade.Veiculo.Categoria;
            switch (cbPlano.Text)
            {
                case "Diário":
                    CalculaPlanoDiario();
                    break;
                case "Controlado":
                    CalculaPlanoControlado();
                    break;
                case "Livre":
                    CalculaPlanoLivre();
                    break;
                default:
                    break;
            }

            lbValor.Text = PrecoParcial.ToString();

            void CalculaPlanoControlado()
            {
                PrecoParcial += (Categoria.PrecoDiaria * GetQtdDiasAluguel()) +
                    Categoria.QuilometragemFranquia * Categoria.PrecoKm;
            }
            void CalculaPlanoDiario()
            {
                PrecoParcial += Categoria.PrecoDiaria * GetQtdDiasAluguel();
            }
            void CalculaPlanoLivre()
            {
                PrecoParcial += Categoria.PrecoDiaria * GetQtdDiasAluguel() * 1.3;
            }
            int GetQtdDiasAluguel()
            {
                DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dtDevolucao);
                DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dtEmprestimo);

                return (dtDevolucao - dtEmprestimo).Days;
            }
            bool VerificaCamposDatas()
            {
                return DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dataDevolucao) && DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dataEmprestimo) && dataDevolucao > dataEmprestimo;
            }
        }
        protected override string ValidacaoCampos()
        {
            var validacao = string.Empty;
            if (entidade.Veiculo == null)
                validacao += "O aluguel precisa de um veículo\n";
            if (entidade.Cliente == null)
                validacao += "O aluguel precisa de um cliente";

            return validacao;
        }

        #region Eventos
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            if (!Salva())
                return;

            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoAluguel();
            entidade = new Aluguel();
        }
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente("Selecione um Cliente", TipoTela.ApenasConfirma, entidade);
        }
        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoVeiculo("Selecione um Veículo", TipoTela.ApenasConfirma, entidade);
        }
        private void bt_AddServico_Click(object sender, EventArgs e)
        {
            AdicionarServico();
        }
        private void bt_RemoveServico_Click(object sender, EventArgs e)
        {
            RemoverServico();
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            tipAluguel.SetToolTip(pictureBox1, "Clique duas vezes nos painéis para adicionar as informações necessárias.");
        }
        private void tbDt_Emprestimo_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoParcial();
        }
        private void tbDt_Devolucao_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoParcial();
        }
        private void cbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecoParcial();
        }
        private void bt_alterna_listas_Click(object sender, EventArgs e)
        {
            if (lb_lista_opcionais.Text == "Opcionais")
            {
                lb_lista_opcionais.Text = "Alugados";
                PopulaServicos(entidade.Servicos);
                bt_RemoveServico.Enabled = true;
            }
            else
            {
                lb_lista_opcionais.Text = "Opcionais";
                PopulaServicos(new ControladorServico().ServicosDisponiveis());
                bt_RemoveServico.Enabled = false;
            }
        }
        #endregion

    }
}