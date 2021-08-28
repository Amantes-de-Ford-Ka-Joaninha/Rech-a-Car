using System;

namespace Dominio.AluguelModule
{
    public class AluguelFechado : Aluguel
    {
        public AluguelFechado(Aluguel aluguel, DadosDevolucao dados) : base(aluguel)
        {
            Veiculo = aluguel.Veiculo;
            Servicos = aluguel.Servicos;
            Cliente = aluguel.Cliente;
            Condutor = aluguel.Condutor;
            TipoPlano = aluguel.TipoPlano;
            DataAluguel = aluguel.DataAluguel;
            DataDevolucao = DateTime.Now;
            Total = Calcular(dados.KmRodados);
        }
        public DateTime DataDevolucao { get; set; }
        public double Total { get; set; }
        public double Calcular(int kmRodados)
        {
            if (TipoPlano == Plano.diario)
                return 0;
            return 0;
        }
    }
}
