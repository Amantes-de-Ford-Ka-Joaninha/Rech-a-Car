using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule.ClienteModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroCliente : CadastroEntidade<ICliente>
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        public override Controlador<ICliente> Controlador => new ControladorCliente();

        protected override ITelaEditar Editar()
        {
            if (entidade is ClientePF)
                return new CadastroClientePF().Editar((ClientePF)entidade);
            if (entidade is ClientePJ)
                return new CadastroClientePJ().Editar((ClientePJ)entidade);
            else
                throw new ArgumentException();
        }

        public override ICliente GetNovaEntidade()
        {
            throw new NotImplementedException();
        }
    }
}