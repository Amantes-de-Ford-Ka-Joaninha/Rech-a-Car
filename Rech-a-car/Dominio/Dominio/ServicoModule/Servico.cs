using Dominio.Shared;

namespace Dominio.ServicoModule
{
    public class Servico : Entidade
    {
        public Servico(string nome, double taxa, int estoque)
        {
            Nome = nome;
            Taxa = taxa;
            Estoque = estoque;
        }

        public string Nome { get; set; }
        public double Taxa { get; set; }
        public double Estoque { get; set; }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao = "O Campo Nome é Obrigatorio\n";

            if (Taxa <= 0)
                resultadoValidacao += "O Campo Taxa está inválido";

            if (Estoque <= 0)
                resultadoValidacao += "O Campo Estoque está inválido";

            return resultadoValidacao;
        }
    }
}