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
                    [ID],
                    [QUILOMETRAGEM_FRANQUIA],
                    [PRECO_KM],
                    [PRECO_DIARIA],
                    [TIPO_CNH],
                    [PRECO_LIVRE],
                    [PRECO_KM],
                    [NOME]
                )
            VALUES
                (
                    @ID,
                    @QUILOMETRAGEM,
                    @PRECO_KM,
                    @DIARIA
                )";

        private const string sqlEditarGrupo =
                @" UPDATE [TBGRUPO]
                SET     
                    [QUILOMETRAGEM] = @QUILOMETRAGEM,             
                    [PRECO_KM] = @PRECO_KM,
                    [DIARIA] = @DIARIA
                    WHERE [ID] = @ID";

        private const string sqlExcluirGrupo =
                @" DELETE * FROM [TBGRUPO] WHERE [ID] = @ID";

        #endregion

        public override string sqlSelecionarPorId => throw new NotImplementedException();
        public override string sqlSelecionarTodos => throw new NotImplementedException();
        public override string sqlInserir => throw new NotImplementedException();
        public override string sqlEditar => throw new NotImplementedException();
        public override string sqlExcluir => throw new NotImplementedException();
        public override string sqlExists => throw new NotImplementedException();

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
