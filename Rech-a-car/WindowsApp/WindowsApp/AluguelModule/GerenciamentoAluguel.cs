using Dominio.AluguelModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class GerenciamentoAluguel : GerenciamentoEntidade<Aluguel>
    {
        public GerenciamentoAluguel() : base("Gerenciamento de Aluguel")
        {
            InitializeComponent();
        }
        protected override CadastroEntidade<Aluguel> Cadastro => new ResumoAluguel();
        protected override VisualizarEntidade<Aluguel> Visualizar => new VisualizarAluguel();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn { DataPropertyName = "Veiculo", HeaderText = "Veículo"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Condutor", HeaderText = "Condutor"},
            new DataGridViewTextBoxColumn { DataPropertyName = "TipoDeAluguel", HeaderText = "Tipo De Aluguel"},
            };
        }
        public override object[] ObterCamposLinha(Aluguel aluguel)
        {
            List<object> linha = new List<object>()
            {
                aluguel.Cliente,
                aluguel.Veiculo,
                aluguel.Condutor,
                aluguel.TipoPlano,
                aluguel.Servicos
            };
            return linha.ToArray();
        }
    }
}