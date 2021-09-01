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

namespace WindowsApp.AluguelModule
{
    public partial class ResumoAluguel : CadastroEntidade<Aluguel>
    {
        private double PrecoParcial { set { lbValor.Text = value.ToString(); } get { return Convert.ToDouble(lbValor.Text); } }
        public static Aluguel AluguelAtual = new Aluguel();
        public ResumoAluguel()
        {
            InitializeComponent();
            PopulaServicos();

            if (AluguelAtual?.Veiculo != null)
                PopulaVeiculo();

            if (AluguelAtual?.Cliente != null)
                PopulaCliente();

            cbPlano.SelectedIndex = 0;
        }

        public override Controlador<Aluguel> Controlador => new ControladorAluguel();
        public override Aluguel GetNovaEntidade()
        {
            DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dataAluguel);
            DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dataDevolucao);

            AluguelAtual.Condutor = cb_motoristas.SelectedItem is null ? (Condutor)AluguelAtual.Cliente : (Condutor)cb_motoristas.SelectedItem;
            AluguelAtual.TipoPlano = (Plano)cbPlano.SelectedIndex;
            AluguelAtual.Funcionario = TelaPrincipal.Instancia.FuncionarioLogado;
            AluguelAtual.DataAluguel = dataAluguel;
            AluguelAtual.DataDevolucao = dataDevolucao;

            return AluguelAtual;
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
            listServicos.DataSource = entidade.Servicos;
            return this;
        }
        private void SetCondutor()
        {
            if (AluguelAtual.Cliente is ClientePJ)
                PopulaMotoristas();
            else
                cb_motoristas.Enabled = false;
        }

        private void PopulaVeiculo()
        {
            tbMarca.Text = AluguelAtual.Veiculo.Marca;
            tbModelo.Text = AluguelAtual.Veiculo.Modelo;
            tbPlaca.Text = AluguelAtual.Veiculo.Placa;
        }
        private void PopulaCliente()
        {
            tbCliente.Text = AluguelAtual.Cliente.Nome;
            tbDocumento.Text = AluguelAtual.Cliente.Documento;
            tbEndereço.Text = AluguelAtual.Cliente.Endereco;
            tbTelefone.Text = AluguelAtual.Cliente.Telefone;

            SetCondutor();
        }
        private void PopulaMotoristas()
        {
            cb_motoristas.DataSource = ((ClientePJ)AluguelAtual.Cliente).Motoristas;
        }
        private void PopulaServicos()
        {
            listServicos.DataSource = new ControladorServico().Registros;
        }

        private void AdicionarServico()
        {
            AluguelAtual.Servicos.Add((Servico)listServicos.SelectedItem);
            CalcularPrecoParcial();
        }
        private void RemoverServico()
        {
            AluguelAtual.Servicos.Remove((Servico)listServicos.SelectedItem);
            CalcularPrecoParcial();
        }
        private void CalcularPrecoParcial()
        {
            PrecoParcial = 0;
            AluguelAtual.Servicos.ForEach(x => PrecoParcial += x.Taxa);

            if (!VerificaCamposDatas())
                return;

            var Categoria = AluguelAtual.Veiculo.Categoria;
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
            if (AluguelAtual.Veiculo == null)
                validacao += "O aluguel precisa de um veículo\n";
            if (AluguelAtual.Cliente == null)
                validacao += "O aluguel precisa de um cliente";

            return validacao;
        }

        #region Eventos
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            if (!Salva())
                return;
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoAluguel();
            AluguelAtual = new Aluguel();
        }
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente("Selecione um Cliente", TipoTela.ApenasConfirma);
        }
        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoVeiculo("Selecione um Veículo", TipoTela.ApenasConfirma);
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
        #endregion
    }
}