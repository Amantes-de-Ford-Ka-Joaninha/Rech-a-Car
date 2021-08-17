using System;

namespace Dominio.ServicoModule
{
    public class Servico : Entidade
    {
        public Servico(string nome, double taxa)
        {
            Nome = nome;
            Taxa = taxa;
        }

        public string Nome { get; set; }
        public double Taxa { get; set; }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
