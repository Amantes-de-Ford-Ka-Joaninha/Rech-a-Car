using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Controladores.VeiculoModule
{
    public class ControladorDadosVeiculo
    {
        #region Queries
        private const string sqlSelecionarDadosVeiculoPorIdVeiculo =
            @"SELECT *
             FROM
                [TBDADOSVEICULO]
             WHERE 
                [ID] = @ID";

        private const string sqlInserirDadosVeiculo =
            @"INSERT INTO [TBDADOSVEICULO]
                (
                    [ID],
                    [QUILOMETRAGEM],
                    [PRECO_KM],
                    [DIARIA]
                )
            VALUES
                (
                    @ID,
                    @QUILOMETRAGEM,
                    @PRECO_KM,
                    @DIARIA
                )";

        private const string sqlEditarDadosVeiculo =
                @" UPDATE [TBDADOSVEICULO]
                SET     
                    [QUILOMETRAGEM] = @QUILOMETRAGEM,             
                    [PRECO_KM] = @PRECO_KM,
                    [DIARIA] = @DIARIA
                    WHERE [ID] = @ID";

        #endregion
        public static DadosVeiculo SelecionarPorIdVeiculo(int id_veiculo)
        {
            return Db.Get(sqlSelecionarDadosVeiculoPorIdVeiculo, ConverterEmEntidade, ControladorEntidade<DadosVeiculo>.AdicionarParametro("ID", id_veiculo));
        }
        public static void Inserir(DadosVeiculo dadosVeiculo)
        {
            Db.Update(sqlInserirDadosVeiculo, ObterParametrosRegistro(dadosVeiculo));
        }
        public static void Editar(DadosVeiculo dadosVeiculo)
        {
            Db.Update(sqlEditarDadosVeiculo, ObterParametrosRegistro(dadosVeiculo));
        }
        private static Dictionary<string, object> ObterParametrosRegistro(DadosVeiculo dadosVeiculo)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", dadosVeiculo.Id },
                { "QUILOMETRAGEM", dadosVeiculo.Quilometragem },
                { "PRECO_KM", dadosVeiculo.PrecoKm },
                { "DIARIA", dadosVeiculo.Diaria },
            };

            return parametros;
        }
        private static DadosVeiculo ConverterEmEntidade(DbDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var quilometragem = Convert.ToInt32(reader["QUILOMETRAGEM"]);
            var precokm = Convert.ToDouble(reader["PRECO_KM"]);
            var diaria = Convert.ToDouble(reader["DIARIA"]);

            DadosVeiculo dadosVeiculo = new DadosVeiculo(quilometragem, diaria, precokm);
            {
                dadosVeiculo.Id = id;
            };

            return dadosVeiculo;
        }
    }
}
