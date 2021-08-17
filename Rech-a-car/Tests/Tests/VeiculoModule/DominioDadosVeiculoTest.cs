using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using Dominio.VeiculoModule;

namespace Tests.VeiculoModule
{
    [TestClass]
    public class DominioDadosVeiculoTest
    {
        [TestMethod]
        public void Deve_retornar_dadosveiculo_valido()
        {
            DadosVeiculo dadosVeiculo = new DadosVeiculo(10, 10, 10);
            dadosVeiculo.Validar().Should().Be("VALIDO");
        }

        [TestMethod]
        public void Deve_retornar_dadosveiculo_invalido()
        {
            DadosVeiculo dadosVeiculo = new DadosVeiculo(-1, -1, -1);
            dadosVeiculo.Validar().Should().Be("Quilometragem inválida\nValor da diária deve ser maior que 0\nValor do preço por Km deve ser maior que 0\n");
        }
    }
}
