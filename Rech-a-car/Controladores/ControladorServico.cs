using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.ServicoModule;

namespace Controladores
{
    class ControladorServico : ControladorBase<Servico>
    {
        public override string sqlSelecionarPorId => throw new NotImplementedException();

        public override string sqlSelecionarTodos => throw new NotImplementedException();

        public override string sqlInserir => throw new NotImplementedException();

        public override string sqlEditar => throw new NotImplementedException();

        public override string sqlExcluir => throw new NotImplementedException();

        public override string sqlExists => throw new NotImplementedException();

        protected override Servico ConverterEmRegistro(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<string, object> ObtemParametrosRegistro(Servico registro)
        {
            throw new NotImplementedException();
        }
    }
}
