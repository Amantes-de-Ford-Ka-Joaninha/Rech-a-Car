using Dominio.ServicoModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ServicoModule
{
    public class GerenciamentoServico : GerenciamentoEntidade<Servico>
    {
        public GerenciamentoServico() : base("Gerenciamento de Serviços")
        {
        }

        protected override CadastroEntidade<Servico> Cadastro => new CadastroServico();
        protected override VisualizarEntidade<Servico> Visualizar => new VisualizarServico();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Taxa", HeaderText = "Taxa"},
            };
        }

        public override object[] ObterCamposLinha(Servico servico)
        {
            List<object> linha = new List<object>()
            {
                servico.Nome,
                servico.Taxa,
            };
            return linha.ToArray();
        }
    }
}