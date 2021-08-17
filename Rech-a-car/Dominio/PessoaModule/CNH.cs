using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Dominio.PessoaModule
{
    public class CNH : Entidade
    {
        public string numeroCnh { get; set; }
        
        public TipoCNH tipoCnh { get; set; }

        Regex ValidarCNH = new Regex(@"\b(?=.*\d)[A-Za-z0-9]{1,11}\b");

        public override string Validar()
        {
            string validacao = String.Empty;
            if (ValidarCNH.IsMatch(numeroCnh))
                validacao = "CNH Inválida.\n";

            return validacao;
        }
    }
}
