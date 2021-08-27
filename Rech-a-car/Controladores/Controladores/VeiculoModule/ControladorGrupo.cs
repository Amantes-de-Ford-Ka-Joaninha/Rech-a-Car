using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores.VeiculoModule
{
    public class ControladorGrupo : ControladorEntidade<Grupo>
    {
        #region Queries
        private const string sqlSelecionarGrupoPorId =
            @"SELECT *
             FROM
                [TBGRUPO]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosGrupos =
            @"SELECT *
             FROM
                [TBGRUPO]";

        private const string sqlInserirGrupo =
            @"INSERT INTO [TBGRUPO]
                (
                    [QUILOMETRAGEM_FRANQUIA],
                    [PRECO_KM],
                    [PRECO_DIARIA],
                    [TIPO_CNH],
                    [PRECO_LIVRE],
                    [NOME]
                )
            VALUES
                (
                    @QUILOMETRAGEM_FRANQUIA
                    @PRECO_KM,
                    @PRECO_DIARIA,
                    @TIPO_CNH,
                    @PRECO_LIVRE,
                    @NOME,
                )";

        private const string sqlEditarGrupo =
                @" UPDATE [TBGRUPO]
                SET     
                    [QUILOMETRAGEM_FRANQUIA] = @QUILOMETRAGEM_FRANQUIA,             
                    [PRECO_KM] = @PRECO_KM,
                    [PRECO_DIARIA] = @PRECO_DIARIA,
                    [TIPO_CNH] = @TIPO_CNH,
                    [PRECO_LIVRE] = @PRECO_LIVRE,
                    [NOME] = @NOME,
                WHERE [ID] = @ID";

        private const string sqlExcluirGrupo =
                @" DELETE * FROM [TBGRUPO] WHERE [ID] = @ID";

        private const string sqlExisteGrupo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBGRUPO]
            WHERE 
                [ID] = @ID";

        #endregion

        public override string sqlSelecionarPorId => sqlSelecionarGrupoPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosGrupos;
        public override string sqlInserir => sqlInserirGrupo;
        public override string sqlEditar => sqlEditarGrupo;
        public override string sqlExcluir => sqlExcluirGrupo;
        public override string sqlExists => sqlExisteGrupo;

        protected override Dictionary<string, object> ObterParametrosRegistro(Grupo grupo)
        {
            var parametros = new Dictionary<string, object>
                {
                { "ID", grupo.Id },
                { "QUILOMETRAGEM_FRANQUIA", grupo.QuilometragemFranquia },
                { "PRECO_KM", grupo.PrecoKm },
                { "PRECO_DIARIA", grupo.PrecoDiaria },
                { "NOME", grupo.Nome },
                { "PRECO_LIVRE", grupo.PrecoLivre },
                { "TIPO_CNH", grupo.TipoDeCnh },
                };

            return parametros;
        }
        public override Grupo ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var franquia = Convert.ToInt32(reader["QUILOMETRAGEM_FRANQUIA"]);
            var precokm = Convert.ToDouble(reader["PRECO_KM"]);
            var diaria = Convert.ToDouble(reader["PRECO_DIARIA"]);
            var tipoCnh = Convert.ToInt32(reader["TIPO_CNH"]);
            var precoLivre = Convert.ToDouble(reader["PRECO_LIVRE"]);
            var nome = Convert.ToString(reader["NOME"]);

            return new Grupo(nome, diaria, precokm, franquia, precoLivre, (TipoCNH)tipoCnh)
            {
                Id = id
            };
        }
    }
}
