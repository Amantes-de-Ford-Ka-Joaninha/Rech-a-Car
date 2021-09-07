using Aspose.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf.Text;
using Dominio.AluguelModule;
using System.IO;
using System.Drawing.Imaging;

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

            page.Paragraphs.Add(new TextFragment($"Data de Aluguel: {aluguel.DataAluguel:d}"));
            page.Paragraphs.Add(new TextFragment($"Data de Devolução: {aluguel.DataDevolucao:d}"));
            page.Paragraphs.Add(new TextFragment($"Total Parcial R$: {aluguel.CalcularTotal()}"));

            document.Save($@"..\..\..\PDFs\{aluguel.Cliente}-Aluguel-{aluguel.Id}.pdf");
            //page.Resources.Images.Add(ImagemParaStream(aluguel.Veiculo.Foto));
        }

        private static MemoryStream ImagemParaStream(System.Drawing.Image imagem)
        {
            var stream = new MemoryStream();
            imagem.Save(stream, ImageFormat.Bmp);
            return stream;
        }
    }
}
