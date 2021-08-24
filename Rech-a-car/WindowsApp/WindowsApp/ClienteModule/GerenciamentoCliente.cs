using Dominio.PessoaModule.ClienteModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class GerenciamentoCliente : GerenciamentoEntidade<ICliente>
    {

        public GerenciamentoCliente() : base("Gerenciamento de Clientes",false)
        {
        }

        protected override CadastroEntidade<ICliente> Cadastro => new CadastroCliente();
        protected override VisualizarEntidade<ICliente> Visualizar => new VisualizarCliente();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereco"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Documento", HeaderText = "Documento"}
            };
        }

        public override object[] ObterCamposLinha(ICliente cliente)
        {
            List<object> linha = new List<object>()
            {
                cliente.Nome,
                cliente.Endereco,
                cliente.Telefone,
                cliente.Documento,
            };
            return linha.ToArray();
        }
    }
}