using Controladores.Shared;
using System;

namespace Controladores
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
                    [DATA_ENVIADA] = @DATA_ENVIADO
                WHERE [ID] = @ID";

        #endregion

        public void InserirParaEnvio(int id_aluguel, string pathAluguel)
        {
            Db.Insert(sqlInserirEmail, Db.AdicionarParametro("ID_ALUGUEL", id_aluguel, Db.AdicionarParametro("PATH_EMAIL", pathAluguel)));
        }
        public void AlterarEnviado(int id)
        {
            Db.Update(sqlAlterarEmailEnviado, Db.AdicionarParametro("ID", id, Db.AdicionarParametro("DATA_ENVIADO", DateTime.Now)));
        }
    }
}
