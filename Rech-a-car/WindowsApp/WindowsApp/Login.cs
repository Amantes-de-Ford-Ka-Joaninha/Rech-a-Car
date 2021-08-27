﻿using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp.WindowsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool LoginUsuario()
        {
            return true;//if (tbSenha.Text = getFuncionario().Senha) return true;
            //else return false;
        }

        private Funcionario getFuncionario()
        {
            var usuario = tbUsuario.Text;
            Funcionario funcionario = null;//SelecionarPorUsuario();
            return funcionario;
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            if (LoginUsuario())
            {
                Hide();
                new TelaPrincipal(getFuncionario()).Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos", "Erro");
            }
        }
    }
}
