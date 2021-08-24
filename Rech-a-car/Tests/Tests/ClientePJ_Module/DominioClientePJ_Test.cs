using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule;
using FluentAssertions;
using System.Collections.Generic;

namespace Tests.Tests.ClientePJ_Module
{
    [TestClass]
    public class DominioClientePJ_Test
    {

        [TestMethod]
        public void Deve_retornar_clientePJ_valido()
        {

            ClientePJ clienteValido = new ClientePJ("nome", "99999999999", "endereco", "99999999999999");
            clienteValido.Validar().Should().Be(clienteValido.Valido);
        }
        [TestMethod]
        public void Deve_retornar_clientePJ_invalido()
        {
            ClientePJ clienteValido = new ClientePJ(string.Empty, string.Empty, string.Empty, string.Empty);
            clienteValido.Validar().Should().Be("Insira um Nome.\nTelefone inválido.\nInsira um endereço.\nO cliente necessita de um CNPJ válido.\n");
        }
    }
}
