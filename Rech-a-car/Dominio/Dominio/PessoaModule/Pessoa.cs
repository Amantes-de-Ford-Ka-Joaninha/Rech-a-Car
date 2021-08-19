using Dominio.Shared;
using System.Text.RegularExpressions;

namespace Dominio.PessoaModule
{
    public abstract class Pessoa : Entidade
    {
        Regex validaTelefone = new Regex(@"\b[1-9]{2}[1-9]{9}\b");
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }

        public override string Validar()
        {
            string validador = string.Empty;

            if (Nome == string.Empty)
                validador = "Insira um Nome.\n";
            if (!validaTelefone.IsMatch(Telefone))
                validador += "Telefone inválido.\n";
            if (Endereco == string.Empty)
                validador += "Insira um endereço.\n";

            validador += ValidaDocumento();

            return validador;
        }
        protected abstract string ValidaDocumento();
    }
}
