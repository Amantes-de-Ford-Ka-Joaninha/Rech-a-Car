using Controladores.ServicoModule;
using Controladores.Shared;
using Dominio.ServicoModule;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ServicoModule
{
    public partial class CadastroServico : CadastroEntidade<Servico>
    {
        public override Controlador<Servico> Controlador { get => new ControladorServico(); }

        public CadastroServico()
        {
            InitializeComponent();
        }

        protected override IEditavel ConfigurarEditar()
        {
            tbNome.Text = entidade.Nome;
            tbTaxa.Text = entidade.Taxa.ToString();
            tbQuantidade.Text = entidade.Estoque.ToString();

            return this;
        }

        public override Servico GetNovaEntidade()
        {
            var nome = tbNome.Text;
            Double.TryParse(tbTaxa.Text, out double taxa);
            Int32.TryParse(tbTaxa.Text, out int estoque);

            return new Servico(nome, taxa, estoque);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoServico();
        }
    }
}
