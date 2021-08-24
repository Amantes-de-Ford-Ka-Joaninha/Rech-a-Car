﻿namespace Dominio.ServicoModule
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
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao = "O Campo Nome é Obrigatorio";

            if (Taxa <= 0)
                resultadoValidacao += "O Campo Taxa é está inválido";  

            return resultadoValidacao;
        }
    }
}