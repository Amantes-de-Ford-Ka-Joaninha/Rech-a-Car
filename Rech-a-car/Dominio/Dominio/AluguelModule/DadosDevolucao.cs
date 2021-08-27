using Dominio.ServicoModule;
using System.Collections.Generic;

namespace Dominio.AluguelModule
{
    public class DadosDevolucao
    {
        public DadosDevolucao(int kmRodados, double tanqueUtilizado, List<Servico> servicosNecessarios)
        {
            KmRodados = kmRodados;
            TanqueUtilizado = tanqueUtilizado;
            ServicosNecessarios = servicosNecessarios;
        }
        public int KmRodados { get; set; }
        public double TanqueUtilizado { get; set; }

        public List<Servico> ServicosNecessarios { get; set; }
    }
}