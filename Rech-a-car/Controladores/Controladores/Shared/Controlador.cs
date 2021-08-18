using Dominio.Shared;
using System.Collections.Generic;
using System.Data;

namespace Controladores.Shared
{
    public abstract class Controlador<T> where T : IControlavel
    {
        public List<T> Registros => ObterRegistros();
        public abstract void Inserir(T entidade);
        public abstract void Editar(int id,T entidade);
        public abstract void Excluir(int id);

        public abstract T ConverterEmEntidade(IDataReader reader);
        protected abstract Dictionary<string, object> ObterParametrosRegistro(T registro);
        public static Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }
        abstract public T GetById(int id);
        abstract public List<T> ObterRegistros();
    }
}