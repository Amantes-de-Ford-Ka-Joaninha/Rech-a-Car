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

        public override void Inserir(Servico servico)
        {
            base.Inserir(servico);
            servico.DadosServico.Id = servico.Id;
            new ControladorDadosServico().Inserir(dadosServico: servico.DadosServico);
        }

        public override void Editar(int id, Servico servico)
        {
            base.Editar(id, servico);
            new ControladorDadosServico().Editar(id, servico.DadosServico);
        }

        public override Servico ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            double taxa = Convert.ToDouble(reader["TAXA"]);
            var dadosServico = new ControladorDadosServico().SelecionarPorIdServico(id);
          
            Servico servico = new Servico(nome, taxa, dadosServico)
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

        private class ControladorDadosServico
        {
            #region Queries

            private const string sqlSelecionarDadosServicoPorIdServico =
               @"SELECT *
            FROM
               [TBServico]
             WHERE 
               [ID] = @ID";
            private const string sqlInserirDadosServico =
               @"INSERT INTO [TBServico]
               (
                  [ID],
                  [NOME],
                  [TAXA]
               )
          VALUES
               (
                  @ID,
                  @NOME,
                  @TAXA
               )";

            private const string sqlEditarDadosServico =
               @" UPDATE [TBServico]
             SET     
                   [NOME] = @NOME,
                   [TAXA] = @TAXA
            WHERE  [ID] = @ID";
            #endregion

            public DadosServico SelecionarPorIdServico(int id_servico)
            {
                return Db.Get(sqlSelecionarDadosServicoPorIdServico, ConverterEmEntidade, AdicionarParametro("ID", id_servico));

            }

            public void Inserir(DadosServico dadosServico)
            {
                Db.Update(sqlInserirDadosServico, ObterParametrosRegistro(dadosServico));
            }
            public void Editar(int id, DadosServico dadosServico)
            {
                dadosServico.Id = id;
                Db.Update(sqlEditarDadosServico, ObterParametrosRegistro(dadosServico));
            }

            protected Dictionary<string, object> ObterParametrosRegistro(DadosServico dadosServico)
            {
                var parametros = new Dictionary<string, object>
                {
                { "ID", dadosServico.Id },
                { "NOME", dadosServico.Nome },
                { "TAXA", dadosServico.Taxa }

                };

                return parametros;
            }
            protected  DadosServico ConverterEmEntidade(IDataReader reader)
            {
                var id = Convert.ToInt32(reader["ID"]);
                var nome = Convert.ToInt32(reader["NOME"]);
                var taxa = Convert.ToDouble(reader["TAXA"]);


                DadosServico dadosServico = new DadosServico(nome, taxa);
                {
                    dadosServico.Id = id;
                };

                return dadosServico;
            }

            
        }
    }
}