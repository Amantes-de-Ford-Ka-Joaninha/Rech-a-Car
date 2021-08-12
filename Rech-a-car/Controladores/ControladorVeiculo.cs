using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using Dominio.VeiculoModule;
using System.IO;

namespace Controladores
{
    class ControladorVeiculo : ControladorBase<Veiculo>
    {
        #region Queries
        private const string sqlInserirVeiculo =
            @"INSERT INTO [TBVEICULO]
                (
                    [MODELO],       
                    [MARCA],             
                    [TIPO],                    
                    [QUILOMETRAGEM],
                    [ANO],
                    [PLACA],
                    [CAPACIDADE],
                    [PORTAS],
                    [CHASSI],
                    [PORTA_MALAS],
                    [FOTO],
                    [AUTOMATICO]
                )
            VALUES
                (
                    @MODELO,       
                    @MARCA,             
                    @TIPO,                    
                    @QUILOMETRAGEM,
                    @ANO,
                    @PLACA,
                    @CAPACIDADE,
                    @PORTAS,
                    @CHASSI,
                    @PORTA_MALAS,
                    @FOTO,
                    @AUTOMATICO
                )";

        private const string sqlEditarVeiculo =
            @" UPDATE [TBVEICULO]
                SET 
                    [MODELO] = @MODELO,       
                    [MARCA] = @MARCA,             
                    [TIPO] = @TIPO,                    
                    [QUILOMETRAGEM] = @QUILOMETRAGEM,
                    [ANO] = @ANO,
                    [PLACA] = @PLACA,
                    [CAPACIDADE] = @CAPACIDADE,
                    [PORTAS] = @PORTAS,
                    [CHASSI] = @CHASSI,
                    [PORTA_MALAS] @PORTA_MALAS,
                    [FOTO] = @FOTOS,
                    [AUTOMATICO] = @AUTOMATICO
                WHERE [ID] = @ID";

        private const string sqlExcluirVeiculo =
            @"DELETE FROM [TBVEICULO] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarVeiculoPorId =
            @"SELECT *
             FROM
                [TBVEICULO]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosVeiculos =
            @"SELECT *
             FROM
                [TBVEICULO]";

        private const string sqlExisteVeiculo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBVEICULO]
            WHERE 
                [ID] = @ID";
        #endregion

        public override string sqlSelecionarPorId => sqlSelecionarVeiculoPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosVeiculos;
        public override string sqlInserir => sqlInserirVeiculo;
        public override string sqlEditar => sqlEditarVeiculo;
        public override string sqlExcluir => sqlExcluirVeiculo;
        public override string sqlExists => sqlExisteVeiculo;

        protected override Veiculo ConverterEmRegistro(IDataReader reader)
        {
            var modelo = Convert.ToString(reader["MODELO"]);
            var marca = Convert.ToString(reader["MARCA"]);
            var quilometragem = Convert.ToInt32(reader["QUILOMETRAGEM"]);
            var ano = Convert.ToInt32(reader["ANO"]);
            var placa = Convert.ToString(reader["PLACA"]);
            var capacidade = Convert.ToInt32(reader["CAPACIDADE"]);
            var portas = Convert.ToInt32(reader["PORTAS"]);
            var chassi = Convert.ToString(reader["CHASSI"]);
            var porta_malas = Convert.ToInt32(reader["PORTA_MALAS"]);
            var automatico = Convert.ToBoolean(reader["AUTOMATICO"]);
            var foto = RecuperarImagem((byte[]) reader["FOTO"]);

            Veiculo veiculo = new Veiculo(modelo, marca, quilometragem, ano, placa, capacidade, portas, chassi, porta_malas, foto, automatico)
            {
                Id = Convert.ToInt32(reader["ID"])
            };

            return veiculo;
        }
        protected override Dictionary<string, object> ObtemParametrosRegistro(Veiculo veiculo)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", veiculo.Id },
                { "MODELO", veiculo.Modelo },
                { "MARCA", veiculo.Marca },
                { "QUILOMETRAGEM", veiculo.Quilometragem },
                { "ANO", veiculo.Ano },
                { "PLACA", veiculo.Placa },
                { "CAPACIDADE", veiculo.Capacidade },
                { "PORTAS", veiculo.Portas },
                { "CHASSI", veiculo.Chassi },
                { "PORTA_MALAS", veiculo.Porta_malas },
                { "FOTO", veiculo.Foto },
                { "AUTOMATICO", veiculo.Automatico }
            };

            return parametros;
        }

        private static Image RecuperarImagem(byte[] imageBytes)
        {
            using (var ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
