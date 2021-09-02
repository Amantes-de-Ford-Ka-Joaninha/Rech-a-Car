using Dominio.PessoaModule;
using Dominio.Shared;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public class VisualizarFuncionario : IVisualizavel
    {
        public Form Visualizar<T>(T t) where T : IControlavel
        {
            throw new System.NotImplementedException();
        }
    }
}