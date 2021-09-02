﻿using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using WindowsApp.Shared;
using WindowsApp.ClienteModule;
using WindowsApp.VeiculoModule;
using System;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule;
using Dominio.ServicoModule;
using Controladores.ServicoModule;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using Dominio.VeiculoModule;
using System.Globalization;

namespace WindowsApp.AluguelModule
{
    public partial class ResumoAluguel : CadastroEntidade<Aluguel>//Form//
    {
        private double PrecoParcial { set { lbValor.Text = value.ToString(); } get { return Convert.ToDouble(lbValor.Text); } }
        private Aluguel Aluguel;
        public ResumoAluguel(Aluguel aluguel = null)
        {
            Aluguel = aluguel == null ? new Aluguel() : aluguel;

            InitializeComponent();

            if (Aluguel?.Veiculo != null)
            {
                PopulaVeiculo(Aluguel.Veiculo);
            }

            if (Aluguel?.Cliente != null)
            {
                PopulaCliente(aluguel.Cliente);
            }

            PopulaServicos(GetServicosDiponiveis());
            PopulaDatas();
            cbPlano.SelectedIndex = 0;
            bt_RemoveServico.Enabled = false;
            bt_AddServico.Enabled = false;

        }

        private void PopulaDatas()
        {
            tbDt_Emprestimo.Text = DateTime.Today.ToShortDateString();
            tbDt_Devolucao.Text = DateTime.Today.AddDays(1).ToShortDateString();
        }

        public override Controlador<Aluguel> Controlador => new ControladorAluguel();
        public override Aluguel GetNovaEntidade()
        {
            DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dataAluguel);
            DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dataDevolucao);

            Aluguel.Condutor = cb_motoristas.SelectedItem is null ? (Condutor)Aluguel.Cliente : (Condutor)cb_motoristas.SelectedItem;
            Aluguel.TipoPlano = (Plano)cbPlano.SelectedIndex;
            Aluguel.Funcionario = TelaPrincipal.Instancia.FuncionarioLogado;
            Aluguel.DataAluguel = dataAluguel;
            Aluguel.DataDevolucao = dataDevolucao;

