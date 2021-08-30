using Dominio.AluguelModule;
using WindowsApp.ClienteModule;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class VisualizarAluguel : VisualizarEntidade<Aluguel>
    {
        public VisualizarAluguel()
        {
            InitializeComponent();
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente();
        }
    }
}
