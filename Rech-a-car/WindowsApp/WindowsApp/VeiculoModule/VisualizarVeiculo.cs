using Dominio.Shared;
using Dominio.VeiculoModule;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule
{
    public class VisualizarVeiculo : IVisualizavel
    {
        public Form Visualizar<T>(T t) where T : IControlavel
        {
            throw new System.NotImplementedException();
        }
    }
}