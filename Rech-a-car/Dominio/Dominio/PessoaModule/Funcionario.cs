using System.Drawing;

namespace Dominio.PessoaModule
{
    public class Funcionario : PessoaFisica, Usuario
    {
        public Funcionario(string nome, string telefone, string endereco, string documento, Image foto, string usuario)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Foto = foto;
            NomeUsuario = usuario;
        }
        public Image Foto { get; set; }
        public string NomeUsuario { get; set; }
        public override string Validar()
        {
            var validacao = base.Validar();

            if (NomeUsuario.Length < 5)
                validacao += "Nome de usuário inválido\n";

            return validacao;
        }
        public string ValidarSenha(string senha)
        {
            if (senha.Length < 8)
                return "Senha precisa ter no mínimo 8 caracteres";
            else
                return "";
        }
    }
}
