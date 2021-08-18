using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.ServicoModule;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;

namespace Dominio.AluguelModule
{
    public class Aluguel : Entidade
    {
        public Aluguel(Veiculo veiculo, ICliente cliente, List<Servico> servicos, Condutor condutor, TipoAluguel tipoAluguel)
        {
            this.veiculo = veiculo;
            this.cliente = cliente;
            this.servicos = servicos;
            this.condutor = condutor;
            this.tipoAluguel = tipoAluguel;
        }

        public Veiculo veiculo { get; set; }
        public ICliente cliente { get; set; }
        public List<Servico> servicos { get; set; }
        public Condutor condutor { get; set; }
        public TipoAluguel tipoAluguel { get; set; }

        public override string Validar()
        {
            string validacao = String.Empty;
            if (true)
                throw new NotImplementedException();
        }
    }
}