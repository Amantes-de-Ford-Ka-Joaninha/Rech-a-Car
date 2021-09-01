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

namespace WindowsApp.AluguelModule
{
    public partial class ResumoAluguel : CadastroEntidade<Aluguel> // Form//
    {
        private double PrecoParcial;
        public static Aluguel AluguelAtual = new Aluguel();
        public ResumoAluguel()
        {
            InitializeComponent();
            PopularServicos();

            if (AluguelAtual?.Veiculo != null)
                PopulaVeiculo();

            if (AluguelAtual?.Cliente != null)
                PopularCliente();

            cbPlano.SelectedIndex = 0;
        }

        public override Controlador<Aluguel> Controlador => new ControladorAluguel();
        public override Aluguel GetNovaEntidade()
        {
            DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dataAluguel);

            AluguelAtual.Condutor = cb_motoristas.SelectedItem is string ? (Condutor)AluguelAtual.Cliente : (Condutor)cb_motoristas.SelectedItem;
            AluguelAtual.TipoPlano = (Plano)cbPlano.SelectedIndex;
            AluguelAtual.Funcionario = TelaPrincipal.Instancia.FuncionarioLogado;
            AluguelAtual.DataAluguel = dataAluguel;

            return AluguelAtual;
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
            listServicos.DataSource = entidade.Servicos;
            return this;
        }

        private void SetCondutor()
        {
            if (entidade.Cliente is ClientePJ clientePJ)
            {
                cb_motoristas.DataSource = clientePJ.Motoristas;
                cb_motoristas.SelectedItem = entidade.Condutor;
            }
            else
            {
                cb_motoristas.Items.Add("----");
                cb_motoristas.SelectedIndex = 0;
            }
        }
        private void GetCondutor()
        {
            if (AluguelAtual.Cliente is ClientePJ)
                PopularMotoristas();
            else
                cb_motoristas.SelectedItem = "----";
        }

        private void PopulaVeiculo()
        {
            tbMarca.Text = AluguelAtual.Veiculo.Marca;
            tbModelo.Text = AluguelAtual.Veiculo.Modelo;
            tbPlaca.Text = AluguelAtual.Veiculo.Placa;
        }
        private void PopularCliente()
        {
            tbCliente.Text = AluguelAtual.Cliente.Nome;
            tbDocumento.Text = AluguelAtual.Cliente.Documento;
            tbEndereço.Text = AluguelAtual.Cliente.Endereco;
            tbTelefone.Text = AluguelAtual.Cliente.Telefone;

            GetCondutor();
        }
        private void PopularMotoristas()
        {
            cb_motoristas.DataSource = ((ClientePJ)AluguelAtual.Cliente).Motoristas;
        }

        private void AdicionarServico()
        {
            entidade.Servicos.Add((Servico)listServicos.SelectedItem);
            CalcularPrecoParcial();
            AluguelAtual.Servicos.Add((Servico)listServicos.SelectedItem);
            lbValor.Text = CalcularPrecoParcial().ToString();
        }
        private void RemoverServico()
        {
            if (entidade.Servicos.Contains((Servico)listServicos.SelectedItem)) ;
            entidade.Servicos.Remove((Servico)listServicos.SelectedItem);

            CalcularPrecoParcial();
        }
        private double CalcularPrecoParcial()
        {
            AluguelAtual.Servicos.ForEach(x => PrecoParcial += x.Taxa);

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
        }
        private void CalculaPlanoControlado()
        {
            PrecoParcial += (entidade.Veiculo.Categoria.PrecoDiaria * GetQtdDias()) + 
                entidade.Veiculo.Categoria.QuilometragemFranquia * entidade.Veiculo.Categoria.PrecoKm;
        }
        private void CalculaPlanoDiario()
        {
            PrecoParcial += entidade.Veiculo.Categoria.PrecoDiaria * GetQtdDias();
        }
        private void CalculaPlanoLivre()
        {
            PrecoParcial += (entidade.Veiculo.Categoria.PrecoDiaria * GetQtdDias()) * 1.3;
        }
        private int GetQtdDias()
        {
            DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dtDevolucao);
            DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dtEmprestimo);

            return (dtDevolucao - dtEmprestimo).Days;
        }
        private void CarregarOpcionais()
        {
            listServicos.DataSource = new ControladorServico().Registros;
        }

        #region Eventos
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            if (Salva())
            {
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoAluguel();
                AluguelAtual = new Aluguel();
            }
        }
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente("Selecione um Cliente", TipoTela.ApenasConfirma);
        }
        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoVeiculo("Selecione um Veículo", TipoTela.ApenasConfirma);
        }
        private void bt_AddServico_Click(object sender, EventArgs e)
        {
            AdicionarServico();
        }
        private void bt_RemoveServico_Click(object sender, EventArgs e)
        {
            RemoverServico();
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            tipAluguel.SetToolTip(pictureBox1, "Clique duas vezes nos painéis para adicionar as informações necessárias.");
        }
        private bool VerificaCampos()
        {
            if (cbPlano.SelectedIndex != -1 && tbDt_Emprestimo.Text != "" && tbDt_Devolucao.Text != "")
                return true;
            return false;


        }
        private void tbDt_Emprestimo_Leave(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                CalcularPrecoParcial();
            }
        }
        private void cbPlano_Leave(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                CalcularPrecoParcial();
            }
        }
        private void tbDt_Devolucao_Leave(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                CalcularPrecoParcial();
            }
        }

        #endregion
    }
}