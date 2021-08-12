using System;

namespace Dominio.PessoaModule
{
    public class ClientePJ : PessoaJuridica, ICliente
    {
        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
