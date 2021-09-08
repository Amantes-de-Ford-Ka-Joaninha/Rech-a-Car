using Aspose.Pdf;
using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace EmailAluguelPDF
{
    public class ControladorEmail
    {
        #region Queries
        private const string sqlInserirEmail = 
            @"INSERT INTO [TBEMAIL]
              (
                [ID_ALUGUEL],       
                [PATH_EMAIL]            
              )
                VALUES
              (
                @ID_ALUGUEL,
                @PATH_EMAIL
              )";

        private const string sqlAlterarEmailEnviado =
            @"UPDATE [TBEMAIL]
                SET 
                    [DATA_ENVIADO] = @DATA_ENVIADO
                WHERE [ID] = @ID";

        private const string sqlGetProxEnvio =
            @"SELECT TOP 1 *
                FROM [TBEMAIL] 
			  WHERE [DATA_ENVIADO] IS NULL
                ORDER BY [DATA_ENVIADO] DESC";

        #endregion

        public void InserirParaEnvio(int id_aluguel, string pathAluguel)
        {
            Db.Insert(sqlInserirEmail, Db.AdicionarParametro("ID_ALUGUEL", id_aluguel, Db.AdicionarParametro("PATH_EMAIL", pathAluguel)));
        }
        public void AlterarEnviado(int id)
        {
            Db.Update(sqlAlterarEmailEnviado, Db.AdicionarParametro("ID", id, Db.AdicionarParametro("DATA_ENVIADO", DateTime.Now)));
        }
        public EnvioEmail GetProxEnvio()
        {
            return Db.Get(sqlGetProxEnvio, ConverterEmEntidade);
        }
        private EnvioEmail ConverterEmEntidade(IDataReader reader)
        {
            var aluguel = new ControladorAluguel().GetById(Convert.ToInt32(reader["ID_ALUGUEL"]));
            var pathPdf = Convert.ToString(reader["PATH_EMAIL"]);
            var id = Convert.ToInt32(reader["ID"]);

            return new EnvioEmail(aluguel, pathPdf) { Id = id};
        }
    }
}
