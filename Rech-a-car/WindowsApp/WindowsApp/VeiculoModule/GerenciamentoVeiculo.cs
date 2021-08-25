using Dominio.VeiculoModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule
{
    public class GerenciamentoVeiculo : GerenciamentoEntidade<Veiculo>
    {
        public GerenciamentoVeiculo() : base("Gerenciamento de Veículos")
        {
        }

        protected override CadastroEntidade<Veiculo> Cadastro => new CadastroVeiculo();
        protected override VisualizarEntidade<Veiculo> Visualizar => new VisualizarVeiculo();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Marca", HeaderText = "Marca"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Modelo", HeaderText = "Modelo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Ano", HeaderText = "Ano"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoria"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Diária", HeaderText = "Diária"},
                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoKm", HeaderText = "Preço/Km"}
            };
        }
        public override object[] ObterCamposLinha(Veiculo veiculo)
        {
            List<object> linha = new List<object>()
            {
                veiculo.Marca,
                veiculo.Modelo,
                veiculo.Ano,
                veiculo.Categoria,
                veiculo.DadosVeiculo.Diaria,
                veiculo.DadosVeiculo.PrecoKm
            };
            return linha.ToArray();
        }
    }
}
