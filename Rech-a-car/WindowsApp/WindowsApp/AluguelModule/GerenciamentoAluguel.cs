using Dominio.AluguelModule;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp
{
    public partial class GerenciamentoAluguel : Form
    {
        public GerenciamentoAluguel()
        {
            InitializeComponent();
            lbTitulo.Text = "Gerenciamento de Aluguel";
        }
    }
}