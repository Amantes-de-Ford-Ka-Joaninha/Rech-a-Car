﻿using Dominio.PessoaModule;
using System;
using System.Windows.Forms;
using WindowsApp.AluguelModule;
using WindowsApp.ClienteModule;
using WindowsApp.ConfiguracoesModule;
using WindowsApp.FuncionarioModule;
using WindowsApp.ServicoModule;
using WindowsApp.VeiculoModule;
using WindowsApp.VeiculoModule.CategoriaModule;
using WindowsApp.WindowsApp;

namespace WindowsApp
{
    public partial class TelaPrincipal : Form
    {
        public static TelaPrincipal Instancia;
        private Form formAtivo;
        public TelaPrincipal(Funcionario funcionario)
        {
            Instancia = this;
            InitializeComponent();
            EsconderSubMenu();
            lbUsuario.Text = "ADMIN DA SEXOLOGIA";//funcionario.Nome;
            //lbCargo.Text = funcionario.Cargo;
        }

        public Form FormAtivo { set { AbrirFormPanel(value); } }
        private void EsconderSubMenu()
        {
            panelSubMenuClientes.Visible = false;
            panelSubMenuVeiculos.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }
        private void AbrirFormPanel(Form panelForm)
        {
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
            EsconderSubMenu();
            FormAtivo = new GerenciamentoAluguel();
        }
        private void bt_GerenciarAlugueis_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoAluguel();
        }
        private void bt_Veiculos_Click(object sender, EventArgs e)
        {
            panelSubMenuClientes.Visible = false;
            MostrarSubMenu(panelSubMenuVeiculos);
        }
        private void bt_Servicos_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoServico();
        }
        private void bt_funcionarios_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoFuncionario();
        }
        private void bt_clientes_Click(object sender, EventArgs e)
        {
            panelSubMenuVeiculos.Visible = false;
            MostrarSubMenu(panelSubMenuClientes);
            FormAtivo = new GerenciamentoCliente();
        }
        private void btPessoaFisica_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new CadastroClientePF();
        }

        private void btPessoaJuridica_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new CadastroClientePJ();
        }
        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
            new Login().Show();
        }
        private void btVeiculosSubMenu_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoVeiculo();
        }

        private void btGrupos_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoCategoria();
        }
        private void btConfiguracoes_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new Configuracoes();
        }

        #endregion

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
