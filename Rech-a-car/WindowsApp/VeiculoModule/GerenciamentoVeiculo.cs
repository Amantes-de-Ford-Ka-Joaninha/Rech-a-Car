using Dominio.VeiculoModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule
{
    class GerenciamentoVeiculo : GerenciamentoEntidade<Veiculo>
    {
        public GerenciamentoVeiculo() : base("Gerenciamento de Veículos")
        {
        }

        protected override CadastroEntidade<Veiculo> Cadastro => new CadastrarVeiculo();
        protected override VisualizarEntidade<Veiculo> Visualizar => new VisualizarVeiculo();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Marca", HeaderText = "Marca"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Modelo", HeaderText = "Modelo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Ano", HeaderText = "Ano"},
                new DataGridViewTextBoxColumn {DataPropertyName = "Categoria", HeaderText = "Categoria"},
                new DataGridViewTextBoxColumn {DataPropertyName = "Diária", HeaderText = "Diária"},
                new DataGridViewTextBoxColumn {DataPropertyName = "Preço Km", HeaderText = "Preço Km"}
            };
        }
        public override object[] ObterLinha(Veiculo veiculo)
        {
            List<object> linha = new List<object>()
            {
                veiculo.Ano,
                veiculo.Marca,
                veiculo.Modelo,
                veiculo.Categoria,
                veiculo.DadosVeiculo.Diaria,
                veiculo.DadosVeiculo.PrecoKm
            };
            return linha.ToArray();
        }
    }
}
