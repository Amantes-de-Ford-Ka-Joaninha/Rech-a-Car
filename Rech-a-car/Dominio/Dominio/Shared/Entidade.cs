namespace Dominio.Shared
{
    public abstract class Entidade : IControlavel
    {
        public int Id { get; set; }
        public abstract string Validar();

        public readonly string Valido = "VALIDO";
    }
}
