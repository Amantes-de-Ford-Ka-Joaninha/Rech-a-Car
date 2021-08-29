using Controladores.PessoaModule;
using Controladores.ServicoModule;
using Controladores.Shared;
using Controladores.VeiculoModule;
using Dominio.AluguelModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.AluguelModule
{
    public class ControladorAluguel : ControladorEntidade<Aluguel>
    {
        #region Queries
        private const string sqlInserirAluguel =
    @"INSERT INTO [TBALUGUEL]
                (
                    [ID_CLIENTE],       
                    [ID_CONDUTOR],             
                    [ID_VEICULO],
                    [TIPO_ALUGUEL],
                )
            VALUES
                (
                    @ID_CLIENTE,       
                    @ID_CONDUTOR,             
                    @ID_VEICULO,
                    @TIPO_ALUGUEL,
                )";

        private const string sqlEditarAluguel =
            @" UPDATE [TBALUGUEL]
                SET 
                    [ID_CLIENTE] = @ID_CLIENTE,       
                    [ID_CONDUTOR] = @ID_CONDUTOR,             
                    [ID_VEICULO] = @ID_VEICULO,
                    [TIPO_ALUGUEL] = @TIPO_ALUGUEL,
                WHERE [ID] = @ID";

        private const string sqlExcluirAluguel =
            @"DELETE FROM [TBALUGUEL] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarAluguelPorId =
            @"SELECT *
             FROM
                [TBALUGUEL]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosAlugueis =
            @"SELECT *
             FROM
                [TBALUGUEL]";

        private const string sqlExisteAluguel =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBALUGUEL]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string sqlSelecionarPorId => sqlSelecionarAluguelPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosAlugueis;
        public override string sqlInserir => sqlInserirAluguel;
        public override string sqlEditar => sqlEditarAluguel;
        public override string sqlExcluir => sqlExcluirAluguel;
        public override string sqlExists => sqlExisteAluguel;
        public override Aluguel ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var id_veiculo = Convert.ToInt32(reader["ID_VEICULO"]);
            var id_cliente = Convert.ToInt32(reader["ID_CLIENTE"]);
            var id_condutor = Convert.ToInt32(reader["ID_CONDUTOR"]);
            var id_funcionario = Convert.ToInt32(reader["ID_FUNCIONARIO"]);

            var dataAluguel = Convert.ToDateTime(reader["DATA_ALUGUEL"]);
            var tipoPlano = Convert.ToInt32(reader["TIPO_PLANO"]);

            var funcionario = new ControladorFuncionario().GetById(id_funcionario);
            var veiculo = new ControladorVeiculo().GetById(id_veiculo);

            Condutor condutor = GetCondutor(id_condutor, id_cliente);

            var cliente = new ControladorCliente().GetById(id_cliente, GetTipoCliente(condutor));

            var servicos = new ControladorServico().GetServicosAlugados(id);

            return new Aluguel(veiculo, servicos, (Plano)tipoPlano, dataAluguel, cliente, funcionario, condutor)
            {
                Id = id
            };
        }

        private Type GetTipoCliente(Condutor condutor)
        {
            if (condutor == null)
                return typeof(ClientePF);
            else
                return typeof(ClientePJ);
        }

        private Condutor GetCondutor(int id_condutor, int id_cliente)
        {
            if (id_condutor == id_cliente)
                return null;
            else
                return null;//new ControladorMotorista().GetMotoristaEmpresa(id_cliente, id_condutor);
        }
        protected override Dictionary<string, object> ObterParametrosRegistro(Aluguel aluguel)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", aluguel.Id },
                { "ID_CLIENTE", aluguel.Cliente.Id },
                { "ID_CONDUTOR", aluguel.Condutor.Id },
                { "ID_VEICULO", aluguel.Veiculo.Id },
                { "TIPO_ALUGUEL", aluguel.TipoPlano },
            };
            return parametros;
        }
    }
}
