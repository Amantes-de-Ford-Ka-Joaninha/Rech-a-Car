using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.FuncionarioModule;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.FuncionarioModule
{
    public partial class CadastroFuncionario : CadastroEntidade<Funcionario>
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        public override Controlador<Funcionario> Controlador => new ControladorFuncionario();

        public override CadastroEntidade<Funcionario> Editar(Funcionario funcionario)
        {
            tbNome.Text = funcionario.Nome;
            tbTelefone.Text = funcionario.Telefone;
            tbEndereco.Text = funcionario.Endereco;
            tbCPF.Text = funcionario.Documento;

            return this;
        }

        public override Funcionario GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var cpf = tbCPF.Text;

            return new Funcionario(nome, telefone, endereco, cpf);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Salva();
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoFuncionario();
        }
    }
}
