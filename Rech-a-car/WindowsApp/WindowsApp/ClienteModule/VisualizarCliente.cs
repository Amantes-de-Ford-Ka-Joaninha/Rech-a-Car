using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public class VisualizarCliente : IVisualizavel
    {
        public Form Visualizar<T>(T t) where T : IControlavel
        {
            throw new System.NotImplementedException();
        }
    }
}