using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
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
            AtualizarRegistros();
            lbTitulo.Text = titulo;
        }

        public abstract object[] ObterCamposLinha(T item);
        public abstract DataGridViewColumn[] ConfigurarColunas();
        public void AtualizarRegistros()
        {
            ConfigurarGrid();

            dgvEntidade.Rows.Clear();
            var registros = Cadastro.Controlador.Registros;

            foreach (var item in registros)
                dgvEntidade.Rows.Add(GetDadosLinha(item));
        }
        private object[] GetDadosLinha(T item)
        {
            var dadosLinha = new object[] { item.Id }.ToList();
            dadosLinha.AddRange(ObterCamposLinha(item));
            return dadosLinha.ToArray();
        }
        private void ConfigurarGrid()
        {
            dgvEntidade.Columns.Clear();

            var colunaID = new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID" };
            colunaID.Visible = true;
            dgvEntidade.Columns.Add(colunaID);

            dgvEntidade.Columns.AddRange(ConfigurarColunas());
            //dgvEntidade.ConfigurarGridZebrado();
            dgvEntidade.ConfigurarGridSomenteLeitura();
        }
        private int GetIdSelecionado()
        {
            const int primeira = 0;

            var id = dgvEntidade.SelectedRows[primeira].Cells[0].Value;

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
            AtualizarRegistros();
        }
        private void bt_editar_Click(object sender, EventArgs e)
        {
            var entidade = Cadastro.Controlador.GetById(GetIdSelecionado());
            TelaPrincipal.Instancia.FormAtivo = Cadastro.Editar(entidade);
            AlternarBotoes(false);
            AtualizarRegistros();
        }
        private void bt_remover_Click(object sender, EventArgs e)
        {
            Cadastro.Controlador.Excluir(GetIdSelecionado());
            AlternarBotoes(false);
            AtualizarRegistros();
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
