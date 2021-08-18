using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.ClienteModule
{
    public partial class CadastrarCliente : CadastroEntidade<ICliente>
    {
        public CadastrarCliente()
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
