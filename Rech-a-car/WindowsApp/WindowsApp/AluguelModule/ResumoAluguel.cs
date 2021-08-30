using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using WindowsApp.Shared;
using WindowsApp.ClienteModule;
using WindowsApp.VeiculoModule;
using System.Windows.Forms;
using System;
using Dominio.PessoaModule.ClienteModule;

namespace WindowsApp.AluguelModule
{
    public partial class ResumoAluguel : CadastroEntidade<Aluguel>
    {
        public static Aluguel Aluguel = new Aluguel();
        public ResumoAluguel()
        {
            if (CadastrarAluguel())
                PopularDados();
            InitializeComponent();
        }

        private void PopularDados()
        {
            tbCliente.Text = entidade.Cliente.Nome;

            tbDocumento.Text = entidade.Cliente.Documento;
            tbEndereço.Text = entidade.Cliente.Endereco;
            tbTelefone.Text = entidade.Cliente.Telefone;

            tbMarca.Text = entidade.Veiculo.Marca;
            tbModelo.Text = entidade.Veiculo.Modelo;
            tbPlaca.Text = entidade.Veiculo.Placa;
            GetCondutor();
        }

        private void GetCondutor()
        {
            if (entidade.Cliente is ClientePJ)
                return;
            tbCondutor.Enabled = false;
            tbCondutor.Text = "-------------";
        }

        public bool CadastrarAluguel()
        {
            if (Aluguel.Cliente == null)
            {
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente("Selecione um Cliente", TipoTela.ApenasConfirma);
                return false;
            }

            if (Aluguel.Veiculo == null)
            {
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoVeiculo("Selecione um Veículo", TipoTela.ApenasConfirma);
                return false;
            }
            return true;
        }
        public override Controlador<Aluguel> Controlador => new ControladorAluguel();
        public override Aluguel GetNovaEntidade()
        {
            tbCliente.Text = entidade.Cliente.ToString();
            tbDocumento.Text = entidade.Cliente.Documento;
            tbEndereço.Text = entidade.Cliente.Endereco;
            tbTelefone.Text = entidade.Cliente.Telefone;
            tbMarca.Text = entidade.Veiculo.Marca;
            tbModelo.Text = entidade.Veiculo.Modelo;
            tbPlaca.Text = entidade.Veiculo.Placa;
            tbPlano.SelectedItem = entidade.TipoPlano.ToString();
            tbCondutor.Text = entidade.Condutor.Nome;
            tbDt_Emprestimo.Text = entidade.DataAluguel.ToString("d");
            listOpcionais.DataSource = entidade.Servicos;

            return new Aluguel();
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
            tbCondutor.Text = entidade.Condutor.Nome;
            tbDt_Emprestimo.Text = entidade.DataAluguel.ToString("d");
            listOpcionais.DataSource = entidade.Servicos;
            return this;
        }

        private void btFecharAluguel_Click(object sender, System.EventArgs e)
        {
            if (Salva())
            {
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoAluguel();
                Aluguel = new Aluguel();
            }
        }
    }
}
