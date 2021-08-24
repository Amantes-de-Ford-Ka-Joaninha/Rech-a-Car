using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace Tests.VeiculoModule
{
    [TestClass]
    public class DominioVeiculoTest
    {
        Image imagem = Image.FromFile(@"..\..\Resources\ford_ka_gay.jpg");
        DadosVeiculo dadosVeiculo = new DadosVeiculo(50000, 50, 10);

        [TestMethod]
        public void Deve_retornar_tds_portamalas()
        {
            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, true, "CATEGORIA", dadosVeiculo);
            Veiculo veiculo2 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 1, imagem, true, "CATEGORIA", dadosVeiculo);
            Veiculo veiculo3 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 2, imagem, true, "CATEGORIA", dadosVeiculo);

            veiculo1.PortaMalaToString().Should().Be("Pequeno");
            veiculo2.PortaMalaToString().Should().Be("Médio");
            veiculo3.PortaMalaToString().Should().Be("Grande");
        }

        [TestMethod]
        public void Deve_retornar_tipos_de_cambio()
        {
            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, false, "CATEGORIA", dadosVeiculo);
            Veiculo veiculo2 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 1, imagem, true, "CATEGORIA", dadosVeiculo);

            veiculo1.CambioToString().Should().Be("Manual");
            veiculo2.CambioToString().Should().Be("Automático");
        }

        [TestMethod]
        public void Deve_retornar_carro_valido()
        {
            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, false, "CATEGORIA", dadosVeiculo);
            veiculo1.Validar().Should().Be(string.Empty);
        }

        [TestMethod]
        public void Deve_retornar_carro_invalido()
        {
            Veiculo veiculo1 = new Veiculo(string.Empty, string.Empty, DateTime.Now.Year + 2, "PLACA", 0, 0, "CHASSI", -1, null, true, string.Empty, dadosVeiculo);
            veiculo1.Validar().Should().Be("Modelo do veículo é obrigatório\nMarca do veículo é obrigatória\nCategoria do veículo é obrigatória\nPlaca do veículo inválida\nChassi do veículo inválido\nDeve ter pelo menos duas Portas\nVolume do Porta-malas inválido\nAno do carro inválido\n");
        }
    }
}
