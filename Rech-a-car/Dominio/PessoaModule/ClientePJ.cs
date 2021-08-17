using System;

namespace Dominio.PessoaModule
{
    public class ClientePJ : PessoaJuridica, ICliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
