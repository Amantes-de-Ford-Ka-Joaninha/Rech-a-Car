using Dominio.AluguelModule;
using Dominio.VeiculoModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.AluguelModule;
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule
{
    public class GerenciamentoVeiculo : GerenciamentoEntidade<Veiculo>
    {
        public GerenciamentoVeiculo(string titulo = "Gerenciamento de Veículo", TipoTela tipo = TipoTela.CadastroBasico, Aluguel aluguel = null) : base(titulo, tipo)
        {
            Aluguel = aluguel;
        }
        protected override CadastroEntidade<Veiculo> Cadastro => new CadastroVeiculo();
        protected override void SalvarAluguel()
        {
            Aluguel.Veiculo = GetEntidadeSelecionado();
            TelaPrincipal.Instancia.FormAtivo = new ResumoAluguel(Aluguel);
        }
        protected override ISelecionavel Selecionar => new VisualizarVeiculo();

        private Aluguel Aluguel { get; }

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
                veiculo.Categoria.PrecoDiaria,
                veiculo.Categoria.PrecoKm
            };
            return linha.ToArray();
        }
    }
}
