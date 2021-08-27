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
        Categoria categoria;


        [TestMethod]
        public void Deve_retornar_grupo_valido()
        {
            categoria = new Categoria("nome", 10, 10, 10, 10, TipoCNH.A);
            categoria.Validar().Should().Be(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_grupo_invalido()
        {
            categoria = new Categoria("", -10, -10, -10, -10, TipoCNH.A);
            categoria.Validar().Should().NotBe(string.Empty);
        }
    }
}
