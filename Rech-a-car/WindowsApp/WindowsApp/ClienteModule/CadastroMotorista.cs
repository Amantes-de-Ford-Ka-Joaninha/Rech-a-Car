using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.ClienteModule;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.ClienteModule
{
    public partial class CadastroMotorista : Form
    {
        public  ControladorClientePJ Controlador { get => new ControladorClientePJ(); }
        private ClientePJ clientePJ;

        public CadastroMotorista(ClientePJ clientePJ)
        {
            InitializeComponent();
            this.clientePJ = clientePJ;
        }
        
        private void Editar(MotoristaEmpresa motorista)
        {
            tbNome.Text = motorista.Nome;
            tbTelefone.Text = motorista.Telefone;
            tbEndereco.Text = motorista.Endereco;
            tbCPF.Text = motorista.Documento;
        }

        public MotoristaEmpresa GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var documento = lbCPF.Text;
            return new MotoristaEmpresa(nome, telefone, endereco, documento, GetCNH());
        }

        public CNH GetCNH()
        {
            var numero = tbCNH.Text;
            var tipo = cbTipoCNH.SelectedIndex;

            return new CNH(numero, (TipoCNH)tipo);
        }

        private void btAdicionarMotorista_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente();
        }

        private bool Salva()
        {
            MotoristaEmpresa motorista = GetNovaEntidade();
            var validacao = motorista.Validar();

            if (validacao != string.Empty)
            {
                MessageBox.Show(validacao);
                return false;
            }

            if (this.clientePJ == null)
                Controlador.Inserir(clientePJ);
            else
                Controlador.Editar(this.clientePJ.Id, clientePJ);

            MessageBox.Show("Realizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}
