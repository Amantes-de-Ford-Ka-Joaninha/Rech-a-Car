namespace Dominio.PessoaModule
{
    public class MotoristaEmpresa : Condutor
    {
        public MotoristaEmpresa(string nome, string telefone, string endereco, string documento, CNH cnh)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Cnh = cnh;
        }

        public override string ToString()
        {
            return $"{Nome} | {Telefone}";
        }
    }
}
