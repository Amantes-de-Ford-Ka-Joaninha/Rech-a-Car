using System;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePF : Condutor, ICliente
    {
        public DateTime DataNascimento { get; set; }
        public ClientePF(string nome, string telefone, string endereco, string documento, CNH cnh, DateTime dataNascimento)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Cnh = cnh;
            DataNascimento = dataNascimento;
        }
        public int GetIdade()
        {
            return (DataNascimento - DateTime.Now).Days / 365;
        }
    }
}