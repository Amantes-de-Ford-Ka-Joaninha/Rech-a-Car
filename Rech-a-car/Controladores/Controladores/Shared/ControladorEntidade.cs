using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.Shared
{
    public abstract class ControladorEntidade<T> : Controlador<T> where T : IControlavel
    {
        public abstract string sqlSelecionarPorId { get; }
        public abstract string sqlSelecionarTodos { get; }
        public abstract string sqlInserir { get; }
        public abstract string sqlEditar { get; }
        public abstract string sqlExcluir { get; }
        public abstract string sqlExists { get; }
        public override T GetById(int id, Type tipo = null)
        {
            return Db.Get(sqlSelecionarPorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }
        public override void Inserir(T entidade, int id_chave_estrangeira = 0)
        {
            entidade.Id = Db.Insert(sqlInserir, ObterParametrosRegistro(entidade));
        }
        public override void Editar(int id, T entidade)
        {
            entidade.Id = id;
            Db.Update(sqlEditar, ObterParametrosRegistro(entidade));
        }
        protected override List<T> ObterRegistros()
        {
            return Db.GetAll(sqlSelecionarTodos, ConverterEmEntidade);
        }
        public override void Excluir(int id, Type tipo = null)
        {
            Db.Delete(sqlExcluir, AdicionarParametro("ID", id));
        }
        public bool Exists(int id)
        {
            return Db.Exists(sqlExists, AdicionarParametro("ID", id));
        }
        public abstract T ConverterEmEntidade(IDataReader reader);
        protected abstract Dictionary<string, object> ObterParametrosRegistro(T entidade);
    }
}