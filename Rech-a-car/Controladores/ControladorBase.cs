using Dominio;
using System.Collections.Generic;
using System.Data;

namespace Controladores
{
    abstract public class ControladorBase<T> where T : Entidade
    {
        public List<T> Registros => ObterRegistros();
        public abstract string sqlSelecionarPorId { get; }
        public abstract string sqlSelecionarTodos { get; }
        public abstract string sqlInserir { get; }
        public abstract string sqlEditar { get; }
        public abstract string sqlExcluir { get; }
        public T GetById(int id)
        {
            return Db.Get(sqlSelecionarPorId, ConverterEmRegistro, AdicionarParametro("ID", id));
        }
        public List<T> ObterRegistros()
        {
            return Db.GetAll(sqlSelecionarTodos, ConverterEmRegistro);
        }
        public void Inserir(T registro)
        {
            registro.Id = Db.Insert(sqlInserir, ObtemParametrosRegistro(registro));
        }
        public void Editar(int id, T registro)
        {
            registro.Id = id;
            Db.Update(sqlEditar, ObtemParametrosRegistro(registro));
        }
        public void Excluir(int id)
        {
            Db.Delete(sqlExcluir, AdicionarParametro("ID", id));
        }

        protected abstract T ConverterEmRegistro(IDataReader reader);
        protected abstract Dictionary<string, object> ObtemParametrosRegistro(T registro);
        protected static Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }
    }
}
