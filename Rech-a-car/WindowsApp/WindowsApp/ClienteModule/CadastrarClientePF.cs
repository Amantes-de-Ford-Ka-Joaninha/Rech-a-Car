using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule.ClienteModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastrarClientePF : CadastroEntidade<ClientePF>
    {
        public override ControladorEntidade<ClientePF> Controlador { get => new ControladorClientePF(); }

        public CadastrarClientePF()
        {
            InitializeComponent();
        }

        public override CadastroEntidade<ClientePF> Editar(ClientePF clientePF)
        {
            throw new NotImplementedException();
        }
        public override ClientePF GetNovaEntidade()
        {
            throw new NotImplementedException();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            Salva();
            Close();
        }
    }
}
