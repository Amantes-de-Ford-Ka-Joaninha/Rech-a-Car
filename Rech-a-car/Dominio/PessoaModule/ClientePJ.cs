using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
