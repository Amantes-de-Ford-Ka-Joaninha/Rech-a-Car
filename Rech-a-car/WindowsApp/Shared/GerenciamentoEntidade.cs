using Dominio;
using System;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract partial class GerenciamentoEntidade<T> : Form where T : Entidade
    {
        protected abstract CadastroEntidade<T> Cadastro { get; }
        protected abstract VisualizarEntidade<T> Visualizar { get; }
        public GerenciamentoEntidade(String titulo)
        {
            InitializeComponent();
            ConfigurarGrid();
            lbTitulo.Text = titulo;
        }

        public void AtualizarRegistros()
        {
            dgvEntidade.Rows.Clear();
            var registros = Cadastro.Controlador.Registros;

            foreach (var item in registros)
                dgvEntidade.Rows.Add(ObterLinha(item));
        }
        public abstract DataGridViewColumn[] ConfigurarColunas();
        public abstract object[] ObterLinha(T item);
        private void ConfigurarGrid()
        {
            var colunaID = new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID" };
            colunaID.Visible = false;
            dgvEntidade.Columns.Add(colunaID);

            dgvEntidade.Columns.AddRange(ConfigurarColunas());
            dgvEntidade.ConfigurarGridZebrado();
            dgvEntidade.ConfigurarGridSomenteLeitura();
            AtualizarRegistros();
        }
        private int GetIdSelecionado()
        {
            const int primeira = 0;

            var id = dgvEntidade.SelectedRows[primeira].Cells[primeira].Value;

            return (int)id;
        }
        private void AlternarBotoes(bool estado)
        {
            bt_editar.Enabled = estado;
            bt_remover.Enabled = estado;
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = Cadastro.Inserir();
        }
        private void bt_editar_Click(object sender, EventArgs e)
        {
            var entidade = Cadastro.Controlador.GetById(GetIdSelecionado());
            TelaPrincipal.Instancia.FormAtivo = Cadastro.Editar(entidade);
            AlternarBotoes(false);
        }
        private void bt_remover_Click(object sender, EventArgs e)
        {
            Cadastro.Controlador.Excluir(GetIdSelecionado());
            AlternarBotoes(false);
        }
        private void dgvEntidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AlternarBotoes(true);
        }

        private void dgvEntidade_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = Visualizar;
        }
    }
}
