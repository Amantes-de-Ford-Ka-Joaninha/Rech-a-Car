﻿using System;
using System.Windows.Forms;
using WindowsApp.AluguelModule;
using WindowsApp.ClienteModule;
using WindowsApp.FuncionarioModule;
using WindowsApp.ServicoModule;
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
            panelSubMenuClientes.Visible = false;
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
            FormAtivo = new GerenciamentoClientes();
        }
        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void btPessoaFisica_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new CadastrarClientePF();
        }

        private void btPessoaJuridica_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new CadastrarClientePJ();
        }
    }
}
