namespace Dominio.PessoaModule
{
    public interface ICliente
    {
        string Nome { get; set; }
        string Telefone { get; set; }
        string Endereco { get; set; }
        string Documento { get; set; }
    }
}
