using Aspose.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf.Text;
using Dominio.AluguelModule;

namespace EmailAluguelPDF
{
    public class CriaPDFAluguel
    {
        public CriaPDFAluguel(Aluguel aluguel)
        {
            Document document = new Document();
            Page page = document.Pages.Add();

            page.Paragraphs.Add(new TextFragment($"Olá {aluguel.Cliente} aqui está o resumo do seu mais novo aluguel na Rech-a-car"));
            page.Paragraphs.Add(new TextFragment($"Veículo: {aluguel.Veiculo}"));
            page.Paragraphs.Add(new TextFragment($"Data de Aluguel: {aluguel.DataAluguel}"));
            page.Paragraphs.Add(new TextFragment($"Data de Devolução: {aluguel.DataDevolucao}"));
            page.Paragraphs.Add(new TextFragment($"Total Parcial: {aluguel.CalcularTotal()}"));


            document.Save($@"..\..\PDFs\Aluguel-{aluguel.Cliente}-{aluguel.Id}.pdf");
        }
    }
}
