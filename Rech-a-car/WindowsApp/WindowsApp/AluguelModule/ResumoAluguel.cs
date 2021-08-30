using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using WindowsApp.Shared;
using WindowsApp.ClienteModule;
using WindowsApp.VeiculoModule;
using System.Windows.Forms;

namespace WindowsApp.AluguelModule
{
    public partial class ResumoAluguel : CadastroEntidade<Aluguel>
    {
        public static Aluguel Aluguel = new Aluguel();
        public ResumoAluguel()
        {
            if (Aluguel.Cliente == null)
            {
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente("Selecione um Cliente", TipoTela.SemBotoes);
                return;
            }

            if (Aluguel.Veiculo == null)
            {
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoVeiculo("Selecione um Veículo", TipoTela.SemBotoes);
                return;
            }
            InitializeComponent();
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
            return this;
        }

    }
}
