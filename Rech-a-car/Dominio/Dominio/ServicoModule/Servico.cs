using Dominio.Shared;
using System;

namespace Dominio.ServicoModule
{
    public class Servico : Entidade
    {
        public Servico(string nome, double taxa)
        {
            Nome = nome;
            Taxa = taxa;
        }

        public string Nome { get; set; }
        public double Taxa { get; set; }

        public override string Validar()
        {
            string validacao = string.Empty;

            if (Nome == string.Empty)
                validacao = "Insira um Nome.\n";
            if (Taxa <= 0)
                validacao += "Taxa deve ser maior que 0.\n";

            if (validacao == string.Empty)
                return Valido;

            return validacao;
        }
    }
}