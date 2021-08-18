namespace Dominio
{
    public abstract class Entidade
    {
        public int Id { get; set; }
        public abstract string Validar();

        protected readonly string Valido = "VALIDO";
    }
}
