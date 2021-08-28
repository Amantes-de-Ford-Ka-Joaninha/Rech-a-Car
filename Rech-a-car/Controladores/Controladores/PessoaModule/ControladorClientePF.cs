using Controladores.Shared;
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
                    [DATA_NASCIMENTO],
                    [ID_CNH]
                )
            VALUES
                (
                    @NOME,       
                    @TELEFONE,             
                    @ENDERECO,
                    @DOCUMENTO,
                    @DATA_NASCIMENTO,
                    @ID_CNH
                )";

        private const string sqlEditarClientePF =
            @" UPDATE [TBCLIENTEPF]
                SET 
                    [NOME] = @NOME,       
                    [TELEFONE] = @TELEFONE,             
                    [ENDERECO] = @ENDERECO,
                    [DOCUMENTO] = @DOCUMENTO,
                    [DATA_NASCIMENTO] = @DATA_NASCIMENTO
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
        public override void Inserir(ClientePF cliente, int id_chave_estrangeira = 0)
        {
            new ControladorCNH().Inserir(cliente.Cnh);
            base.Inserir(cliente);
        }
        public override ClientePF ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var documento = Convert.ToString(reader["DOCUMENTO"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);
            var data_nascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);

            var id_cnh = Convert.ToInt32(reader["ID_CNH"]);
            var cnh = new ControladorCNH().GetByIdCondutor(id_cnh);

            return new ClientePF(nome, telefone, endereco, documento, cnh, data_nascimento)
            {
                Id = id
            };
        }
        protected override Dictionary<string, object> ObterParametrosRegistro(ClientePF cliente)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", cliente.Id },
                { "NOME", cliente.Nome },
                { "ENDERECO", cliente.Endereco },
                { "TELEFONE", cliente.Telefone },
                { "DOCUMENTO", cliente.Documento },
                { "DATA_NASCIMENTO", cliente.DataNascimento },
                { "ID_CNH", cliente.Cnh.Id },
            };

            return parametros;
        }
    }
}
