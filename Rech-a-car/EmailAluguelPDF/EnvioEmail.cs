using Aspose.Pdf;
using Dominio.AluguelModule;

namespace EmailAluguelPDF
{
    public class EnvioEmail
    {
        public EnvioEmail(Aluguel aluguel, string path_pdf)
        {
            Aluguel = aluguel;
            Pdf = new Document(path_pdf);
        }
        public Aluguel Aluguel { get; }
        public Document Pdf { get; }
        public int Id { get; set; }
    }
}