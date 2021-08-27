using Dominio.PessoaModule;
using Dominio.Shared;
using System;

namespace Dominio.VeiculoModule
{
    public class Grupo : Entidade
    {
        public Grupo(string nome, double diaria, double precoKm, int quilometragemFranquia, double precoLivre, TipoCNH tipoCnh)
        {
            Nome = nome;
            PrecoDiaria = diaria;
            PrecoKm = precoKm;
            PrecoLivre = precoLivre;
            QuilometragemFranquia = quilometragemFranquia;
            TipoDeCnh = tipoCnh;
        }
        public string Nome { get; }
        public double PrecoDiaria { get; }
        public double PrecoKm { get; }
        public double PrecoLivre { get; }
        public int QuilometragemFranquia { get; }
        public TipoCNH TipoDeCnh { get; }
        public override string Validar()
        {
            string validacao = String.Empty;

            if (Nome == string.Empty)
                validacao += "Valor da diária deve ser maior que 0\n";

            if (PrecoDiaria <= 0)
                validacao += "Valor da diária deve ser maior que 0\n";
            if (PrecoKm <= 0)
                validacao += "Valor do preço por Km deve ser maior que 0\n";

            return validacao;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
