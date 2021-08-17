using System;
using System.Text.RegularExpressions;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePF : Condutor, ICliente
    {
        public ClientePF(string nome, string telefone, string endereco, string documento)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
        }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }

        Regex validaTelefone = new Regex(@"\b[1-9]{2}[1-9]{9}\b");

        public override string Validar()
        {
            string validador = string.Empty;

            if (Nome == string.Empty)
                validador = "O cliente necessita de um nome.\n";
            if (!validaTelefone.IsMatch(Telefone))
                validador += "Telefone inválido.\n";
            if (Endereco == string.Empty)
                validador += "O cliente necessita de um endereço.\n";
            if (Documento.Length != 11)
                validador += "O cliente necessita de um CPF válido.\n";

            validador += Cnh.Validar();

            return validador;
        }
    }
}
