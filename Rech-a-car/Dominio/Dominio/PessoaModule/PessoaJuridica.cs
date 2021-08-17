namespace Dominio.PessoaModule
{
    public abstract class PessoaJuridica : Pessoa
    {
        public override string ValidaDocumento(string documento)
        {
            string validador = string.Empty;
            if (Documento.Length != 14)
                validador += "O cliente necessita de um CNPJ válido.\n";

            return validador;
        }
    }
}
