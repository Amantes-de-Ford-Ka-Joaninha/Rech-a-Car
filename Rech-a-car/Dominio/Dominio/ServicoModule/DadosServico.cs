using System;


namespace Dominio.ServicoModule
{
    public class DadosServico : Entidade
    {
        public DadosServico(int nome, double taxa)
        {
            Nome = nome;

            Taxa = taxa;
        }

        
        public object Nome { get; set; }

        public object Taxa { get; set; }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty((string)Nome))
                resultadoValidacao = "O Campo Nome é Obrigatorio";

            if ((double)Taxa <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O Campo Taxa é está inválido";  

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

    }
    
}