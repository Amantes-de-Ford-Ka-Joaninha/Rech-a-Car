using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;
using WindowsApp.VeiculoModule;

namespace WindowsApp.ClienteModule
{
    public partial class CadastrarClientePJ : CadastroEntidade<ClientePJ>
    {
        public override Controlador<ClientePJ> Controlador { get => new ControladorClientePJ(); }

        public CadastrarClientePJ()
        {
            InitializeComponent();
        }

        public override CadastroEntidade<ClientePJ> Editar(ClientePJ clientePJ)
        {
            throw new NotImplementedException();
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
    }
}
