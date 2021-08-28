using Controladores.Shared;
using Controladores.VeiculoModule;
using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule.CategoriaModule
{
    public partial class CadastroCategoria : CadastroEntidade<Categoria>
    {
        public override Controlador<Categoria> Controlador { get => new ControladorCategoria(); }

        public CadastroCategoria()
        {
            InitializeComponent();
        }

        protected override IEditavel ConfigurarEditar()
        {
            tbNome.Text = entidade.Nome;
            tbDiaria.Text = entidade.PrecoDiaria.ToString();
            tbKm.Text = entidade.PrecoKm.ToString();
            tbFranquia.Text = entidade.QuilometragemFranquia.ToString();
            tbKm.Text = entidade.PrecoLivre.ToString();
            cbCNH.SelectedItem = entidade.TipoDeCnh;

            return this;
        }
        public override Categoria GetNovaEntidade()
        {
            var nome = tbNome.Text;
            Double.TryParse(tbDiaria.Text, out double diaria);
            Double.TryParse(tbKm.Text, out double km);
            Int32.TryParse(tbFranquia.Text, out int franquia);
            Double.TryParse(tbKm.Text, out double livre);
            var tipocnh = cbCNH.SelectedIndex;

            return new Categoria(nome, diaria, km, franquia, livre, (TipoCNH)tipocnh);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCategoria();
        }
    }
}
