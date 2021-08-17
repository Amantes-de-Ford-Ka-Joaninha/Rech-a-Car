using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores
{
    public class ControladorServico : ControladorEntidade<Servico>
    {
        public override string sqlSelecionarPorId => throw new NotImplementedException();

        public override string sqlSelecionarTodos => throw new NotImplementedException();

        public override string sqlInserir => throw new NotImplementedException();

        public override string sqlEditar => throw new NotImplementedException();

        public override string sqlExcluir => throw new NotImplementedException();

        public override string sqlExists => throw new NotImplementedException();

        protected override Servico ConverterEmEntidade(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<string, object> ObtemParametrosRegistro(Servico registro)
        {
            throw new NotImplementedException();
        }
    }
}
