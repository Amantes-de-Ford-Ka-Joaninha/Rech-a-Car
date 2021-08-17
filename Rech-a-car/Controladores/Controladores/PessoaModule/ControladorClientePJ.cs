using System;
using System.Collections.Generic;
using System.Data;
using Dominio.PessoaModule.ClienteModule;

namespace Controladores.PessoaModule
{
    public class ControladorClientePJ : ControladorEntidade<ClientePJ>
    {
        private const string sqlInserirClientePF =
    @"INSERT INTO [TBCLIENTEPJ]
                (
                    [NOME],       
                    [TELEFONE],             
                    [ENDERECO],
                    [DOCUMENTO],
                )
            VALUES
                (
                    @NOME,       
                    @TELEFONE,             
                    @ENDERECO,
                    @DOCUMENTO,
                )";

        private const string sqlEditarClientePF =
            @" UPDATE [TBCLIENTEPJ]
                SET 
                    [NOME] = @MODELO,       
                    [TELEFONE] = @MARCA,             
                    [ENDERECO] = @CATEGORIA,
                    [DOCUMENTO] = @ANO,
                WHERE [ID] = @ID";

        private const string sqlExcluirClientePF =
            @"DELETE FROM [TBCLIENTEPJ] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarClientePFPorId =
            @"SELECT *
             FROM
                [TBCLIENTEPJ]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosClientePF =
            @"SELECT *
             FROM
                [TBCLIENTEPJ]";

        private const string sqlExisteClientePF =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTEPJ]
            WHERE 
                [ID] = @ID";
        public override string sqlSelecionarPorId => sqlSelecionarClientePFPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosClientePF;
        public override string sqlInserir => sqlInserirClientePF;
        public override string sqlEditar => sqlEditarClientePF;
        public override string sqlExcluir => sqlExcluirClientePF;
        public override string sqlExists => sqlExisteClientePF;

        protected override ClientePJ ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var documento = Convert.ToString(reader["DOCUMENTO"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);
            var condutores = new ControladorMotorista().SelecionarCondutoresPJ(id);

            return new ClientePJ(nome,telefone,documento,endereco,condutores)
            {
                Id = id
            };
        }
        protected override Dictionary<string, object> ObtemParametrosRegistro(ClientePJ registro)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", registro.Id },
                { "MODELO", registro.Nome },
                { "MARCA", registro.Endereco },
                { "ANO", registro.Telefone },
                { "ENDERECO", registro.Endereco },
            };

            return parametros;
        }
    }
}
