using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using System;
using System.Windows.Forms;
using WindowsApp.AluguelModule;
using WindowsApp.ClienteModule;
using WindowsApp.FuncionarioModule;
using WindowsApp.ServicoModule;
using WindowsApp.Shared;
using WindowsApp.VeiculoModule;

namespace WindowsApp
{
    public partial class TelaPrincipal : Form
    {
        public static TelaPrincipal Instancia;
        private Form formAtivo;
        public TelaPrincipal()
        {
            Instancia = this;
            InitializeComponent();
            EsconderSubMenu();
        }

        public Form FormAtivo { set { AbrirFormPanel(value); } }
        private void EsconderSubMenu()
        {
            panelSubMenuAluguel.Visible = false;
            panelSubMenuClientes.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }
        private void AbrirFormPanel(Form panelForm)
        {
            if (formAtivo is GerenciamentoEntidade<ICliente>)
                EsconderSubMenu();

            //if (formAtivo is CadastroEntidade<IControlavel>)
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
        private void bt_Servicos_Click(object sender, EventArgs e)
        {
            FormAtivo = new GerenciamentoServico();
        }
        private void bt_funcionarios_Click(object sender, EventArgs e)
        {
            FormAtivo = new GerenciamentoFuncionario();
        }
        private void bt_clientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuClientes);
            
        }
        private void btPessoaFisica_Click(object sender, EventArgs e)
        {
            FormAtivo = new GerenciamentoClientes();
        }

        private void btPessoaJuridica_Click(object sender, EventArgs e)
        {
            FormAtivo = new GerenciamentoClientes();
        }
        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
