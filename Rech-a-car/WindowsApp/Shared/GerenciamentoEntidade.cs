using Dominio;
using System;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract partial class GerenciamentoEntidade<T> : Form where T : Entidade
    {
        protected abstract CadastroEntidade<T> Cadastro { get; }
        public GerenciamentoEntidade(String titulo)
        {
            InitializeComponent();
            lbTitulo.Text = titulo;
        }

        private int GetIdSelecionado()
        {
            const int primeira = 0;

            var id = dgvAluguel.SelectedRows[primeira].Cells[primeira].Value;

            return (int)id;
        }
        private void HabilitarAtualizacoes()
        {
            bt_editar.Enabled = true;
            bt_remover.Enabled = true;
        }
        private bool SelecionarLinha()
        {
            return dgvAluguel.SelectedRows.Count > 0;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaInicial.Instancia.FormAtivo = Cadastro.Inserir();
        }
        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (!SelecionarLinha())
                return;
            HabilitarAtualizacoes();
            var entidade = Cadastro.Controlador.GetById(GetIdSelecionado());
            TelaInicial.Instancia.FormAtivo = Cadastro.Editar(entidade);
        }
        private void bt_remover_Click(object sender, EventArgs e)
        {
            Cadastro.Controlador.Excluir(GetIdSelecionado());
        }
    }
}
