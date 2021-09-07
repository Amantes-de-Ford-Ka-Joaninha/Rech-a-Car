﻿using Dominio.ServicoModule;
using System;
using System.Collections.Generic;

namespace Dominio.AluguelModule
{
    public class AluguelFechado : Aluguel
    {
        public AluguelFechado(Aluguel aluguel, int kmRodados, double tanqueUtilizado, List<Servico> servicosNecessarios, DateTime dataDevolvida) : base(aluguel)
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
            DataDevolvida = dataDevolvida;
            DataDevolucao = aluguel.DataDevolucao;
        }
        public int KmRodados { get; set; }
        public double TanqueUtilizado { get; set; }
        public List<Servico> ServicosNecessarios { get; set; }
        public DateTime DataDevolvida { get; set; }
        public override double CalcularTotal()
        {
            double PrecoFinal = 0;
            Servicos.ForEach(x => PrecoFinal += x.Taxa);

            var Categoria = Veiculo.Categoria;

            switch (TipoPlano)
            {
                case Plano.diario:
                    CalculaPlanoDiario(); break;
                case Plano.controlado:
                    CalculaPlanoControlado(); break;
                case Plano.livre:
                    CalculaPlanoLivre(); break;
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
        public override string Validar()
        {
            string validacao = base.Validar();

            if (KmRodados < 0)
                validacao += "Quilometros rodados necessita ser pelo menos 0\n";

            if (TanqueUtilizado < 0)
                validacao += "Tanque utilizado tem que ser pelo menos 0\n";

            return validacao;
        }
    }
}
