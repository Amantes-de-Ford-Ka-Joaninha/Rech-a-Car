using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule;
using FluentAssertions;

namespace Tests.Tests.ClientePF_Module
{
    [TestClass]
    public class DominioClientePF_Test
    {
        [TestMethod]
        public void Deve_retornar_clientePF_valido()
        {
            CNH cnh = new CNH(36510896881,1);
            ClientePF clienteValido = new ClientePF("nome", "99999999999", "endereco", "99999999999", cnh);
            clienteValido.Validar().Should().Be(clienteValido.Valido);
        }
        [TestMethod]
        public void Deve_retornar_clientePF_invalido()
        {
            CNH cnh = new CNH(36510896881, 1);
            ClientePF clienteInvalido = new ClientePF(string.Empty, string.Empty, string.Empty, string.Empty, cnh);
            clienteInvalido.Validar().Should().Be("Insira um Nome.\nTelefone inválido.\nInsira um endereço.\nO cliente necessita de um CPF válido.\n");
        }
    }
}
