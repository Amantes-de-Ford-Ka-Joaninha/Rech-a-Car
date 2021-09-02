using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controladores.Shared
{
    public abstract class Controlador<T> where T : IControlavel
    {
        public List<T> Registros => ObterRegistros();
        public abstract void Inserir(T entidade, int id_chave_estrangeira = 0);
        public abstract void Editar(int id, T entidade, int id_chave_estrangeira = 0);
        public abstract void Excluir(int id, Type tipo = null);
        public abstract T GetById(int id, Type tipo = null);
        protected abstract List<T> ObterRegistros();
        public static Dictionary<string, object> AdicionarParametro(string campo, object valor, Dictionary<string, object> parametros = null)
        {
            if (parametros == null)
                parametros = new Dictionary<string, object>();
            parametros.Add(campo, valor);
            return parametros;
        }
        public List<T> FiltroTunado(string filtro)
        {
            var palavras = filtro.Split(' ');

            return Registros.Where(i => palavras.Any(p=> i.ToString().IndexOf(p, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }
    }   
}