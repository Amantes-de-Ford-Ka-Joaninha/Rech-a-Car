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
    public partial class FormGerenciamento : Form
    {
        private Form formAtivo = null;

        public FormGerenciamento(String titulo)
        {
            InitializeComponent();
            lbTitulo.Text = titulo;
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

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Form formCadastrarVeiculo = new FormCadastrarVeiculo();
            panelFormFilho.BringToFront();
            AbrirFormFilho(formCadastrarVeiculo);
        }
    }
}