            return Aluguel;
        }
        protected override IEditavel ConfigurarEditar()
        {
            tbCliente.Text = entidade.Cliente.Nome;
            tbDocumento.Text = entidade.Cliente.Documento;
            tbEndereço.Text = entidade.Cliente.Endereco;
            tbTelefone.Text = entidade.Cliente.Telefone;
            tbMarca.Text = entidade.Veiculo.Marca;
            tbModelo.Text = entidade.Veiculo.Modelo;
            tbPlaca.Text = entidade.Veiculo.Placa;
            cbPlano.SelectedItem = entidade.TipoPlano.ToString();

            SetCondutor();

            tbDt_Emprestimo.Text = entidade.DataAluguel.ToString("d");
            tbDt_Devolucao.Text = entidade.DataDevolucao.ToString("d");
            PopulaServicos(GetServicosDiponiveis());
            return this;
        }

        private List<Servico> GetServicosDiponiveis()
        {
            return new ControladorServico().ServicosDisponiveis().Except(Aluguel.Servicos).ToList();
        }

        private void SetCondutor()
        {
            if (Aluguel.Cliente is ClientePJ)
                PopulaMotoristas();
            else
                cb_motoristas.Enabled = false;
        }

        private void PopulaVeiculo(Veiculo veiculo)
        {
            EsconderPanel(panelEsconderVeiculo);
            Aluguel.Veiculo = veiculo;
            tbMarca.Text = Aluguel.Veiculo.Marca;
            tbModelo.Text = Aluguel.Veiculo.Modelo;
            tbPlaca.Text = Aluguel.Veiculo.Placa;
            cbTipoCnh.SelectedItem = Aluguel.Veiculo.Categoria.TipoDeCnh.ToString();
        }
        private void PopulaCliente(ICliente cliente)
        {
            EsconderPanel(panelEsconderCliente);
            Aluguel.Cliente = cliente;
            tbCliente.Text = Aluguel.Cliente.Nome;
            tbDocumento.Text = Aluguel.Cliente.Documento;
            tbEndereço.Text = Aluguel.Cliente.Endereco;
            tbTelefone.Text = Aluguel.Cliente.Telefone;

            SetCondutor();
        }
        private void PopulaMotoristas()
        {
            cb_motoristas.Items.AddRange(((ClientePJ)Aluguel.Cliente).Motoristas.ToArray());
        }
        private void PopulaServicos(List<Servico> servicos)
        {
            listServicos.Items.Clear();
            listServicos.Items.AddRange(servicos.ToArray());
        }

        private void AdicionarServico()
        {
            Aluguel.Servicos.Add((Servico)listServicos.SelectedItem);
            listServicos.Items.Remove(listServicos.SelectedItem);
            CalcularPrecoParcial();
        }
        private void RemoverServico()
        {
            Aluguel.Servicos.Remove((Servico)listServicos.SelectedItem);
            listServicos.Items.Remove(listServicos.SelectedItem);
            CalcularPrecoParcial();
        }
        private void EsconderPanel(Panel panel)
        {
            panel.Visible = false;
        }
        private void CalcularPrecoParcial()
        {
            if (Aluguel?.Servicos == null || Aluguel?.Veiculo == null)
                return;

            PrecoParcial = 0;
            Aluguel.Servicos.ForEach(x => PrecoParcial += x.Taxa);

            if (!VerificaCamposDatas())
                return;

            var Categoria = Aluguel.Veiculo.Categoria;
            switch (cbPlano.Text)
            {
                case "Diário":
                    CalculaPlanoDiario();
                    break;
                case "Controlado":
                    CalculaPlanoControlado();
                    break;
                case "Livre":
                    CalculaPlanoLivre();
                    break;
                default:
                    break;
            }

            lbValor.Text = PrecoParcial.ToString();

            void CalculaPlanoControlado()
            {
                PrecoParcial += (Categoria.PrecoDiaria * GetQtdDiasAluguel()) +
                    Categoria.QuilometragemFranquia * Categoria.PrecoKm;
            }
            void CalculaPlanoDiario()
            {
                PrecoParcial += Categoria.PrecoDiaria * GetQtdDiasAluguel();
            }
            void CalculaPlanoLivre()
            {
                PrecoParcial += Categoria.PrecoDiaria * GetQtdDiasAluguel() * 1.3;
            }
            int GetQtdDiasAluguel()
            {
                DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dtDevolucao);
                DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dtEmprestimo);

                return (dtDevolucao - dtEmprestimo).Days;
            }
            bool VerificaCamposDatas()
            {
                return DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dataDevolucao) && DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dataEmprestimo) && dataDevolucao > dataEmprestimo;
            }
        }
        protected override string ValidacaoCampos()
        {
            var validacao = string.Empty;
            if (Aluguel.Veiculo == null)
                validacao += "O aluguel precisa de um veículo\n";
            if (Aluguel.Cliente == null)
                validacao += "O aluguel precisa de um cliente";

            return validacao;
        }
        private void AtualizaOpcoesListServicos()
        {
            if (lb_lista_opcionais.Text == "Opcionais")
            {
                PopulaServicos(Aluguel.Servicos);
                lb_lista_opcionais.Text = "Alugados";
            }
            else
            {
                PopulaServicos(GetServicosDiponiveis());
                lb_lista_opcionais.Text = "Opcionais";
            }
        }

        #region Eventos
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            if (!Salva())
                return;

            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoAluguel();
        }
        private void panelEsconderCliente_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente("Selecione um Cliente", TipoTela.ApenasConfirma, Aluguel);
        }

        private void panelEsconderVeiculo_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoVeiculo("Selecione um Veículo", TipoTela.ApenasConfirma, Aluguel);
        }
        private void bt_AddServico_Click(object sender, EventArgs e)
        {
            var selecionado = listServicos.SelectedIndex;
            AdicionarServico();
            listServicos.SelectedIndex = listServicos.Items.Count > 0 ? selecionado - 1 : -1;
        }
        private void bt_RemoveServico_Click(object sender, EventArgs e)
        {
            var selecionado = listServicos.SelectedIndex;
            RemoverServico();
            listServicos.SelectedIndex = listServicos.Items.Count != 0 ? selecionado : -1;
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            tipAluguel.SetToolTip(pictureBox1, "Clique duas vezes nos painéis para adicionar as informações necessárias.");
        }
        private void tbDt_Emprestimo_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoParcial();
        }
        private void tbDt_Devolucao_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoParcial();
        }
        private void cbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecoParcial();
        }
        private void bt_alterna_listas_Click(object sender, EventArgs e)
        {
            AtualizaOpcoesListServicos();
        }
        private void listServicos_SelectedValueChanged(object sender, EventArgs e)
        {
            if(lb_lista_opcionais.Text == "Opcionais")
                bt_AddServico.Enabled = listServicos.Items.Count != 0 ? true : false;
            else
                bt_RemoveServico.Enabled = listServicos.Items.Count != 0 ? true : false;
        }
        #endregion
    }
}