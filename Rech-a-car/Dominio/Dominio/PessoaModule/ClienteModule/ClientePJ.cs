using System.Collections.Generic;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePJ : PessoaJuridica, ICliente
    {
        public ClientePJ(string nome, string telefone, string endereco, string documento, List<Condutor> condutores)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Condutores = condutores;
        }
    }
}