using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace EmailAluguelPDF
{
    public class EnviaPDFEmail
    {
        private const string email = "rech.a.car.alugueldeveiculos@gmail.com";

        private static ControladorEmail controladorEmail = new ControladorEmail();
        private static SmtpClient client = new SmtpClient("smtp.gmail.com", 587) 
        {
            Credentials = new NetworkCredential(email, "rech#admin"),
            UseDefaultCredentials = false,
            EnableSsl = true
        };

        public EnviaPDFEmail()
        {
            var proxEnvio = controladorEmail.GetProxEnvio();

            if (proxEnvio == null)
                return;

            var emailUsuario = proxEnvio.Aluguel.Cliente.Email;
            var message = new MailMessage(email, emailUsuario, "Resumo Aluguel Rech-a-car", "Confira o resumo do seu mais novo aluguel: ");

            var stream = new MemoryStream();
            proxEnvio.Pdf.Save(stream);

            var data = new Attachment(stream, "Pdf Resumo Aluguel.pdf");
            message.Attachments.Add(data);

            try
            {
                client.Send(message);
                controladorEmail.AlterarEnviado(proxEnvio.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}