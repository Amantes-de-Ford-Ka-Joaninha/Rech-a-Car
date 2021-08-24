using Controladores.Shared;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
                    [PORTA_MALAS] = @PORTA_MALAS,
                    [FOTO] = @FOTO,
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

        public override void Inserir(Veiculo veiculo, int id_chave_estrangeira = 0)
        {
            base.Inserir(veiculo);
            veiculo.DadosVeiculo.Id = veiculo.Id;
            new ControladorDadosVeiculo().Inserir(veiculo.DadosVeiculo);
        }
        public override void Editar(int id, Veiculo veiculo)
        {
            base.Editar(id, veiculo);
            new ControladorDadosVeiculo().Editar(id, veiculo.DadosVeiculo);
        }
        public override Veiculo ConverterEmEntidade(IDataReader reader)
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
            var dadosVeiculo = new ControladorDadosVeiculo().GetByIdVeiculo(id);

            Veiculo veiculo = new Veiculo(modelo, marca, ano, placa, capacidade, portas, chassi, porta_malas, foto, automatico, categoria, dadosVeiculo)
            {
                Id = id
            };

            return veiculo;
        }
        protected override Dictionary<string, object> ObterParametrosRegistro(Veiculo veiculo)
        {
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
        private static byte[] SalvarImagem(Image foto)
        {
            using (var ms = new MemoryStream())
            {
                foto = new Bitmap(foto);
                foto.Save(ms, ImageFormat.Bmp);
                return ms.ToArray();
            }
        }
        private static Image RecuperarImagem(byte[] imageBytes)
        {
            using (var ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private class ControladorDadosVeiculo
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

            public DadosVeiculo GetByIdVeiculo(int id_veiculo)
            {
                return Db.Get(sqlSelecionarDadosVeiculoPorIdVeiculo, ConverterEmEntidade, AdicionarParametro("ID", id_veiculo));
            }
            public void Inserir(DadosVeiculo dadosVeiculo)
            {
                Db.Update(sqlInserirDadosVeiculo, ObterParametrosRegistro(dadosVeiculo));
            }
            public void Editar(int id, DadosVeiculo dadosVeiculo)
            {
                dadosVeiculo.Id = id;
                Db.Update(sqlEditarDadosVeiculo, ObterParametrosRegistro(dadosVeiculo));
            }
            public Dictionary<string, object> ObterParametrosRegistro(DadosVeiculo dadosVeiculo)
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
            public DadosVeiculo ConverterEmEntidade(IDataReader reader)
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
}
