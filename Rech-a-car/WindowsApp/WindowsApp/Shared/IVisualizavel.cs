using Dominio.Shared;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public interface IVisualizavel
    {
        Form Visualizar<T>(T t) where T : IControlavel;
    }
}
