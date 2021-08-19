using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public class CadastroFuncionario : CadastroEntidade<Funcionario>
    {
        public override Controlador<Funcionario> Controlador => new ControladorFuncionario();

        public override CadastroEntidade<Funcionario> Editar(Funcionario entidade)
        {
            throw new NotImplementedException();
        }

        public override Funcionario GetNovaEntidade()
        {
            throw new NotImplementedException();
        }
    }
}