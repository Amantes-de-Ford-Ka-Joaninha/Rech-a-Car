using System.Collections.Generic;
using System.Data;

namespace Controladores.Shared
{
    public abstract class ControladorDependencia<T> where T : class
    {
        public abstract void Inserir();
        public abstract T ConverterEmEntidade(IDataReader reader);
        public abstract Dictionary<string, object> ObtemParametrosRegistro(T registro);
    }
}
