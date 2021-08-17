using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp.ClienteModule
{
    public partial class GerenciamentoCliente : Form
    {
        public GerenciamentoCliente()
        {
            InitializeComponent();
        }
        public object[] ObterLinha(ICliente cliente) { return new object[0]; }

        private void btClientePF_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new CadastrarClientePF();
        }

        private void btClientePJ_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new CadastrarClientePJ();
        }
    }
}