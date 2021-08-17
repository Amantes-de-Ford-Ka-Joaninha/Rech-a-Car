namespace Dominio.PessoaModule
{
    public abstract class PessoaFisica : Pessoa
    {
        public override string ValidaDocumento(string documento)
        {
            string validador = string.Empty;
            if (Documento.Length != 11)
                validador += "O cliente necessita de um CPF válido.\n";

            return validador;
        }
    }
}
