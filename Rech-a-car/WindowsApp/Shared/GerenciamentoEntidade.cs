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

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaInicial.Instancia.FormAtivo = Cadastro.ConfigurarTela(TipoCadastro.Insercao);
        }
        private void bt_editar_Click(object sender, EventArgs e)
        {
            TelaInicial.Instancia.FormAtivo = Cadastro.ConfigurarTela(TipoCadastro.Edicao);
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
