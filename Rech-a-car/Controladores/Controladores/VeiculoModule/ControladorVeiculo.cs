using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;

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
                    [ID_CATEGORIA],
                    [ANO],
                    [PLACA],
                    [CAPACIDADE],
                    [PORTAS],
                    [CHASSI],
                    [PORTA_MALAS],
                    [FOTO],
                    [AUTOMATICO],
                    [QUILOMETRAGEM],
                    [TIPO_COMBUSTIVEL]
                )
            VALUES
                (
                    @MODELO,       
                    @MARCA,             
                    @ID_CATEGORIA,
                    @ANO,
                    @PLACA,
                    @CAPACIDADE,
                    @PORTAS,
                    @CHASSI,
                    @PORTA_MALAS,
                    @FOTO,
                    @AUTOMATICO,
                    @QUILOMETRAGEM,
                    @TIPO_COMBUSTIVEL
                )";

        private const string sqlEditarVeiculo =
            @" UPDATE [TBVEICULO]
                SET 
                    [MODELO] = @MODELO,       
                    [MARCA] = @MARCA,             
                    [ID_CATEGORIA] = @ID_CATEGORIA,
                    [ANO] = @ANO,
                    [PLACA] = @PLACA,
                    [CAPACIDADE] = @CAPACIDADE,
                    [PORTAS] = @PORTAS,
                    [CHASSI] = @CHASSI,
                    [PORTA_MALAS] = @PORTA_MALAS,
                    [FOTO] = @FOTO,
                    [AUTOMATICO] = @AUTOMATICO,
                    [QUILOMETRAGEM] = @QUILOMETRAGEM,
                    [TIPO_COMBUSTIVEL] = @TIPO_COMBUSTIVEL
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

        public override Veiculo ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var modelo = Convert.ToString(reader["MODELO"]);
            var marca = Convert.ToString(reader["MARCA"]);
            var placa = Convert.ToString(reader["PLACA"]);
            var chassi = Convert.ToString(reader["CHASSI"]);
            var portas = Convert.ToInt32(reader["PORTAS"]);
            var ano = Convert.ToInt32(reader["ANO"]);
            var porta_malas = Convert.ToInt32(reader["PORTA_MALAS"]);
            var capacidade = Convert.ToInt32(reader["CAPACIDADE"]);
            var automatico = Convert.ToBoolean(reader["AUTOMATICO"]);
            var id_categoria = Convert.ToInt32(reader["ID_CATEGORIA"]);
            var tipoCombustivel = Convert.ToInt32(reader["TIPO_COMBUSTIVEL"]);
            var quilometragem = Convert.ToInt32(reader["QUILOMETRAGEM"]);

            var foto = RecuperarImagem((byte[])reader["FOTO"]);

            var categoria = new ControladorCategoria().GetById(id_categoria);

            Veiculo veiculo = new Veiculo(modelo, marca, ano, placa,quilometragem, capacidade, portas, chassi, porta_malas, foto, automatico, categoria, (TipoCombustivel)tipoCombustivel)
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
                { "ID_CATEGORIA", veiculo.Categoria.Id },
                { "QUILOMETRAGEM", veiculo.Quilometragem },
                { "TIPO_COMBUSTIVEL", veiculo.TipoDeCombustivel }
            };

            return parametros;
        }
    }
}
