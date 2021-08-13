using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio.VeiculoModule;
using System.Drawing;
using FluentAssertions;

namespace Tests.VeiculoModule
{
    [TestClass]
    public class DominioVeiculoTest
    {
        [TestMethod]
        public void Deve_retornar_tds_portamalas()
        {
            DadosVeiculo dadosVeiculo = new DadosVeiculo(50000, 50, 10);
            Image imagem = Image.FromFile(@"C:\vasco.png");

            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, true, "CATEGORIA", dadosVeiculo);
            Veiculo veiculo2= new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 1, imagem, true, "CATEGORIA", dadosVeiculo);
            Veiculo veiculo3 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 2, imagem, true, "CATEGORIA", dadosVeiculo);

            veiculo1.PortaMalaToString().Should().Be("Pequeno");
            veiculo2.PortaMalaToString().Should().Be("Médio");
            veiculo3.PortaMalaToString().Should().Be("Grande");
        }

        [TestMethod]
        public void Deve_retornar_tipos_de_cambio()
        {
            DadosVeiculo dadosVeiculo = new DadosVeiculo(50000, 50, 10);
            Image imagem = Image.FromFile(@"C:\vasco.png");
            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, false, "CATEGORIA", dadosVeiculo);
            Veiculo veiculo2 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 1, imagem, true, "CATEGORIA", dadosVeiculo);

            veiculo1.CambioToString().Should().Be("Manual");
            veiculo2.CambioToString().Should().Be("Automático");
        }

        [TestMethod]
        public void Deve_retornar_carro_valido()
        {
            DadosVeiculo dadosVeiculo = new DadosVeiculo(50000, 50, 10);
            Image imagem = Image.FromFile(@"C:\vasco.png");
            Veiculo veiculo1 = new Veiculo("MODELO", "MARCA", 2001, "AAA1111", 4, 4, "ASDFGHJKLQWERTYUI", 0, imagem, false, "CATEGORIA", dadosVeiculo);

            veiculo1.Validar().Should().Be("VALIDO");
        }

        [TestMethod]
        public void Deve_retornar_carro_invalido()
        {
            //Image imagem = null;
            DadosVeiculo dadosVeiculo = new DadosVeiculo(0, 0, 0);

            Veiculo veiculo1 = new Veiculo(null, null, DateTime.Now.Year+2, "PLACA", 0, 0, "CHASSI", -1, null, true, null, dadosVeiculo);

            veiculo1.Validar().Should().Be("Modelo do veículo é obrigatório\nMarca do veículo é obrigatória\nCategoria do veículo é obrigatória\nPlaca do veículo inválida\nChassi do veículo inválido\nDeve ter pelo menos duas Portas\nVolume do Porta-malas inválido\nAno do carro inválido\n");
        }

    }
}
