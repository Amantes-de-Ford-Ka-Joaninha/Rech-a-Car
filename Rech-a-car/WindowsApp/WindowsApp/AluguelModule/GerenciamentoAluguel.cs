using Controladores;
using Dominio.AluguelModule;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class GerenciamentoAluguel : Form
    {
        private ControladorAluguel Controlador = new ControladorAluguel();
        public GerenciamentoAluguel()
        {
            InitializeComponent();
            lbTitulo.Text = "Gerenciamento de Aluguel";
            AtualizarRegistros();
        }

        public object[] ObterCamposLinha(Aluguel aluguel)
        {
            List<object> linha = new List<object>()
            {
                //aluguel.Nome,
                //aluguel.Taxa,
            };
            return linha.ToArray();
        }
        public DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn { DataPropertyName = "Veiculo", HeaderText = "Veículo"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Condutor", HeaderText = "Condutor"},
            new DataGridViewTextBoxColumn { DataPropertyName = "TipoDeAluguel", HeaderText = "Tipo De Aluguel"},
            };
        }
        public void AtualizarRegistros()
        {
            ConfigurarGrid();

            dgvAluguel.Rows.Clear();
            var registros = Controlador.Registros;

            foreach (var item in registros)
                dgvAluguel.Rows.Add(GetDadosLinha(item));
        }
        private object[] GetDadosLinha(Aluguel aluguel)
        {
            var dadosLinha = new object[] { aluguel.Id }.ToList();
            dadosLinha.AddRange(ObterCamposLinha(aluguel));
            return dadosLinha.ToArray();
        }
        private void ConfigurarGrid()
        {
            dgvAluguel.Columns.Clear();

            var colunaID = new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID" };
            colunaID.Visible = false;
            dgvAluguel.Columns.Add(colunaID);
            dgvAluguel.Columns.AddRange(ConfigurarColunas());

            dgvAluguel.ConfigurarGridSomenteLeitura();
        }
        private int GetIdSelecionado()
        {
            return dgvAluguel.GetIdSelecionado();
        }

        private void dgvAluguel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var entidade = Controlador.GetById(GetIdSelecionado());
            TelaPrincipal.Instancia.FormAtivo = new FecharAluguel(entidade);
            AtualizarRegistros();
        }
    }
}