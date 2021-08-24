using Dominio.PessoaModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;
using WindowsApp.WindowsApp.FuncionarioModule;

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
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereco"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Documento", HeaderText = "Documento"},
            };
        }
        public override object[] ObterCamposLinha(Funcionario funcionario)
        {
            List<object> linha = new List<object>()
            {
                funcionario.Nome,
                funcionario.Documento,
                funcionario.Telefone,
                funcionario.Endereco,
            };
            return linha.ToArray();
        }

        
    }
}
