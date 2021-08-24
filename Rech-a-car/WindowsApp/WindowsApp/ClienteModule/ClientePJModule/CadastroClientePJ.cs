using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;
using WindowsApp.VeiculoModule;
using WindowsApp.WindowsApp.ClienteModule;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroClientePJ : CadastroEntidade<ClientePJ>
    {
        public override Controlador<ClientePJ> Controlador { get => new ControladorClientePJ(); }

        public CadastroClientePJ()
        {
            InitializeComponent();
        }

        public override CadastroEntidade<ClientePJ> Editar(ClientePJ clientePJ)
        {
            tbNome.Text = clientePJ.Nome;
            tbTelefone.Text = clientePJ.Telefone;
            tbEndereco.Text = clientePJ.Endereco;
            tbCNPJ.Text = clientePJ.Documento;

            return this;
        }

        public override ClientePJ GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var documento = tbCNPJ.Text;
            return new ClientePJ(nome, telefone, endereco, documento);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente();
        }

        private void btMotorista_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new CadastroMotorista(entidade);
        }
    }
}
