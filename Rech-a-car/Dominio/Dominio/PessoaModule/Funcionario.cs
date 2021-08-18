namespace Dominio.PessoaModule
{
    public class Funcionario : PessoaFisica
    {
        public Funcionario(string nome, string telefone, string endereco, string documento)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
        }
    }
}
