using Dominio.ServicoModule;
using System;
using System.Collections.Generic;

namespace Dominio.AluguelModule
{
    public class AluguelFechado : Aluguel
    {
        public AluguelFechado(Aluguel aluguel, int kmRodados, double tanqueUtilizado, List<Servico> servicosNecessarios) : base(aluguel)
        {
            Veiculo = aluguel.Veiculo;
            Servicos = aluguel.Servicos;
            Cliente = aluguel.Cliente;
            Condutor = aluguel.Condutor;
            TipoPlano = aluguel.TipoPlano;
            DataAluguel = aluguel.DataAluguel;
            KmRodados = kmRodados;
            TanqueUtilizado = tanqueUtilizado;
            ServicosNecessarios = servicosNecessarios;
            DataDevolvida = DateTime.Now;
            DataDevolucao = aluguel.DataDevolucao;
        }
        public int KmRodados { get; set; }
        public double TanqueUtilizado { get; set; }
        public List<Servico> ServicosNecessarios { get; set; }
        public DateTime DataDevolvida { get; set; }
        public double CalcularTotal()
        {
            double PrecoFinal = 0;
            Servicos.ForEach(x => PrecoFinal += x.Taxa);

            var Categoria = Veiculo.Categoria;

            switch (TipoPlano.ToString())
            {
                case "diario":
                    CalculaPlanoDiario();
                    break;
                case "controlado":
                    CalculaPlanoControlado();
                    break;
                case "livre":
                    CalculaPlanoLivre();
                    break;
                default:
                    break;
            }

            void CalculaPlanoControlado()
            {
                PrecoFinal += (Categoria.PrecoDiaria * GetQtdDiasAluguel()) +
                    Categoria.QuilometragemFranquia * Categoria.PrecoKm;
            }
            void CalculaPlanoDiario()
            {
                PrecoFinal += Categoria.PrecoDiaria * GetQtdDiasAluguel();
            }
            void CalculaPlanoLivre()
            {
                PrecoFinal += Categoria.PrecoDiaria * GetQtdDiasAluguel() * 1.3;
            }
            int GetQtdDiasAluguel()
            {
                return (DataDevolucao - DataAluguel).Days;
            }

            int diasAtraso = (DataDevolucao - DateTime.Now).Days;

            PrecoFinal += diasAtraso * 50;

            //CALCULAR GASOLINA DEPOIS.

            ServicosNecessarios.ForEach(x => PrecoFinal += x.Taxa);

            return PrecoFinal;

        }
    }
}
