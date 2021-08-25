using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule.ClienteModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroCliente : CadastroEntidade<ICliente>
    {
        public CadastroCliente(ICliente cliente = default)
        {
            InitializeComponent();
            VerificarEditar(cliente);
        }

        public override Controlador<ICliente> Controlador => new ControladorCliente();

        public override void Editar()
        {
            if (entidade is ClientePF)
                TelaPrincipal.Instancia.FormAtivo = new CadastroClientePF((ClientePF)entidade);
            if (entidade is ClientePJ)
                TelaPrincipal.Instancia.FormAtivo = new CadastroClientePJ((ClientePJ)entidade);
            else
                throw new ArgumentException();
        }

        public override ICliente GetNovaEntidade()
        {
            throw new NotImplementedException();
        }
    }
}