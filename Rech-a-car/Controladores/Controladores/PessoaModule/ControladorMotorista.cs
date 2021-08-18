using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.PessoaModule
{
    public class ControladorMotorista : Controlador<MotoristaEmpresa>
    {
        public override void Inserir(MotoristaEmpresa motorista)
        {
            throw new NotImplementedException();
        }
        public override void Editar(int id, MotoristaEmpresa entidade)
        {
            throw new NotImplementedException();
        }
        protected override MotoristaEmpresa ConverterEmEntidade(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<string, object> ObterParametrosRegistro(MotoristaEmpresa registro)
        {
            throw new NotImplementedException();
        }

        public List<MotoristaEmpresa> SelecionarCondutoresPJ(int id)
        {
            throw new NotImplementedException();
        }
    }
}
