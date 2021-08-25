using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroMotorista : Form//CadastroEntidade<MotoristaEmpresa>
    {
        public override Controlador<MotoristaEmpresa> Controlador => new ControladorMotorista();

        private ClientePJ clientePJ;

        public CadastroMotorista(ClientePJ clientePJ, MotoristaEmpresa motorista = null)
        {
            InitializeComponent();
            VerificarEditar(motorista);
            cbTipoCNH.SelectedIndex = 2;
            this.clientePJ = clientePJ;
        }

        public override void Editar()
        {
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            tbCPF.Text = entidade.Documento;
        }
        public override MotoristaEmpresa GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var documento = lbCPF.Text;
            return new MotoristaEmpresa(nome, telefone, endereco, documento, GetCNH());
        }
        public CNH GetCNH()
        {
            var numero = tbCNH.Text;
            var tipo = cbTipoCNH.SelectedIndex;

            return new CNH(numero, (TipoCNH)tipo);
        }
        private void btAdicionarMotorista_Click(object sender, EventArgs e)
        {
            if (Salva(clientePJ.Id))
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente();
        }
    }
}
