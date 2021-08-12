﻿using System;
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
        public FormGerenciamento(String titulo)
        {
            InitializeComponent();
            lbTitulo.Text = titulo;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormTelaInicial.Instancia.FormAtivo = new FormCadastrarVeiculo();
        }
    }
}
