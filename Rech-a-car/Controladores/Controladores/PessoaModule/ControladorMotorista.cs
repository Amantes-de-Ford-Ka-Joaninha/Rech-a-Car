using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.Data;
using Controladores.Shared;

namespace Controladores.PessoaModule
{
    public class ControladorMotorista : ControladorDependencia<MotoristaEmpresa>
    {
        public override void Inserir()
        {
            throw new NotImplementedException();
        }
        public override MotoristaEmpresa ConverterEmEntidade(IDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override Dictionary<string, object> ObtemParametrosRegistro(MotoristaEmpresa registro)
        {
            throw new NotImplementedException();
        }

        public List<MotoristaEmpresa> SelecionarCondutoresPJ(int id)
        {
            throw new NotImplementedException();
        }
    }
}
