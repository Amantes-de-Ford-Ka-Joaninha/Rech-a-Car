using Dominio.AluguelModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tests.Tests.AlguelModule
{
    [TestClass]
    public class DominioAluguelTest
    {
        Aluguel aluguel;
        DadosDevolucao dados;
        AluguelFechado aluguelFechado;
        Veiculo veiculo;
        CNH cnh;
        MotoristaEmpresa motoristaEmpresa;
        ClientePF clientepf;
        ClientePJ clientepj;
        Image imagem = Image.FromFile(@"..\..\Resources\ford_ka_gay.jpg");
        Categoria categoria;
        List<Servico> servicos;
        Funcionario funcionario;

        [TestMethod]
        public void Deve_retornar_aluguel_clientePF_valido()
        {
            categoria = new Categoria("nome", 2, 2, 2, 2, TipoCNH.A);
            veiculo = new Veiculo("modelo", "marca", 1, "ASD1234", 1, 1, 1, "123456789123", 2, imagem, true, categoria, TipoCombustivel.Diesel);
            servicos = new List<Servico>() { new Servico("1", 1), new Servico("2", 2) };
            cnh = new CNH("numero", TipoCNH.A);
            clientepf = new ClientePF("nome", "49999155922", "endereço", "013108478983", cnh, new DateTime(2001, 09, 10));
            funcionario = new Funcionario("nome", "49999155922", "endereco", "01308174983", imagem, "usuario");
            aluguel = new Aluguel(veiculo, servicos, Plano.diario, new DateTime(2001, 09, 10), clientepf, funcionario);

            aluguel.Validar().Should().NotBe(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_aluguel_clientePF_invalido()
        {
            aluguel = new Aluguel(null, null, Plano.controlado, new DateTime(), null, null);

            aluguel.Validar().Should().NotBe(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_aluguel_clientePJ_valido()
        {

            categoria = new Categoria("nome", 2, 2, 2, 2, TipoCNH.A);
            veiculo = new Veiculo("modelo", "marca", 1, "ASD1234", 1, 1, 1, "123456789123", 2, imagem, true, categoria, TipoCombustivel.Diesel);
            servicos = new List<Servico>() { new Servico("1", 1), new Servico("2", 2) };
            cnh = new CNH("numero", TipoCNH.A);
            clientepj = new ClientePJ("nome", "4999915522", "endereço", "0131038190371");
            motoristaEmpresa = new MotoristaEmpresa("nome", "123123123", "endereço", "d12398127", cnh);
            funcionario = new Funcionario("nome", "49999155922", "endereco", "01308174983", imagem, "usuario");
            aluguel = new Aluguel(veiculo, servicos, Plano.diario, new DateTime(2001, 09, 10), clientepj, funcionario, motoristaEmpresa);

            aluguel.Validar().Should().NotBe(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_aluguel_clientePJ_invalido()
        {
            aluguel = new Aluguel(null, null, Plano.controlado, new DateTime(), null, null, null);

            aluguel.Validar().Should().NotBe(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_aluguel_pf_fechado_valido()
        {
            servicos = new List<Servico>() { new Servico("1", 1), new Servico("2", 2) };
            dados = new DadosDevolucao(2, 2, servicos);
            aluguelFechado = aluguel.Fechar(dados);
            aluguelFechado.Validar().Should().Be(string.Empty);
        }
        [TestMethod]
        public void Deve_retornar_aluguel_pf_fechado_invalido()
        {
            servicos = new List<Servico>() { new Servico("1", 1), new Servico("2", 2) };
            dados = new DadosDevolucao(2, 2, servicos);
            aluguelFechado = aluguel.Fechar(dados);
            aluguelFechado.Validar().Should().NotBe(string.Empty);
        }
    }
}
