﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telinhas
{
    public partial class FormGerenciarAluguel : Form
    {
        public FormGerenciarAluguel(String titulo)
        {
            InitializeComponent();
            lbTitulo.Text = titulo;
        }
    }
}
