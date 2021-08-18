﻿using Dominio;
using System.Collections.Generic;
using Dominio.Shared;

namespace Controladores.Shared
{
    abstract public class ControladorEntidade<T> : Controlador<T> where T : Entidade
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
            registro.Id = Db.Insert(sqlInserir, ObterParametrosRegistro(registro));
        }
        public override void Editar(int id, T registro)
        {
            registro.Id = id;
            Db.Update(sqlEditar, ObterParametrosRegistro(registro));
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