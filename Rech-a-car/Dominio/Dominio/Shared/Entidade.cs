using Dominio.Shared;
using System;


namespace Dominio
{
    public abstract class Entidade : IControlavel
    {
        public int Id { get; set; }
        public abstract string Validar();

        public readonly string Valido = "VALIDO";

        protected string QuebraDeLinha(string resultadoValidacao)
        {
            string quebraDeLinha = "";

            if (string.IsNullOrEmpty(resultadoValidacao) == false)
                quebraDeLinha = Environment.NewLine;

            return quebraDeLinha;
        }
    }
}
