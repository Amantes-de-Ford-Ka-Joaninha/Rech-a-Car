using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.Shared;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;

namespace Dominio.AluguelModule
{
    public class Aluguel : Entidade
    {
        public Aluguel(Veiculo veiculo, List<Servico> servicos, Plano tipoPlano, DateTime dataAluguel, ICliente cliente, Funcionario funcionario, DateTime dataDevolucao, Condutor condutor = null)
        {
            Funcionario = funcionario;
            Veiculo = veiculo;
            Servicos = servicos;
            TipoPlano = tipoPlano;
            DataAluguel = dataAluguel;
            Cliente = cliente;
            Condutor = condutor;
            DataDevolucao = dataDevolucao;
            if (condutor == null)
                Condutor = (Condutor)cliente;
        }
        public Aluguel(Aluguel aluguel)
        {
            Funcionario = aluguel.Funcionario;
            Veiculo = aluguel.Veiculo;
            Servicos = aluguel.Servicos;
            TipoPlano = aluguel.TipoPlano;
            DataAluguel = aluguel.DataAluguel;
            Cliente = aluguel.Cliente;
            Condutor = aluguel.Condutor;
            if (aluguel.Condutor == null)
                Condutor = (Condutor)aluguel.Cliente;
        }
        public Aluguel() { }

        public Funcionario Funcionario { get; set; }
        public Veiculo Veiculo { get; set; }
        public ICliente Cliente { get; set; }
        public List<Servico> Servicos { get; set; } = new List<Servico>();
        public Condutor Condutor { get; set; }
        public Plano TipoPlano { get; set; }
        public DateTime DataAluguel { get; set; }
        public DateTime DataDevolucao { get; set; }

        public virtual double CalcularTotal()
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

            return PrecoFinal;

        }
        public AluguelFechado Fechar(int kmRodados, double tanqueUtilizado, List<Servico> servicos)
        {
            return new AluguelFechado(this, kmRodados, tanqueUtilizado, servicos);
        }
        public override string Validar()
        {
            string validacao = String.Empty;
            if (Condutor.Cnh.TipoCnh < Veiculo.Categoria.TipoDeCnh)
                validacao += "Condutor não tem a carteira necessária para dirigir o veículo selecionado";

            if (DataAluguel < DateTime.Today)
                validacao += "Data de aluguel não pode ser no passado\n";

            if (DataAluguel >= DataDevolucao)
                validacao += "Data de devolução deve ser após data de aluguel";

            return validacao;
        }
    }
    public enum Plano
    {
        diario,
        controlado,
        livre
    }
}