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

        public IEditavel ConfigurarEditar(ICliente cliente)
        {
            if (cliente is ClientePF)
                return new CadastroClientePF().ConfigurarEditar((ClientePF)cliente);
            if (cliente is ClientePJ)
                return new CadastroClientePJ().ConfigurarEditar((ClientePJ)cliente);
            else
                throw new ArgumentException();
        }

        public override ICliente GetNovaEntidade()
        {
            throw new NotSupportedException();
        }
    }
}