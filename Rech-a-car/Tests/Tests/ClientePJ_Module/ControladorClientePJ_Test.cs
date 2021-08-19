using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule;
using Controladores;
using Controladores.PessoaModule;
using FluentAssertions;
using Tests.Shared;
using System.Collections.Generic;

namespace Tests.Tests.ClientePJ_Module
{
    [TestClass]
    public class ControladorClientePJ_Test
    {
        ControladorClientePJ controladorClientePJ = new ControladorClientePJ();
        ClientePJ cliente;


        [TestInitialize]
        public void Inserir_clientePF()
        {
            List<MotoristaEmpresa> listaMotoristas = null;
            cliente = new ClientePJ("nome", "99999999999", "endereco", "99999999999999", listaMotoristas);
            controladorClientePJ.Inserir(cliente);
        }
        [TestMethod]
        public void Deve_inserir_cliente()
        {
            cliente.Id.Should().NotBe(0);
        }
        [TestMethod]
        public void Deve_editar_nome_cliente()
        {
            string nomeAnterior = cliente.Nome;

            cliente.Nome = "Nome editado";

            controladorClientePJ.Editar(cliente.Id, cliente);

            controladorClientePJ.GetById(cliente.Id).Nome.Should().NotBe(nomeAnterior);
        }
        [TestMethod]
        public void Deve_editar_telefone_cliente()
        {
            string telefoneAnterior = cliente.Telefone;

            cliente.Telefone = "000000000";

            controladorClientePJ.Editar(cliente.Id, cliente);

            controladorClientePJ.GetById(cliente.Id).Telefone.Should().NotBe(telefoneAnterior);
        }
        [TestMethod]
        public void Deve_editar_endereco_cliente()
        {
            string enderecoAnterior = cliente.Endereco;

            cliente.Endereco = "Endereco editado";

            controladorClientePJ.Editar(cliente.Id, cliente);

            controladorClientePJ.GetById(cliente.Id).Endereco.Should().NotBe(enderecoAnterior);
        }
        [TestMethod]
        public void Deve_editar_documento_cliente()
        {
            string documentoAnterior = cliente.Documento;

            cliente.Documento = "00000000000000";

            controladorClientePJ.Editar(cliente.Id, cliente);

            controladorClientePJ.GetById(cliente.Id).Documento.Should().NotBe(documentoAnterior);
        }
        [TestMethod]
        public void Deve_retornar_todos_os_clientesPJ()
        {
            controladorClientePJ.Registros.Count.Should().Be(1);
        }

        [TestCleanup]
        public void LimparTestes()
        {
            Db.Delete(TestExtensions.ResetId("TBClientePJ"));
        }
    }
}
