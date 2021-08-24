using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Windows.Forms;
using WindowsApp.ClienteModule;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.ClienteModule
{
    public partial class CadastroMotorista : CadastroEntidade<MotoristaEmpresa>
    {
        public override Controlador<MotoristaEmpresa> Controlador => new ControladorMotorista();

        private ClientePJ clientePJ;

        public CadastroMotorista(ClientePJ clientePJ, MotoristaEmpresa motorista = null)
        {
            InitializeComponent();
            entidade = motorista;
            this.clientePJ = clientePJ;
        }
        
        public override CadastroEntidade<MotoristaEmpresa> Editar(MotoristaEmpresa motorista)
        {
            tbNome.Text = motorista.Nome;
            tbTelefone.Text = motorista.Telefone;
            tbEndereco.Text = motorista.Endereco;
            tbCPF.Text = motorista.Documento;

            return this;
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
