using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.VeiculoModule
{
    public class DadosVeiculo : Entidade
    {
        public DadosVeiculo(int quilometragem, double diaria, double precoKm)
        {
            Quilometragem = quilometragem;
            Diaria = diaria;
            PrecoKm = precoKm;
        }
        public int Quilometragem { get; }
        public double Diaria { get; }
        public double PrecoKm { get; }
        public int Idtarefa { get; }

        public override string Validar()
        {
            string validacao = String.Empty;

            if (Quilometragem < 0)
                validacao += "Quilometragem inválida";
            if (Diaria < 0)
                validacao += "Valor da diária deve ser maior que 0";
            if (PrecoKm < 0)
                validacao += "Valor do preço por Km deve ser maior que 0";

            if (validacao == String.Empty)
                return Valido;

            return validacao;
        }
    }
}
