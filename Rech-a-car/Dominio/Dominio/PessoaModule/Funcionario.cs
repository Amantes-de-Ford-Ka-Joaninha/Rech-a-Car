using System.Drawing;

namespace Dominio.PessoaModule
{
    public class Funcionario : PessoaFisica , Usuario
    {
        public Funcionario(string nome, string telefone, string endereco, string documento, Image foto, string usuario)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Foto = foto;
            Usuario = usuario;
        }
        public Image Foto { get; private set; }
        public string Usuario { get; private set; }
    }
}
