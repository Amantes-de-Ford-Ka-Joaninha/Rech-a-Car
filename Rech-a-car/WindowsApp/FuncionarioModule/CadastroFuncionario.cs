using Controladores;
using Controladores.PessoaModule;
using Dominio.PessoaModule;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public class CadastroFuncionario : CadastroEntidade<Funcionario>
    {
        public override ControladorEntidade<Funcionario> Controlador => new ControladorFuncionario();

        public override CadastroEntidade<Funcionario> Editar(Funcionario entidade)
        {
            throw new System.NotImplementedException();
        }
    }
}