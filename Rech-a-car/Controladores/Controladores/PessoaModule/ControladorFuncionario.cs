using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.PessoaModule
{
    public class ControladorFuncionario : ControladorEntidade<Funcionario>
    {
        #region Queries
        private const string sqlInserirFuncionario =
    @"INSERT INTO [TBFUNCIONARIO]
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

        private const string sqlEditarFuncionario =
            @" UPDATE [TBFUNCIONARIO]
                SET 
                    [NOME] = @NOME,       
                    [TELEFONE] = @TELEFONE,             
                    [ENDERECO] = @ENDERECO,
                    [DOCUMENTO] = @DOCUMENTO,
                WHERE [ID] = @ID";

        private const string sqlExcluirFuncionario =
            @"DELETE FROM [TBFUNCIONARIO] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarFuncionario =
            @"SELECT *
             FROM
                [TBFUNCIONARIO]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosFuncionarios =
            @"SELECT *
             FROM
                [TBFUNCIONARIO]";

        private const string sqlExisteFuncionario =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBFUNCIONARIO]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string sqlSelecionarPorId => sqlSelecionarFuncionario;
        public override string sqlSelecionarTodos => sqlSelecionarTodosFuncionarios;
        public override string sqlInserir => sqlInserirFuncionario;
        public override string sqlEditar => sqlEditarFuncionario;
        public override string sqlExcluir => sqlExcluirFuncionario;
        public override string sqlExists => sqlExisteFuncionario;
        public override Funcionario ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var documento = Convert.ToString(reader["DOCUMENTO"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);

            return new Funcionario(nome, telefone, documento, endereco)
            {
                Id = id
            };
        }
        protected override Dictionary<string, object> ObterParametrosRegistro(Funcionario funcionario)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", funcionario.Id },
                { "MODELO", funcionario.Nome },
                { "MARCA", funcionario.Endereco },
                { "ANO", funcionario.Telefone },
                { "ENDERECO", funcionario.Endereco },
            };

            return parametros;
        }
    }
}
