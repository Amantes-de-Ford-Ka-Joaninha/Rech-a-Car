using Dominio.VeiculoModule;
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule
{
    class GerenciamentoVeiculo : GerenciamentoEntidade<Veiculo>
    {
        public GerenciamentoVeiculo() : base("Gerenciamento de Veículos")
        {

        }

        protected override CadastroEntidade<Veiculo> Cadastro { get { return new CadastrarVeiculo(); } }
    }
}
