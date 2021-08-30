using Dominio.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract partial class GerenciamentoEntidade<T> : Form, ISelecionavel where T : IControlavel
    {
        protected abstract CadastroEntidade<T> Cadastro { get; }
        protected abstract ISelecionavel Selecionar { get; }
        public GerenciamentoEntidade(String titulo, TipoTela tipo = TipoTela.CadastroBasico)
        {
            InitializeComponent();
            AtualizarRegistros();
            lbTitulo.Text = titulo;

            AtualizarBotoes(tipo);
        }

        public abstract object[] ObterCamposLinha(T item);
        public abstract DataGridViewColumn[] ConfigurarColunas();
        public void AtualizarRegistros()
        {
            dgvEntidade.ConfigurarGrid(ConfigurarColunas());

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
        private void AlternarBotoes(bool estado)
        {
            bt_editar.Enabled = estado;
            bt_remover.Enabled = estado;
        }
        private void AtualizarBotoes(TipoTela tipo)
        {
            if (tipo is TipoTela.SemBotoes)
                RemoveTodos();

            if (tipo is TipoTela.SemCadastrar)
            {
                MudaConfirma(false);
                RemoveCadastrar();
            }
            if (tipo is TipoTela.ApenasConfirma)
            {
                RemoveTodos();
                MudaConfirma(true);
            }

            if (tipo is TipoTela.CadastroBasico)
                MudaConfirma(false);


            void RemoveCadastrar()
            {
                bt_adicionar.Visible = false;
                tbFiltro.Width += 50;
                picLupa.Left += 50;
                btFiltro.Left += 50;
                bt_editar.Left += 50;
                bt_remover.Left += 50;
            }

            void RemoveTodos()
            {
                bt_adicionar.Visible = false;
                bt_editar.Visible = false;
                bt_remover.Visible = false;
                tbFiltro.Width += 180;
                picLupa.Left += 180;
                btFiltro.Left += 180;
            }

            void MudaConfirma(bool estado)
            {
                bt_check.Visible = estado;
            }
        }
        protected virtual Type GetTipoEntidade()
        {
            return typeof(T);
        }
        protected T GetEntidadeSelecionado()
        {
            return Cadastro.Controlador.GetById(dgvEntidade.GetIdSelecionado(), GetTipoEntidade());
        }
        protected virtual void InteracaoWifi()
        {
            return;
        }

        #region Eventos
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = Cadastro.Inserir();
            AtualizarRegistros();
        }
        private void bt_editar_Click(object sender, EventArgs e)
        {
            var entidade = Cadastro.Controlador.GetById(dgvEntidade.GetIdSelecionado(), GetTipoEntidade());
            TelaPrincipal.Instancia.FormAtivo = (Form)Cadastro.ConfigurarEditar(entidade);
            AlternarBotoes(false);
            AtualizarRegistros();
        }
        private void bt_remover_Click(object sender, EventArgs e)
        {
            var opcao = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.Cancel)
                return;

            Cadastro.Controlador.Excluir(dgvEntidade.GetIdSelecionado(), GetTipoEntidade());
            AlternarBotoes(false);
            AtualizarRegistros();
        }

        private void dgvEntidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlternarBotoes(true);
        }
        private void btFiltro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void GerenciamentoEntidade_Load(object sender, EventArgs e)
        {
            dgvEntidade.ClearSelection();
        }
        private void bt_check_Click(object sender, EventArgs e)
        {
            InteracaoWifi();
        }

        #endregion

    }
    public enum TipoTela
    {
        SemBotoes,
        SemCadastrar,
        ApenasConfirma,
        CadastroBasico,
    }
}
