using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public partial class CadastroFuncionario : Form//CadastroEntidade<Funcionario>
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        public override Controlador<Funcionario> Controlador => new ControladorFuncionario();

        protected override IEditavel ConfigurarEditar()
        {
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            tbCPF.Text = entidade.Documento;
            tbUsuario.Text = entidade.Usuario;

            return this;
        }

        public override Funcionario GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var cpf = tbCPF.Text;
            var usuario = tbUsuario.Text;
            imagem = (Bitmap)bt_foto.Image;

            return new Funcionario(nome, telefone, endereco, cpf, imagem, usuario);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoFuncionario();
        }

        private void bt_foto_Click(object sender, EventArgs e)
        {

        }
    }
}
