using Dominio.ServicoModule;
using Dominio.Shared;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ServicoModule
{
    internal class VisualizarServico : IVisualizavel
    {
        public Form Visualizar<T>(T t) where T : IControlavel
        {
            throw new System.NotImplementedException();
        }
    }
}