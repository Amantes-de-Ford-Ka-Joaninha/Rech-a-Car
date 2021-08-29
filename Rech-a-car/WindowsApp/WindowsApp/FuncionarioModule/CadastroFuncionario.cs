using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsApp.Properties;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public partial class CadastroFuncionario : CadastroEntidade<Funcionario>
    {
        public override Controlador<Funcionario> Controlador => new ControladorFuncionario();
        private Bitmap imagem;

        public CadastroFuncionario()
        {
            InitializeComponent();
            bt_foto.Image = Resources.user;
        }


        protected override IEditavel ConfigurarEditar()
        {
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            tbCPF.Text = entidade.Documento;
            tbUsuario.Text = entidade.NomeUsuario;
            bt_foto.Image = entidade.Foto;

            return this;
        }

        public override Funcionario GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var cpf = tbCPF.Text;
            var usuario = tbUsuario.Text;
            var imagem = (Bitmap)bt_foto.Image;

            return new Funcionario(nome, telefone, endereco, cpf, imagem, usuario);
        }

        private void AtualizarIcone(Bitmap imagem)
        {
            bt_foto.Image = new Bitmap(imagem);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoFuncionario();
        }

        private void bt_foto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
                };
                if (ofdImagem.ShowDialog() == DialogResult.OK)
                {
                    var imagemSelecionada = ofdImagem.FileName;
                    imagem = new Bitmap(imagemSelecionada);
                }
                AtualizarIcone(imagem);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato incorreto. Por favor, selecione um arquivo de imagem.", "Erro", 0, MessageBoxIcon.Exclamation);
            }
        }
    }
}
