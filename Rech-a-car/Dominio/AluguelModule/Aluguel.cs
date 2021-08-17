using System;
using Dominio.VeiculoModule;
using Dominio.ServicoModule;
using Dominio.PessoaModule;
using System.Collections.Generic;

namespace Dominio.AluguelModule
{
    public class Aluguel : Entidade
    {
        public Aluguel(Veiculo veiculo, ICliente cliente, List<Servico> servicos, Condutor condutor)
        {
            this.veiculo = veiculo;
            this.cliente = cliente;
            this.servicos = servicos;
            this.condutor = condutor;
        }
        public Veiculo veiculo { get; set; }
        public ICliente cliente { get; set; }
        public List<Servico> servicos { get; set; }
        public Condutor condutor { get; set; }


        public override string Validar()
        {
            string validacao = String.Empty;

            if ()
                throw new NotImplementedException();
        }
    }
}