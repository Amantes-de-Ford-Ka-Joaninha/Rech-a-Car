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
using System.Linq;

namespace WindowsApp.AluguelModule
{
    public partial class FechamentoAluguel : CadastroEntidade<AluguelFechado>, IVisualizavel //Form//
    {
        Aluguel aluguel;

        public override Controlador<AluguelFechado> Controlador => new ControladorAluguelFechado();

        public FechamentoAluguel(Aluguel aluguel)
        {
            this.aluguel = aluguel;
            InitializeComponent();
            tb_OdometroInicial.Text = aluguel.Veiculo.Quilometragem.ToString();
        }

        public IVisualizavel Visualizar()
        {
            return this;
        }

        private void CalcularPrecoTotal()
        {
            lbValor.Text = GetNovaEntidade().CalcularTotal().ToString();
        }
        private int KmRodados()
        {
            if (int.TryParse(tb_OdometroFinal.Text, out int odometroFinal) && odometroFinal >= aluguel.Veiculo.Quilometragem)
                return odometroFinal - aluguel.Veiculo.Quilometragem;

            return -1;
        }
        private double TanqueUtilizado()
        {
            return 0.5;
        }

        public override AluguelFechado GetNovaEntidade()
        {
            var servicos = new List<Servico>();

            foreach (var item in listDespesas.Items)
                servicos.Add((Servico)item);

            return aluguel.Fechar(KmRodados(), TanqueUtilizado(), servicos);
        }

        protected override IEditavel Editar()
        {
            throw new NotImplementedException();
        }
        private void validaCampoNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #region eventos

        private void bt_AddDespesa_Click(object sender, EventArgs e)
        {
            if (tb_NomeDespesa.Text != "" && mtb_PrecoDespesa.Text != "" && double.TryParse(mtb_PrecoDespesa.Text, out double precoDespesa))
                listDespesas.Items.Add(new Servico(tb_NomeDespesa.Text, precoDespesa));

            CalcularPrecoTotal();
        }
        private void bt_RemoveDespesa_Click(object sender, EventArgs e)
        {
            listDespesas.Items.Remove(listDespesas.SelectedItem);
            lbValor.Text = entidade.CalcularTotal().ToString();
        }
        private void tb_KmFinal_TextChanged(object sender, EventArgs e)
        {
            entidade = GetNovaEntidade();
            CalcularPrecoTotal();
        }
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            entidade = GetNovaEntidade();
            entidade.Id = aluguel.Id;

            if (!Salva())
                return;

            new ControladorVeiculo().AdicionarQuilometragem(aluguel.Veiculo, KmRodados());

            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoAluguel();
        }
        #endregion
    }
}
