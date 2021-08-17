using System;
using System.Collections.Generic;
using System.Data;
using Dominio.PessoaModule.ClienteModule;

namespace Controladores.PessoaModule
{
    class ControladorClientePJ : ControladorEntidade<ClientePJ>
    {
        public override string sqlSelecionarPorId => throw new NotImplementedException();

        public override string sqlSelecionarTodos => throw new NotImplementedException();

        public override string sqlInserir => throw new NotImplementedException();

        public override string sqlEditar => throw new NotImplementedException();

        public override string sqlExcluir => throw new NotImplementedException();

        public override string sqlExists => throw new NotImplementedException();

        protected override ClientePJ ConverterEmEntidade(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<string, object> ObtemParametrosRegistro(ClientePJ registro)
        {
            throw new NotImplementedException();
        }
    }
}
