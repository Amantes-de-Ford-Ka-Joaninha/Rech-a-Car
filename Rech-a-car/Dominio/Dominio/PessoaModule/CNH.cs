using Dominio.Shared;
using System;
using System.Text.RegularExpressions;

namespace Dominio.PessoaModule
{
    public class CNH : Entidade
    {
        public string NumeroCnh { get; set; }

        public TipoCNH TipoCnh { get; set; }

        Regex ValidarCNH = new Regex(@"\b(?=.*\d)[A-Za-z0-9]{1,11}\b");

        public override string Validar()
        {
            string validacao = String.Empty;

            if (!ValidarCNH.IsMatch(NumeroCnh))
                validacao = "CNH Inválida.\n";

            if (validacao == String.Empty)
                return Valido;

            return validacao;
        }
    }
    public enum TipoCNH
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5
    }
}
