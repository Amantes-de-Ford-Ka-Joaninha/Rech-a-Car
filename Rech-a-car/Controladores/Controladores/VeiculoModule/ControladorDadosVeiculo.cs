using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controladores;
using System.Data.Common;

namespace Controladores.VeiculoModule
{
    public class ControladorDadosVeiculo
    {
        private const string sqlSelecionarDadosVeiculoPorIdVeiculo =
            @"SELECT *
             FROM
                [TBDADOSVEICULO]
             WHERE 
                [ID_VEICULO] = @ID_VEICULO";
        public static DadosVeiculo SelecionarPorIdVeiculo(int id_veiculo)
        {
            return Db.Get(sqlSelecionarDadosVeiculoPorIdVeiculo, ConverterEmEntidade, ControladorEntidade<DadosVeiculo>.AdicionarParametro("ID_VEICULO", id_veiculo));
        }

        private static DadosVeiculo ConverterEmEntidade(DbDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
