﻿using Controladores.Shared;
using Dominio.ServicoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.ServicoModule
{
    public class ControladorServico : ControladorEntidade<Servico>
    {
        #region Queries
        private const string sqlInserirServico =
           @"INSERT INTO [TBServico]
             (   
                [NOME],            
                [TAXA],
                [ESTOQUE]
             )
          VALUES
             (            
                @NOME,            
                @TAXA
                @ESTOQUE

             )";

        private const string sqlEditarServico =
           @"UPDATE [TBServico]
            SET
                [NOME] = @NOME,          
                [TAXA] = @TAXA,
                [ESTOQUE] = @ESTOQUE,
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
            int estoque = Convert.ToInt32(reader["ESTOQUE"]);

            Servico servico = new Servico(nome, taxa, estoque)
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
                { "TAXA", servico.Taxa },
                { "ESTOQUE", servico.Estoque }

            };
            return parametros;
        }

        public List<Servico> GetServicosAlugados(int idAluguel)
        {
            throw new NotImplementedException();
        }
    }
}