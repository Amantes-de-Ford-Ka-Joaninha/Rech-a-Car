using System.Collections.Generic;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePJ : PessoaJuridica, ICliente
    {
        public List<MotoristaEmpresa> Motoristas { get; set; }
        public ClientePJ(string nome, string telefone, string endereco, string documento, List<MotoristaEmpresa> motoristas)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Motoristas = motoristas;
        }
    }
}