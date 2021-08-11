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
        private Form formAtivo = null;

        public FormTelaInicial()
        {
            InitializeComponent();
            CustomizarDesign();
        }

        private void CustomizarDesign()
        {
            panelSubMenuAluguel.Visible = false;
        }

        private void EsconderSubMenu()
        {
            if (panelSubMenuAluguel.Visible == true)
                panelSubMenuAluguel.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnAluguel_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuAluguel);
        }

        private void btnRealizarAluguel_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            Form formRealizarAluguel = new FormRealizarAluguel();
            AbrirFormFilho(formRealizarAluguel);
        }

        private void btnGerenciarAlugueis_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            Form formGerenciarAlugueis = new FormGerenciarAluguel();
            AbrirFormFilho(formGerenciarAlugueis);
        }


        private void AbrirFormFilho(Form formFilho)
        {
            if (formAtivo != null)
                formAtivo.Close();
            formAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panelFormFilho.Controls.Add(formFilho);
            panelFormFilho.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();
        }

        private void btVeiculos_Click(object sender, EventArgs e)
        {
            Form formVeiculos = new FormGerenciamento("Gerenciamento de Veículos");
            AbrirFormFilho(formVeiculos);
        }
    }
}
