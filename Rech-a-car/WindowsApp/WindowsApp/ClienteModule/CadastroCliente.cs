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

        public override CadastroEntidade<ICliente> Editar(ICliente entidade)
        {
            throw new NotImplementedException();
        }

        public override ICliente GetNovaEntidade()
        {
            throw new NotImplementedException();
        }
    }
}