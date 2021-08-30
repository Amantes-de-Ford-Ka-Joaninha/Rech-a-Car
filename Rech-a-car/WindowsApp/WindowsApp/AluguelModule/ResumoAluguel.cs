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

namespace WindowsApp.AluguelModule
{
    public partial class ResumoAluguel : CadastroEntidade<Aluguel>
    {
        public static new Aluguel entidade = new Aluguel();

        private decimal PrecoParcial;
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

        #endregion
    }
}