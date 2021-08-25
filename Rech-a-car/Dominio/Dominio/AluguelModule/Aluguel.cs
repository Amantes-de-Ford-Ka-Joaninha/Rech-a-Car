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
        public Aluguel(Veiculo veiculo, ICliente cliente, List<Servico> servicos, Condutor condutor, TipoAluguel tipoAluguel)
        {
            Veiculo = veiculo;
            Cliente = cliente;
            Servicos = servicos;
            Condutor = condutor;
            TipoAluguel = tipoAluguel;
        }

        public Veiculo Veiculo { get; set; }
        public ICliente Cliente { get; set; }
        public List<Servico> Servicos { get; set; }
        public Condutor Condutor { get; set; }
        public TipoAluguel TipoAluguel { get; set; }

        public override string Validar()
        {
            string validacao = String.Empty;
            throw new NotImplementedException();
            //if (condutor.Cnh > )
        }
    }
    public enum TipoAluguel
    {
        kmcontrolado = 1,
        kmlivre = 2,
        diária = 3
    }
}