using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;

namespace Controladores.VeiculoModule
{
    public class ControladorVeiculo : ControladorEntidade<Veiculo>
    {
        #region Queries
        private const string sqlInserirVeiculo =
            @"INSERT INTO [TBVEICULO]
                (
                    [MODELO],       
                    [MARCA],             
                    [CATEGORIA],
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
                    @CATEGORIA,
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
                    [CATEGORIA] = @CATEGORIA,
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

        protected override Veiculo ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var modelo = Convert.ToString(reader["MODELO"]);
            var marca = Convert.ToString(reader["MARCA"]);
            var categoria = Convert.ToString(reader["CATEGORIA"]);
            var placa = Convert.ToString(reader["PLACA"]);
            var chassi = Convert.ToString(reader["CHASSI"]);
            var portas = Convert.ToInt32(reader["PORTAS"]);
            var ano = Convert.ToInt32(reader["ANO"]);
            var porta_malas = Convert.ToInt32(reader["PORTA_MALAS"]);
            var capacidade = Convert.ToInt32(reader["CAPACIDADE"]);
            var automatico = Convert.ToBoolean(reader["AUTOMATICO"]);

            var foto = RecuperarImagem((byte[])reader["FOTO"]);
            var dadosVeiculo = ControladorDadosVeiculo.SelecionarPorIdVeiculo(id);
            Veiculo veiculo = new Veiculo(modelo, marca, ano, placa, capacidade, portas, chassi, porta_malas, foto, automatico, categoria, dadosVeiculo)
            {
                Id = id
            };

            return veiculo;
        }
        protected override Dictionary<string, object> ObtemParametrosRegistro(Veiculo veiculo)
        {
            ControladorDadosVeiculo.Inserir(veiculo.DadosVeiculo);

            var parametros = new Dictionary<string, object>
            {
                { "ID", veiculo.Id },
                { "MODELO", veiculo.Modelo },
                { "MARCA", veiculo.Marca },
                { "ANO", veiculo.Ano },
                { "PLACA", veiculo.Placa },
                { "CAPACIDADE", veiculo.Capacidade },
                { "PORTAS", veiculo.Portas },
                { "CHASSI", veiculo.Chassi },
                { "PORTA_MALAS", veiculo.Porta_malas },
                { "FOTO", SalvarImagem(veiculo.Foto)  },
                { "AUTOMATICO", veiculo.Automatico },
                { "CATEGORIA", veiculo.Categoria }
            };

            return parametros;
        }
        private byte[] SalvarImagem(Image foto)
        {
            MemoryStream imageStream = new MemoryStream();
            foto.Save(imageStream, foto.RawFormat);
            return imageStream.ToArray();
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
