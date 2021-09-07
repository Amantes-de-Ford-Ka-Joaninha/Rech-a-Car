using Dominio.AluguelModule;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;
using Dominio.ServicoModule;
using Controladores.AluguelModule;
using Controladores.VeiculoModule;
using Controladores.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class FechamentoAluguel : CadastroEntidade<AluguelFechado>, IVisualizavel
    {
        Aluguel aluguel;
        List<Servico> despesas = new List<Servico>();

        public override Controlador<AluguelFechado> Controlador => new ControladorAluguelFechado();

        public FechamentoAluguel(Aluguel aluguel)
        {
            this.aluguel = aluguel;
            InitializeComponent();
        }

        public IVisualizavel Visualizar()
        {
            return this;
        }

        private void CalcularPrecoTotal()
        {
            lbValor.Text = entidade.CalcularTotal().ToString();
        }
        #region eventos

        private void bt_AddDespesa_Click(object sender, EventArgs e)
        {
            if (tb_NomeDespesa.Text != "" && mtb_PrecoDespesa.Text != "" && double.TryParse(mtb_PrecoDespesa.Text, out double precoDespesa))
                despesas.Add(new Servico(tb_NomeDespesa.Text, precoDespesa));

            PopulaListDespesas();
            CalcularPrecoTotal();
        }
        private void bt_RemoveDespesa_Click(object sender, EventArgs e)
        {
            despesas.Remove((Servico)listDespesas.SelectedItem);
            PopulaListDespesas();
            lbValor.Text = entidade.CalcularTotal().ToString();
        }
        private void tb_Atraso_Leave(object sender, EventArgs e)
        {
            PopulaListDespesas();
            lbValor.Text = entidade.CalcularTotal().ToString();
        }
        private void tb_KmFinal_TextChanged(object sender, EventArgs e)
        {
            entidade = aluguel.Fechar(KmRodados(), 0, despesas);
            CalcularPrecoTotal();
        }
        private void tb_KmFinal_Leave(object sender, EventArgs e)
        {
            entidade = aluguel.Fechar(KmRodados(), 0, despesas);
            CalcularPrecoTotal();
        }
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            entidade = aluguel.Fechar(KmRodados(), 0, despesas);

            if (!Salva())
                return;

            new ControladorVeiculo().AdicionarQuilometragem(aluguel.Veiculo, KmRodados());
        }
        #endregion
        private void PopulaListDespesas()
        {
            listDespesas.Items.Clear();
            listDespesas.Items.AddRange(despesas.ToArray());
        }
        private int KmRodados()
        {
            if (int.TryParse(tb_KmFinal.Text, out int odometroFinal) && odometroFinal > aluguel.Veiculo.Quilometragem)
                return odometroFinal - aluguel.Veiculo.Quilometragem;

            return 0;
        }

        public override AluguelFechado GetNovaEntidade()
        {
            throw new NotImplementedException();
        }

        protected override IEditavel Editar()
        {
            throw new NotImplementedException();
        }
    }
}
