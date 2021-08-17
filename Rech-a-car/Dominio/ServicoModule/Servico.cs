using System;

namespace Dominio.ServicoModule
{
    public class Servico : Entidade
    {
        public Servico(string nome, double taxa)
        {
            Nome = nome;
            Taxa1 = taxa;
        }

        public string Nome { get; set; }
        public string Taxa { get; set; }
        public double Taxa1 { get; }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
