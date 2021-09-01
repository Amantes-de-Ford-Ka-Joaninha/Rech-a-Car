using Controladores.Shared;
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
                [TAXA]
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

        private const string sqlSelecionarServicosAlugados =
            @"SELECT *
            FROM 
               [TBServico]
            WHERE
                [ID_ALUGUEL]=@ID_ALUGUEL";

        private const string sqlExisteServico =
           @"SELECT 
                COUNT(*) 
            FROM 
                [TBServico]
            WHERE 
                [ID] = @ID";

        private const string sqlDesalugarServicosAlugados =
        @"UPDATE [TBServico]
                    SET
                        [ID_ALUGUEL] = @DB_NULL         
                    WHERE
                        [ID_ALUGUEL] = @ID_ALUGUEL";

        private const string sqlEditarAluguelServico =
                @"UPDATE [TBServico]
                        SET
                          [ID_ALUGUEL] = @ID_ALUGUEL         
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

            return new Servico(nome, taxa)
            {
                Id = id
            };
        }

        protected override Dictionary<string, object> ObterParametrosRegistro(Servico servico)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", servico.Id },
                { "NOME", servico.Nome },
                { "TAXA", servico.Taxa },
            };
            return parametros;
        }

        public List<Servico> GetServicosAlugados(int idAluguel)
        {
            return Db.GetAll(sqlSelecionarServicosAlugados, ConverterEmEntidade, AdicionarParametro("ID_ALUGUEL", idAluguel));
        }

        public void AlugarServicos(int idAluguel, List<Servico> servicos)
        {
            foreach (var servico in servicos)
                Db.Update(sqlEditarAluguelServico, AdicionarParametro("ID_ALUGUEL", idAluguel, AdicionarParametro("ID", servico.Id)));
        }

        public List<Servico> ServicosDisponiveis()
        {
            return Registros;
        }

        public void DesalugarServicosAlugados(int idAluguel)
        {
            Db.Update(sqlDesalugarServicosAlugados, AdicionarParametro("DB_NULL", DBNull.Value, AdicionarParametro("ID_ALUGUEL", idAluguel)));
        }
    }
}