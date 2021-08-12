using System;

namespace Dominio.PessoaModule
{
    public class ClientePJ : PessoaJuridica, Cliente
    {
        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
