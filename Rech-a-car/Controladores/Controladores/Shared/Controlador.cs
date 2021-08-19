using Dominio.Shared;
using System;
using System.Collections.Generic;

namespace Controladores.Shared
{
    public abstract class Controlador<T> where T : IControlavel
    {
        public List<T> Registros => ObterRegistros();
        public abstract void Inserir(T entidade);
        public abstract void Editar(int id, T entidade);
        public abstract void Excluir(int id, Type tipo = null);
        public abstract T GetById(int id, Type tipo = null);
        protected abstract List<T> ObterRegistros();
    }
}