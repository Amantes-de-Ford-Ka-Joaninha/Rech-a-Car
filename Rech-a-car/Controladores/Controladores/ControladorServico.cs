using Controladores.Shared;
using Dominio.ServicoModule;
using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores
{
    public class ControladorServico : ControladorEntidade<Servico>
    {
        #region Queries
        private const string sqlInserirServico =
           @"INSERT INTO [TBServico]
             (   
                [NOME],            
                [Taxa]
             )
          VALUES
             (            
                @NOME,            
                @TAXA

             )";

        private const string sqlEditarServico =
           @"UPDATE [TBServico]
            SET
                [NOME] = @NOME,          
                [TAXA] = @TAXA
            WHERE
                [ID] = @ID";

        private const string sqlExcluirServico =
           @"DELETE FROM [TBServico] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarServicoPorId =
           @"SELECT *        
            FROM
               [TBServico]
            WHERE 
               [ID] = @ID";

        private const string sqlSelecionarTodosServicos =
           @"SELECT *
            FROM 
               [TBServico]";

        private const string sqlExisteServico =
           @"SELECT 
                COUNT(*) 
            FROM 
                [TBServico]
            WHERE 
                [ID] = @ID";

        #endregion

        public override string sqlSelecionarPorId => sqlSelecionarServicoPorId;

        public override string sqlSelecionarTodos => sqlSelecionarTodosServicos;

        public override string sqlInserir => sqlInserirServico;

        public override string sqlEditar => sqlEditarServico;

        public override string sqlExcluir => sqlExcluirServico;

        public override string sqlExists => sqlExisteServico;


        public override Servico ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            double taxa = Convert.ToDouble(reader["TAXA"]);
           
            Servico servico = new Servico(nome, taxa)
            {
                Id = id
            };

            return servico;
        }

        protected override Dictionary<string, object> ObterParametrosRegistro(Servico servico)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", servico.Id },
                { "NOME", servico.Nome },
                { "TAXA", servico.Taxa }

            };
            return parametros;
        }

       
        
    }
}