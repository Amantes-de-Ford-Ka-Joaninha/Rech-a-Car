using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class FormTelaInicial : Form
    {
        public static FormTelaInicial Instancia;
        private Form formAtivo;
        public FormTelaInicial()
        {
            Instancia = this;
            InitializeComponent();
            EsconderSubMenu();
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

            panelForm.TopLevel = false;
            panelForm.FormBorderStyle = FormBorderStyle.None;
            panelForm.Dock = DockStyle.Fill;
            panelFormFilho.Controls.Add(panelForm);
            panelFormFilho.Tag = panelForm;
            panelForm.BringToFront();
            panelForm.Show();
        }

        #region Eventos

        private void bt_Aluguel_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuAluguel);
        }
        private void bt_RealizarAluguel_Click(object sender, EventArgs e)
        {
            FormAtivo = new FormRealizarAluguel();
        }
        private void bt_GerenciarAlugueis_Click(object sender, EventArgs e)
        {
            FormAtivo = new FormGerenciarAluguel();
        }
        private void bt_Veiculos_Click(object sender, EventArgs e)
        {
            FormAtivo = new FormGerenciamento("Gerenciamento de Veículos");
        }
        private void bt_servicos_Click(object sender, EventArgs e)
        {
            FormAtivo = new FormGerenciamento("Gerenciamento de Serviços");
        }
        private void bt_funcionarios_Click(object sender, EventArgs e)
        {
            FormAtivo = new FormGerenciamento("Gerenciamento de Funcionários");
        }
        private void bt_clientes_Click(object sender, EventArgs e)
        {
            FormAtivo = new FormGerenciamento("Gerenciamento de Clientes");
        }

        #endregion
    }
}
