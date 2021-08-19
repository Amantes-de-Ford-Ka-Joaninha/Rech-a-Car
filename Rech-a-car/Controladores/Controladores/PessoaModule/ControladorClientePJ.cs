﻿using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.PessoaModule
{
    public class ControladorClientePJ : ControladorEntidade<ClientePJ>
    {
        #region Queries
        private const string sqlInserirClientePJ =
    @"INSERT INTO [TBCLIENTEPJ]
                (
                    [NOME],       
                    [TELEFONE],             
                    [ENDERECO],
                    [DOCUMENTO]
                )
            VALUES
                (
                    @NOME,       
                    @TELEFONE,             
                    @ENDERECO,
                    @DOCUMENTO
                )";

        private const string sqlEditarClientePJ =
            @" UPDATE [TBCLIENTEPJ]
                SET 
                    [NOME] = @NOME,       
                    [TELEFONE] = @TELEFONE,             
                    [ENDERECO] = @ENDERECO,
                    [DOCUMENTO] = @DOCUMENTO
                WHERE [ID] = @ID";

        private const string sqlExcluirClientePJ =
            @"DELETE FROM [TBCLIENTEPJ] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarClientePJPorId =
            @"SELECT *
             FROM
                [TBCLIENTEPJ]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosClientePJ =
            @"SELECT *
             FROM
                [TBCLIENTEPJ]";

        private const string sqlExisteClientePJ =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTEPJ]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string sqlSelecionarPorId => sqlSelecionarClientePJPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosClientePJ;
        public override string sqlInserir => sqlInserirClientePJ;
        public override string sqlEditar => sqlEditarClientePJ;
        public override string sqlExcluir => sqlExcluirClientePJ;
        public override string sqlExists => sqlExisteClientePJ;

        public override ClientePJ ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var documento = Convert.ToString(reader["DOCUMENTO"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);

            return new ClientePJ(nome, telefone, documento, endereco)
            {
                Id = id,
                Motoristas = new ControladorMotorista().SelecionarCondutoresPJ(id)
        };
        }
        protected override Dictionary<string, object> ObterParametrosRegistro(ClientePJ cliente)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", cliente.Id },
                { "NOME", cliente.Nome },
                { "ENDERECO", cliente.Endereco },
                { "TELEFONE", cliente.Telefone },
                { "DOCUMENTO", cliente.Documento },
            };

            return parametros;
        }
        public void AdicionarMotorista(int idEmpresa,MotoristaEmpresa motorista)
        {
            new ControladorMotorista().Inserir(motorista,idEmpresa);
        }
        protected class ControladorMotorista
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


            #endregion

            //public MotoristaEmpresa GetById(int id)
            //{
            //    return Db.Get(sqlSelecionarMotoristaPorId, ConverterEmEntidade, AdicionarParametro("ID", id));
            //}
            public List<MotoristaEmpresa> SelecionarCondutoresPJ(int id_empresa)
            {
                return Db.GetAll(sqlSelecionarTodosMotoristasEmpresa, ConverterEmEntidade, AdicionarParametro("ID_EMPRESA", id_empresa));
            }
            public void Inserir(MotoristaEmpresa motorista,int idEmpresa)
            {
                new ControladorCNH().Inserir(motorista.Cnh);
                Db.Update(sqlInserirMotorista,ObterParametrosRegistro(motorista),AdicionarParametro("ID_EMPRESA",idEmpresa));
            }
            public void Editar(int id, MotoristaEmpresa motorista)
            {
                new ControladorCNH().Editar(motorista.Cnh.Id, motorista.Cnh);
                motorista.Id = id;
                Db.Update(sqlEditarMotorista, ObterParametrosRegistro(motorista));
            }
            public Dictionary<string, object> ObterParametrosRegistro(MotoristaEmpresa motorista)
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
            public MotoristaEmpresa ConverterEmEntidade(IDataReader reader)
            {
                var id = Convert.ToInt32(reader["ID"]);
                var nome = Convert.ToString(reader["NOME"]);
                var telefone = Convert.ToString(reader["TELEFONE"]);
                var endereco = Convert.ToString(reader["ENDERECO"]);
                var documento = Convert.ToString(reader["DOCUMENTO"]);

                var id_cnh = Convert.ToInt32(reader["ID_CNH"]);
                var cnh = new ControladorCNH().GetByIdCondutor(id_cnh);

                MotoristaEmpresa dadosVeiculo = new MotoristaEmpresa(nome, telefone, endereco, documento, cnh);
                {
                    dadosVeiculo.Id = id;
                };

                return dadosVeiculo;
            }
        }
    }
}