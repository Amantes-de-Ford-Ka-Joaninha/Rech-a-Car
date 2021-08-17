using Dominio;
using System.Collections.Generic;
using System.Data;

namespace Controladores.Shared
{
    abstract public class ControladorEntidade<T> : ControladorDependencia<T> where T : Entidade
    {
        public List<T> Registros => ObterRegistros();
        public abstract string sqlSelecionarPorId { get; }
        public abstract string sqlSelecionarTodos { get; }
        public abstract string sqlInserir { get; }
        public abstract string sqlEditar { get; }
        public abstract string sqlExcluir { get; }
        public abstract string sqlExists { get; }
        public T GetById(int id)
        {
            return Db.Get(sqlSelecionarPorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }
        public List<T> ObterRegistros()
        {
            return Db.GetAll(sqlSelecionarTodos, ConverterEmEntidade);
        }
        public override void Inserir(T registro)
        {
            registro.Id = Db.Insert(sqlInserir, ObtemParametrosRegistro(registro));
        }
        public virtual void Editar(int id, T registro)
        {
            registro.Id = id;
            Db.Update(sqlEditar, ObtemParametrosRegistro(registro));
        }
        public void Excluir(int id)
        {
            Db.Delete(sqlExcluir, AdicionarParametro("ID", id));
        }
        public bool Exists(int id)
        {
            return Db.Exists(sqlExists, AdicionarParametro("ID", id));
        }
    }
}
