using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public class GerenciamentoFuncionario : GerenciamentoEntidade<Funcionario>
    {
        public GerenciamentoFuncionario() : base("Gerenciamento de Funcionários")
        {
        }

        protected override CadastroEntidade<Funcionario> Cadastro => new CadastroFuncionario();
        protected override VisualizarEntidade<Funcionario> Visualizar => new VisualizarFuncionario();
        public override DataGridViewColumn[] ConfigurarColunas()
        {
            throw new NotImplementedException();
        }
        public override object[] ObterCamposLinha(Funcionario item)
        {
            throw new NotImplementedException();
        }
    }
}
