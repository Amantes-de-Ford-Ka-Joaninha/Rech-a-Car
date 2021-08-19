namespace Dominio.PessoaModule
{
    public abstract class Condutor : PessoaFisica
    {
        public CNH Cnh { get; set; }

        public override string Validar()
        {
            string validacao = base.Validar();

            validacao += Cnh.Validar();

            if (validacao == string.Empty)
                return Valido;

            return validacao;
        }
    }
}
