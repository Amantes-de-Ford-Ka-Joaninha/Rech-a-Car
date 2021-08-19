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
            var motoristas = GetMotorista();
            return new ClientePJ(nome, telefone, endereco, documento, motoristas);
        }

        public List<MotoristaEmpresa> GetMotorista()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var documento = tbCNPJ.Text;
            var cnh = GetCNH();
            MotoristaEmpresa motora = new MotoristaEmpresa(nome, telefone, endereco, documento, cnh);
            
        }

        public CNH GetCNH()
        {
            var numero = tbNome.Text;
            var tipo = cbTipoCNH.SelectedIndex;

            return new CNH(numero, (TipoCNH)tipo);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Salva();
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoClientes();
        }
    }
}
