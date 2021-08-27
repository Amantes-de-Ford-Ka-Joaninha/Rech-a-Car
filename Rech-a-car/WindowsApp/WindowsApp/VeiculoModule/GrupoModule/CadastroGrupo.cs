﻿using Controladores.Shared;
using Controladores.VeiculoModule;
using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.VeiculoModule.GrupoModule
{
    public partial class CadastroGrupo : CadastroEntidade<Grupo>
    {
        public override Controlador<Grupo> Controlador { get => new ControladorGrupo(); }

        public CadastroGrupo()
        {
            InitializeComponent();
        }

        protected override IEditavel ConfigurarEditar()
        {
            tbNome.Text = entidade.Nome;
            tbDiaria.Text = entidade.PrecoDiaria.ToString();
            tbKm.Text = entidade.PrecoKm.ToString();
            tbFranquia.Text = entidade.QuilometragemFranquia.ToString();
            tbKm.Text = entidade.PrecoLivre.ToString();
            cbCNH.SelectedItem = entidade.TipoDeCnh;

            return this;
        }
        public override Grupo GetNovaEntidade()
        {
            var nome = tbNome.Text;
            Double.TryParse(tbDiaria.Text, out double diaria);
            Double.TryParse(tbKm.Text, out double km);
            Int32.TryParse(tbFranquia.Text, out int franquia);
            Double.TryParse(tbKm.Text, out double livre);
            var tipocnh = cbCNH.SelectedIndex;

            return new Grupo(nome, diaria, km, franquia, livre, (TipoCNH)tipocnh);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoGrupo();
        }
    }
}
