using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class GerenciamentoClientes : GerenciamentoEntidade<ICliente>
    {
        public GerenciamentoClientes() : base("Gerenciamento de Serviços")
        {
        }

        protected override CadastroEntidade<ICliente> Cadastro => null;
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
