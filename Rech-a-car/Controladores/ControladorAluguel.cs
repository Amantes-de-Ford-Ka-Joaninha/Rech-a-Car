using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.AluguelModule;

namespace Controladores
{
    class ControladorAluguel : ControladorBase<Aluguel>
    {
        public override string sqlSelecionarPorId => throw new NotImplementedException();

        public override string sqlSelecionarTodos => throw new NotImplementedException();

        public override string sqlInserir => throw new NotImplementedException();

        public override string sqlEditar => throw new NotImplementedException();

        public override string sqlExcluir => throw new NotImplementedException();

        public override string sqlExists => throw new NotImplementedException();

        protected override Aluguel ConverterEmRegistro(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<string, object> ObtemParametrosRegistro(Aluguel registro)
        {
            throw new NotImplementedException();
        }
    }
}
