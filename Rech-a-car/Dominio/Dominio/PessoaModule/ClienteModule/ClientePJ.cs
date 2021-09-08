using System.Collections.Generic;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePJ : PessoaJuridica, ICliente
    {
        public List<MotoristaEmpresa> Motoristas { get; set; } = new List<MotoristaEmpresa>();
        public string Email { get; set; }

        public ClientePJ(string nome, string telefone, string endereco, string documento, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            Email = email;
        }
    }
}