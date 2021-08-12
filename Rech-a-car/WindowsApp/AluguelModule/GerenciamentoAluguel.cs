using Dominio.AluguelModule;
using WindowsApp.Shared;

namespace WindowsApp
{
    public partial class GerenciamentoAluguel : GerenciamentoEntidade<Aluguel>
    {
        public GerenciamentoAluguel() : base("Gerenciamento de Aluguel")
        {
            InitializeComponent();
        }
        protected override CadastroEntidade<Aluguel> Cadastro { get => throw new System.NotImplementedException(); }
    }
}