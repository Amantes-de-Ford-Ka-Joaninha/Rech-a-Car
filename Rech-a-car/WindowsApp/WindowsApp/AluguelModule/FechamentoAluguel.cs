﻿using Dominio.AluguelModule;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;
using Dominio.ServicoModule;
using Controladores.AluguelModule;
using Controladores.VeiculoModule;

namespace WindowsApp.AluguelModule
{
    public partial class FechamentoAluguel : Form, IVisualizavel
    {
        Aluguel aluguel;
        List<Servico> despesas = new List<Servico>();
        ControladorAluguel controladorAluguel = new ControladorAluguel();
        ControladorVeiculo controladorVeiculo = new ControladorVeiculo();
        AluguelFechado aluguelFechado;

        public FechamentoAluguel(Aluguel aluguel)
        {
            this.aluguel = aluguel;
            InitializeComponent();
        }

        public Form Visualizar<T>(T t) where T : IControlavel
        {
            return this;
        }

        #region eventos

        private void bt_AddDespesa_Click(object sender, EventArgs e)
        {
            if (tb_NomeDespesa.Text != "" && mtb_PrecoDespesa.Text != "" && double.TryParse(mtb_PrecoDespesa.Text, out double precoDespesa))
                despesas.Add(new Servico(tb_NomeDespesa.Text, precoDespesa));

            PopulaListDespesas();
            lbValor.Text =  aluguelFechado.CalcularTotal().ToString();
        }
        private void bt_RemoveDespesa_Click(object sender, EventArgs e)
        {
            despesas.Remove((Servico)listDespesas.SelectedItem);
            PopulaListDespesas();
            lbValor.Text = aluguelFechado.CalcularTotal().ToString();
        }
        private void tb_Atraso_Leave(object sender, EventArgs e)
        {
            PopulaListDespesas();
            lbValor.Text = aluguelFechado.CalcularTotal().ToString();
        }
        private void tb_KmFinal_TextChanged(object sender, EventArgs e)
        {
            aluguelFechado = aluguel.Fechar(CalcularKmRodado(), 0, despesas);
            lbValor.Text = aluguelFechado.CalcularTotal().ToString();
        }
        private void tb_KmFinal_Leave(object sender, EventArgs e)
        {
            aluguelFechado = aluguel.Fechar(CalcularKmRodado(), 0, despesas);
            lbValor.Text = aluguelFechado.CalcularTotal().ToString();
        }
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            aluguelFechado = aluguel.Fechar(CalcularKmRodado(), 0, despesas);
            controladorAluguel.Editar(aluguel.Id, aluguelFechado);
            controladorVeiculo.Editar(aluguel.Veiculo.Id, aluguel.Veiculo);
            AtualizarOdometro();
        }
        #endregion
        private void PopulaListDespesas()
        {
            listDespesas.Items.Clear();
            listDespesas.Items.AddRange(despesas.ToArray());
        }
        private int CalcularKmRodado()
        {
            int kmRodados = 0;
            if (int.TryParse(tb_KmFinal.Text, out int odometroFinal) && odometroFinal > aluguel.Veiculo.Quilometragem)
            {
                kmRodados = odometroFinal - aluguel.Veiculo.Quilometragem;
            }
            return kmRodados;
        }
        private void AtualizarOdometro()
        {
            aluguel.Veiculo.Quilometragem += CalcularKmRodado();
        }
    }
}
