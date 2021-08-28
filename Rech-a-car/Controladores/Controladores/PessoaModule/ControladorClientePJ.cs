using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.PessoaModule
{
    public class ControladorClientePJ : ControladorEntidade<ClientePJ>
    {
        #region Queries
        private const string sqlInserirClientePJ =
    @"INSERT INTO [TBCLIENTEPJ]
                (
                    [NOME],       
                    [TELEFONE],             
                    [ENDERECO],
                    [DOCUMENTO]
                )
            VALUES
                (
                    @NOME,       
                    @TELEFONE,             
                    @ENDERECO,
                    @DOCUMENTO
                )";

        private const string sqlEditarClientePJ =
            @" UPDATE [TBCLIENTEPJ]
                SET 
                    [NOME] = @NOME,       
                    [TELEFONE] = @TELEFONE,             
                    [ENDERECO] = @ENDERECO,
                    [DOCUMENTO] = @DOCUMENTO
                WHERE [ID] = @ID";

        private const string sqlExcluirClientePJ =
            @"DELETE FROM [TBCLIENTEPJ] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarClientePJPorId =
            @"SELECT *
             FROM
                [TBCLIENTEPJ]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosClientePJ =
            @"SELECT *
             FROM
                [TBCLIENTEPJ]";

        private const string sqlExisteClientePJ =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTEPJ]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string sqlSelecionarPorId => sqlSelecionarClientePJPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosClientePJ;
        public override string sqlInserir => sqlInserirClientePJ;
        public override string sqlEditar => sqlEditarClientePJ;
        public override string sqlExcluir => sqlExcluirClientePJ;
        public override string sqlExists => sqlExisteClientePJ;

        public override ClientePJ ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var documento = Convert.ToString(reader["DOCUMENTO"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);

            return new ClientePJ(nome, telefone, endereco, documento)
            {
                Id = id,
                Motoristas = new ControladorMotorista().SelecionarCondutoresPJ(id)
            };
        }
        protected override Dictionary<string, object> ObterParametrosRegistro(ClientePJ cliente)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", cliente.Id },
                { "NOME", cliente.Nome },
                { "ENDERECO", cliente.Endereco },
                { "TELEFONE", cliente.Telefone },
                { "DOCUMENTO", cliente.Documento },
            };

            return parametros;
        }
    }
}