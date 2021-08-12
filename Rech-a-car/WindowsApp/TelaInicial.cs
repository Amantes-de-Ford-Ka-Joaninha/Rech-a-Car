using System;
using System.Windows.Forms;
using WindowsApp.VeiculoModule;

namespace WindowsApp
{
    public partial class TelaInicial : Form
    {
        public static TelaInicial Instancia;
        private Form formAtivo;
        public TelaInicial()
        {
            Instancia = this;
            InitializeComponent();
            //InicializarPanels();              IDEIA A SER DISCUTIDA
            EsconderSubMenu();
        }

        private void InicializarPanels()
        {
            throw new NotImplementedException();
        }

        public Form FormAtivo { set { AbrirFormPanel(value); } }
        private void EsconderSubMenu()
        {
            panelSubMenuAluguel.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }
        private void AbrirFormPanel(Form panelForm)
        {
            EsconderSubMenu();
            formAtivo?.Close();

            formAtivo = panelForm;
            formAtivo.TopLevel = false;
            formAtivo.FormBorderStyle = FormBorderStyle.None;
            formAtivo.Dock = DockStyle.Fill;

            panelFormFilho.Controls.Add(formAtivo);

            formAtivo.BringToFront();
            formAtivo.Show();
        }

        #region Eventos

        private void bt_Aluguel_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuAluguel);
        }
        private void bt_RealizarAluguel_Click(object sender, EventArgs e)
        {
            FormAtivo = new RealizarAluguel();
        }
        private void bt_GerenciarAlugueis_Click(object sender, EventArgs e)
        {
            FormAtivo = new GerenciamentoAluguel();
        }
        private void bt_Veiculos_Click(object sender, EventArgs e)
        {
            FormAtivo = new GerenciamentoVeiculo();
        }
        private void bt_servicos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void bt_funcionarios_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void bt_clientes_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
