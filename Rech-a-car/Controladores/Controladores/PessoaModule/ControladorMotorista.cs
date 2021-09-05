using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores.PessoaModule
{
    public class ControladorMotorista : ControladorEntidade<MotoristaEmpresa>
    {
        #region Queries
        private const string sqlSelecionarMotoristaPorId =
            @"SELECT *
             FROM
                [TBMOTORISTA]
             WHERE 
                [ID] = @ID";
        private const string sqlSelecionarTodosMotoristasEmpresa =
            @"SELECT *
             FROM
                [TBMOTORISTA]
             WHERE 
                [ID_EMPRESA] = @ID_EMPRESA";

        private const string sqlInserirMotorista =
            @"INSERT INTO [TBMOTORISTA]
                (
                    [NOME],
                    [TELEFONE],
                    [ENDERECO],
                    [DOCUMENTO],
                    [ID_EMPRESA],
                    [ID_CNH]
                )
            VALUES
                (
                    @NOME,
                    @TELEFONE,
                    @ENDERECO,
                    @DOCUMENTO,
                    @ID_EMPRESA,
                    @ID_CNH
                )";

        private const string sqlEditarMotorista =
                @"UPDATE [TBMOTORISTA]
                    SET     
                    [NOME] = @NOME,             
                    [TELEFONE] = @TELEFONE,
                    [ENDERECO] = @ENDERECO,
                    [DOCUMENTO] = @DOCUMENTO,
                    [ID_CNH] = @ID_CNH
                    WHERE [ID] = @ID";

        private const string sqlExcluirMotorista =
            @"DELETE FROM [TBMOTORISTA] 
                            WHERE [ID] = @ID";

        private const string sqlExisteMotorista =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBMOTORISTA]
            WHERE 
                [ID] = @ID";

        private const string sqlSelecionarMotoristasEmpresa =
            @"SELECT *
             FROM
                [TBMOTORISTA]
             WHERE 
                [ID_EMPRESA] = @ID_EMPRESA
            AND 
                [ID] = @ID";
        #endregion

        public override string sqlSelecionarPorId => sqlSelecionarMotoristaPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosMotoristasEmpresa;
        public override string sqlInserir => sqlInserirMotorista;
        public override string sqlEditar => sqlEditarMotorista;
        public override string sqlExcluir => sqlExcluirMotorista;
        public override string sqlExists => sqlExisteMotorista;

        public List<MotoristaEmpresa> SelecionarCondutoresPJ(int id_empresa)
        {
            return Db.GetAll(sqlSelecionarTodosMotoristasEmpresa, ConverterEmEntidade, AdicionarParametro("ID_EMPRESA", id_empresa));
        }
        public override void Inserir(MotoristaEmpresa motorista)
        {
            new ControladorCNH().Inserir(motorista.Cnh);
            motorista.Id = Db.Insert(sqlInserirMotorista, AdicionarParametro("ID_EMPRESA", motorista.Empresa.Id, ObterParametrosRegistro(motorista)));
        }
        public override void Editar(int id, MotoristaEmpresa motorista)
        {
            new ControladorCNH().Editar(motorista.Cnh.Id, motorista.Cnh);
            motorista.Id = id;
            Db.Update(sqlEditarMotorista, ObterParametrosRegistro(motorista));
        }
        public MotoristaEmpresa GetMotoristaEmpresa(int id_cliente, int id_condutor)
        {
            return Db.Get(sqlSelecionarMotoristasEmpresa, ConverterEmEntidade, AdicionarParametro("ID", id_condutor, AdicionarParametro("ID_EMPRESA", id_cliente)));
        }
        protected override Dictionary<string, object> ObterParametrosRegistro(MotoristaEmpresa motorista)
        {
            var parametros = new Dictionary<string, object>
                {
                { "ID", motorista.Id },
                { "NOME", motorista.Nome },
                { "TELEFONE", motorista.Telefone },
                { "ENDERECO", motorista.Endereco },
                { "DOCUMENTO", motorista.Documento },
                { "ID_CNH", motorista.Cnh.Id },
                };

            return parametros;
        }
        public override MotoristaEmpresa ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);
            var documento = Convert.ToString(reader["DOCUMENTO"]);

            var id_cnh = Convert.ToInt32(reader["ID_CNH"]);
            var cnh = new ControladorCNH().GetByIdCondutor(id_cnh);

            var id_empresa = Convert.ToInt32(reader["ID_EMPRESA"]);
            var empresa = new ControladorClientePJ().GetById(id_empresa);

            MotoristaEmpresa dadosVeiculo = new MotoristaEmpresa(nome, telefone, endereco, documento, cnh, empresa);
            {
                dadosVeiculo.Id = id;
            };

            return dadosVeiculo;
        }
    }
}
