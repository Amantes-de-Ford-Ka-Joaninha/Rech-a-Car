using Controladores.PessoaModule;
using Dominio.PessoaModule;
using System;
using System.Windows.Forms;

namespace WindowsApp.WindowsApp
{
    public partial class Login : Form
    {

        private ControladorFuncionario ControladorFuncionario = new ControladorFuncionario();
        private Funcionario funcionario;

        public Login()
        {
            InitializeComponent();
            bt_entrar.Enabled = false;
        }

        private ResultadoLogin LoginUsuario()
        {
            var usuario = tbUsuario.Text;
            var senha = tbSenha.Text;

            if (!ExisteUsuario(usuario))
                return ResultadoLogin.UsuarioNaoCadastrado;

            getFuncionario();

            if (!Logar(funcionario.NomeUsuario, senha))
                return ResultadoLogin.SenhaErrada;

            return ResultadoLogin.Sucesso;
        }
        private bool Logar(string user, string senha)
        {
            return new ControladorSenha().SenhaCorreta(user, senha);
        }
        private bool ExisteUsuario(string usuario)
        {
            return ControladorFuncionario.ExisteUsuario(usuario);
        }
        private void getFuncionario()
        {
            funcionario = ControladorFuncionario.GetByUserName(tbUsuario.Text);
        }
        private string mostraResultado(ResultadoLogin resultado)
        {
            switch (resultado)
            {
                case ResultadoLogin.SenhaErrada: return "Senha errada!";
                case ResultadoLogin.UsuarioNaoCadastrado: return "Usuário não está cadastrado!";
                case ResultadoLogin.Sucesso: return "Sucesso!";
                default: return "Error";
            }
        }
        private void bt_entrar_Click(object sender, EventArgs e)
        {
            //var resultadoLogin = LoginUsuario();
            //MessageBox.Show(mostraResultado(resultadoLogin));
            //if (resultadoLogin != ResultadoLogin.Sucesso)
            //    return;
            new TelaPrincipal(funcionario).Show();
            Close();
        }
        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            BloquearBotaoLogin();
        }
        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            BloquearBotaoLogin();
        }
        private void BloquearBotaoLogin()
        {
            if (LoginInvalido())
                bt_entrar.Enabled = false;
            else
                bt_entrar.Enabled = true;
        }
        private bool LoginInvalido()
        {
            return tbSenha.Text == string.Empty || tbUsuario.Text == string.Empty;
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TelaPrincipal.Instancia == null)
                Application.Exit();
        }
    }
    public enum ResultadoLogin { Sucesso, SenhaErrada, UsuarioNaoCadastrado }
}