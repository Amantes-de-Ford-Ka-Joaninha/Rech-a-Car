﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Controladores.VeiculoModule;
using Dominio.VeiculoModule;
using System.Drawing;
using Controladores;
using Tests.Shared;

namespace Tests.VeiculoModule
{
    [TestClass]
    public class ControladorVeiculoTest
    {
        Veiculo veiculo1;
        ControladorVeiculo controladorVeiculo = new ControladorVeiculo();

        [TestInitialize]
        public void Inserir_Veiculo()
        {
            Image imagem = Image.FromFile(@"..\..\Resources\ford_ka_gay.jpg");
            DadosVeiculo dadosVeiculo = new DadosVeiculo(50000, 50, 10);
            veiculo1 = new Veiculo("Ka", "Ford", 2001, "ABC1024", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, false, "Compacto", dadosVeiculo);
            controladorVeiculo.Inserir(veiculo1);
        }

        [TestMethod]
        public void Deve_inserir_veiculo()
        {
            veiculo1.Id.Should().NotBe(0);
        }

        [TestMethod]
        public void Deve_editar_veiculo()
        {
            string marcaOriginal = veiculo1.Marca;

            veiculo1.Marca = "Marca diferente";
            controladorVeiculo.Editar(veiculo1.Id, veiculo1);

            controladorVeiculo.GetById(veiculo1.Id).Marca.Should().NotBe(marcaOriginal);
        }

        [TestMethod]
        public void Deve_remover_veiculo()
        {
            controladorVeiculo.Excluir(veiculo1.Id);
            controladorVeiculo.Exists(veiculo1.Id).Should().BeFalse();
        }

        [TestMethod]
        public void Deve_retornar_todos_os_veiculos()
        {
            controladorVeiculo.ObterRegistros().Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBVeiculo"));
        }
    }
}
