using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio.VeiculoModule;
using Dominio.PessoaModule;
using FluentAssertions;

namespace Tests.Tests.CategoriaModule
{
    [TestClass]
    public class DominioCategoria_Test
    {
        Grupo grupo;


        [TestMethod]
        public void Deve_retornar_grupo_valido()
        {
            grupo = new Grupo("nome", 10, 10, 10, 10, TipoCNH.A);
            grupo.Validar().Should().Be(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_grupo_invalido()
        {
            grupo = new Grupo("", -10, -10, -10, -10, TipoCNH.A);
            grupo.Validar().Should().NotBe(string.Empty);
        }
    }
}
