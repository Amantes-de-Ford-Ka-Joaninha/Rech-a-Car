using Controladores.AluguelModule;
using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class ResumoAluguel : CadastroEntidade<Aluguel>    
    {
        public override Controlador<Aluguel> Controlador => throw new System.NotImplementedException();
        public Controlador<ClientePF> Controlador_PF { get; set; }
        public Controlador<ClientePJ> Controlador_PJ { get; set; }

        public override Aluguel GetNovaEntidade()
        {
            throw new System.NotImplementedException();
        }

        protected override IEditavel ConfigurarEditar()
        {
            throw new System.NotImplementedException();
        }

        public ResumoAluguel()
        {
            InitializeComponent();
        }
        protected void ConfigurarTextFields()
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
        }
    }
}
