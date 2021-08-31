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
    public partial class ResumoAluguel : CadastroEntidade<Aluguel> //Form //  
    {
        public static new Aluguel entidade = new Aluguel();
        private double PrecoParcial;
        public ResumoAluguel()
        {
            InitializeComponent();
            CarregarOpcionais();

            if (entidade.Veiculo != null)
                PopulaVeiculo();

            if (entidade.Cliente != null)
                PopularCliente();
        }


        public override Controlador<Aluguel> Controlador => new ControladorAluguel();
        public override Aluguel GetNovaEntidade()
        {
            DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dataAluguel);
            entidade.DataAluguel = dataAluguel;

            entidade.Condutor = (Condutor)cb_motoristas.SelectedItem;
            entidade.TipoPlano = (Plano)tbPlano.SelectedIndex;
            entidade.Funcionario = TelaPrincipal.Instancia.FuncionarioLogado;

            return new Aluguel(entidade);
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
            tbPlano.SelectedItem = entidade.TipoPlano.ToString();
            cb_motoristas.SelectedItem = entidade.Condutor;
            tbDt_Emprestimo.Text = entidade.DataAluguel.ToString("d");
            listServicos.DataSource = entidade.Servicos;
            return this;
        }

        private void PopulaVeiculo()
        {
            tbMarca.Text = entidade.Veiculo.Marca;
            tbModelo.Text = entidade.Veiculo.Modelo;
            tbPlaca.Text = entidade.Veiculo.Placa;
        }
        private void PopularCliente()
        {
            tbCliente.Text = entidade.Cliente.Nome;
            tbDocumento.Text = entidade.Cliente.Documento;
            tbEndereço.Text = entidade.Cliente.Endereco;
            tbTelefone.Text = entidade.Cliente.Telefone;

            GetCondutor();
        }
        private void GetCondutor()
        {
            if (entidade.Cliente is ClientePJ)
                PopularMotoristas();
            else
            {
                cb_motoristas.Enabled = false;
                cb_motoristas.SelectedItem = entidade.Cliente;
            }
        }
        private void PopularMotoristas()
        {
            cb_motoristas.DataSource = ((ClientePJ)entidade.Cliente).Motoristas;
        }
        private void AdicionarServico()
        {
            entidade.Servicos.Add((Servico)listServicos.SelectedItem);
            lbValor.Text = CalcularPrecoParcial().ToString();
        }

        private double CalcularPrecoParcial()
        {
            entidade.Servicos.ForEach(x => PrecoParcial += x.Taxa);

            switch (entidade.TipoPlano)
            {
                case Plano.diario:
                    CalculaPlanoDiario();
                    break;
                case Plano.controlado:
                    CalculaPlanoControlado();
                    break;
                case Plano.livre:
                    break;
                default:
                    break;
            }

            PrecoParcial += entidade.Veiculo.Categoria.PrecoDiaria;

            return PrecoParcial;
        }

        private void CalculaPlanoControlado()
        {
            return GetQtdDias * entidade.Veiculo.Categoria
        }

        private void CalculaPlanoDiario()
        {
            PrecoParcial += entidade.Veiculo.Categoria.PrecoDiaria * GetQtdDias();
        }

        private int GetQtdDias()
        {
            DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dtDevolucao);
            DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dtEmprestimo);

            return (dtEmprestimo - dtDevolucao).Days;
        }

        private void RemoverServico()
        {
            if (entidade.Servicos.Contains((Servico)listServicos.SelectedItem));
                entidade.Servicos.Remove((Servico)listServicos.SelectedItem);
        }
        private void CarregarOpcionais()
        {
            listServicos.DataSource = new ControladorServico().Registros;
        }

        #region Eventos
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            if (Salva())
            {
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoAluguel();
                entidade = new Aluguel();
            }
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


        #endregion

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            tipAluguel.SetToolTip(pictureBox1, "Clique duas vezes nos painéis para adicionar as informações necessárias.");
        }


    }
}