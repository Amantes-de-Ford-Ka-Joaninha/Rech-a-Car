using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio.PessoaModule;
using FluentAssertions;

namespace Tests.Tests.FuncionarioModule
{
    [TestClass]
    public class DominioFuncionario
    {
        Funcionario funcionario;

        [TestMethod]
        public void Deve_retornar_funcionario_valido()
        {
            funcionario = new Funcionario("Nome", "49999155922", "Rua dos testes", "01310847983");
            funcionario.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_funcionario_invalido()
        {
            funcionario = new Funcionario("", "", "", "");
            funcionario.Validar().Should().NotBe(string.Empty);

        }
    }
}
