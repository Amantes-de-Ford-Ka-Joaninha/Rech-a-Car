﻿using Controladores.Shared;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.PessoaModule
{
    public class ControladorClientePF : ControladorEntidade<ClientePF>
    {
        #region Queries
        private const string sqlInserirClientePF =
    @"INSERT INTO [TBCLIENTEPF]
                (
                    [NOME],       
                    [TELEFONE],             
                    [ENDERECO],
                    [DOCUMENTO],
                    [DATA_NASCIMENTO]
                )
            VALUES
                (
                    @NOME,       
                    @TELEFONE,             
                    @ENDERECO,
                    @DOCUMENTO,
                    @DATA_NASCIMENTO
                )";

        private const string sqlEditarClientePF =
            @" UPDATE [TBCLIENTEPF]
                SET 
                    [NOME] = @NOME,       
                    [TELEFONE] = @TELEFONE,             
                    [ENDERECO] = @ENDERECO,
                    [DOCUMENTO] = @DOCUMENTO,
                    [DATA_NASCIMENTO] = @DATA_NASCIMENTO,
                WHERE [ID] = @ID";

        private const string sqlExcluirClientePF =
            @"DELETE FROM [TBCLIENTEPF] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarClientePFPorId =
            @"SELECT *
             FROM
                [TBCLIENTEPF]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosClientePF =
            @"SELECT *
             FROM
                [TBCLIENTEPF]";

        private const string sqlExisteClientePF =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTEPF]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string sqlSelecionarPorId => sqlSelecionarClientePFPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosClientePF;
        public override string sqlInserir => sqlInserirClientePF;
        public override string sqlEditar => sqlEditarClientePF;
        public override string sqlExcluir => sqlExcluirClientePF;
        public override string sqlExists => sqlExisteClientePF;
        public override ClientePF ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var documento = Convert.ToString(reader["DOCUMENTO"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);
            var data_nascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
            var cnh = new ControladorCNH().GetByIdCondutor(id);

            return new ClientePF(nome, telefone, documento, endereco, cnh,data_nascimento)
            {
                Id = id
            };
        }
        protected override Dictionary<string, object> ObterParametrosRegistro(ClientePF cliente)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", cliente.Id },
                { "MODELO", cliente.Nome },
                { "MARCA", cliente.Endereco },
                { "ANO", cliente.Telefone },
                { "ENDERECO", cliente.Endereco },
                { "DATA_NASCIMENTO", cliente.DataNascimento },
            };

            return parametros;
        }
    }
}
