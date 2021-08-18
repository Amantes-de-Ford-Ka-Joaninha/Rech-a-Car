using Controladores.Shared;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.VeiculoModule
{
    public class ControladorDadosVeiculo : Controlador<DadosVeiculo>
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
        public DadosVeiculo SelecionarPorIdVeiculo(int id_veiculo)
        {
            return Db.Get(sqlSelecionarDadosVeiculoPorIdVeiculo, ConverterEmEntidade, AdicionarParametro("ID", id_veiculo));
        }
        public override void Inserir(DadosVeiculo dadosVeiculo)
        {
            Db.Update(sqlInserirDadosVeiculo, ObterParametrosRegistro(dadosVeiculo));
        }
        public override void Editar(int id,DadosVeiculo dadosVeiculo)
        {
            Db.Update(sqlEditarDadosVeiculo, ObterParametrosRegistro(dadosVeiculo));
        }
        protected override Dictionary<string, object> ObterParametrosRegistro(DadosVeiculo dadosVeiculo)
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
        public override DadosVeiculo ConverterEmEntidade(IDataReader reader)
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

        public override DadosVeiculo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<DadosVeiculo> ObterRegistros()
        {
            throw new NotImplementedException();
        }

        public override void Excluir(int id)
        {
            throw new NotImplementedException();
        }
    }
}