using Controladores.Shared;
using Dominio.AluguelModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores
{
    public class ControladorAluguel : ControladorEntidade<Aluguel>
    {
        public override string sqlSelecionarTodos => throw new NotImplementedException();

        public override string sqlInserir => throw new NotImplementedException();

        public override string sqlEditar => throw new NotImplementedException();

        public override string sqlExcluir => throw new NotImplementedException();

        public override string sqlExists => throw new NotImplementedException();

        public override string sqlSelecionarPorId => throw new NotImplementedException();

        protected override Aluguel ConverterEmEntidade(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<string, object> ObterParametrosRegistro(Aluguel registro)
        {
            throw new NotImplementedException();
        }
    }
}
