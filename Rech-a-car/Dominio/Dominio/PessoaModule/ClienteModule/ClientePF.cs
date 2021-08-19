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
            return (DateTime.Now-DataNascimento).Days / 365;
        }

        public override string Validar()
        {
            string validacao = base.Validar();

            if (GetIdade() < 18)
                validacao = "Idade mínima para dirigir é de 18 anos.\n";

            if (validacao == String.Empty)
                return Valido;

            return validacao;
        }
    }
}