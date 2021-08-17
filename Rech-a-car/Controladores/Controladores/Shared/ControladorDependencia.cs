using System.Collections.Generic;
using System.Data;

namespace Controladores.Shared
{
    public abstract class ControladorDependencia<T> where T : class
    {
        public abstract void Inserir(T entidade);
        protected abstract T ConverterEmEntidade(IDataReader reader);
        protected abstract Dictionary<string, object> ObtemParametrosRegistro(T registro);
        public static Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }
    }
}
