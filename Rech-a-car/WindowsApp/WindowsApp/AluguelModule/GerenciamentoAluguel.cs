using Dominio.AluguelModule;
using Dominio.PessoaModule.ClienteModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class GerenciamentoAluguel : GerenciamentoEntidade<Aluguel>
    {
        public GerenciamentoAluguel(string titulo = "Gerenciamento de Aluguel", TipoTela tipo = TipoTela.CadastroBasico) : base(titulo, tipo)
        {
            InitializeComponent();
        }
        protected override CadastroEntidade<Aluguel> Cadastro => new ResumoAluguel();
        protected override ISelecionavel Selecionar => new VisualizarAluguel();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn { DataPropertyName = "Veiculo", HeaderText = "Veículo"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Condutor", HeaderText = "Condutor"},
            new DataGridViewTextBoxColumn { DataPropertyName = "TipoDeAluguel", HeaderText = "Tipo De Aluguel"},
            new DataGridViewTextBoxColumn { DataPropertyName = "DataDevolucao", HeaderText = "Data de Devolução"},
            };
        }
        public override object[] ObterCamposLinha(Aluguel aluguel)
        {
            List<object> linha = new List<object>()
            {
                aluguel.Veiculo,
                aluguel.Cliente,
                aluguel.Condutor is ClientePF ? "-----" : aluguel.Condutor.Nome,
                aluguel.TipoPlano,
                aluguel is AluguelFechado aluguelF ? aluguelF.DataDevolucao.ToString("d") : "-----",
            };
            return linha.ToArray();
        }
    }
}