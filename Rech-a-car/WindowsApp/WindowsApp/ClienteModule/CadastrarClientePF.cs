using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Globalization;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastrarClientePF : CadastroEntidade<ClientePF>
    {
        public override Controlador<ClientePF> Controlador { get => new ControladorClientePF(); }

        public CadastrarClientePF()
        {
            InitializeComponent();
            cbTipoCNH.SelectedIndex = 2;
        }

        public override CadastroEntidade<ClientePF> Editar(ClientePF clientePF)
        {
            throw new NotImplementedException();
        }

        public override ClientePF GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var documento = tbCPF.Text;
            var cnh = GetCNH();
            DateTime dataNascimento = DateTime.ParseExact(mtbNascimento.Text, "dd / MM / yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
            return new ClientePF(nome, telefone, endereco, documento, cnh, dataNascimento);
        }

        public CNH GetCNH()
        {
            var numero = tbCNH.Text;
            var tipo = cbTipoCNH.SelectedIndex;

            return new CNH(numero, (TipoCNH)tipo);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente();
        }
    }
}
