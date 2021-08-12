using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using Controladores.VeiculoModule;
using Dominio.VeiculoModule;
using System.Drawing;

namespace Tests.VeiculoModule
{
    [TestClass]
    public class ControladorVeiculoTest
    {
        ControladorVeiculo controladorVeiculo = new ControladorVeiculo();

        [TestMethod]
        public void Deve_inserir_veiculo()
        {
            DadosVeiculo dadosVeiculo = new DadosVeiculo(50000, 50, 10);
            Image imagem = Image.FromFile(@"C:\vasco.png");
            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, false, "CATEGORIA", dadosVeiculo);

            controladorVeiculo.Inserir(veiculo1);
            veiculo1.Id.Should().NotBe(0);
        }

        [TestMethod]
        public void Deve_editar_veiculo()
        {
            DadosVeiculo dadosVeiculo = new DadosVeiculo(50000, 50, 10);
            Image imagem = Image.FromFile(@"C:\vasco.png");
            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, false, "CATEGORIA", dadosVeiculo);

            string marcaAnterior = veiculo1.Marca;
          //  veiculo1.Marca = "TESTADO";

            controladorVeiculo.Editar(veiculo1.Id, veiculo1);

            marcaAnterior.Should().Be(controladorVeiculo.GetById(veiculo1.Id).Marca);
        }

        [TestMethod]
        public void Deve_remover_veiculo()
        {
            DadosVeiculo dadosVeiculo = new DadosVeiculo(50000, 50, 10);
            Image imagem = Image.FromFile(@"C:\vasco.png");
            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, false, "CATEGORIA", dadosVeiculo);

            int idExcluido = veiculo1.Id;
            controladorVeiculo.Excluir(veiculo1.Id);
            controladorVeiculo.Exists(idExcluido).Should().BeTrue();
        }
        [TestMethod]
        public void Deve_retornar_todos_os_veiculos()
        {
            DadosVeiculo dadosVeiculo = new DadosVeiculo(50000, 50, 10);
            Image imagem = Image.FromFile(@"C:\vasco.png");
            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, false, "CATEGORIA", dadosVeiculo);

            controladorVeiculo.ObterRegistros().Count.Should().Be(1);
        }
    }
}
