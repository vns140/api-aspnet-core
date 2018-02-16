using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Contmatic.Integracao.Infrastructure.CrossCutting
{
    public class EmailService : IEmailService
    {
        public async Task EnviarEmailAsync(string assunto, string corpo, string de, string para, string senha, string conta, string servidor, int porta)
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = servidor;
                    smtp.Port = porta;
                    smtp.EnableSsl = false;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential(conta, senha);

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.IsBodyHtml = true;
                        mail.From = new MailAddress(de);

                        if (!string.IsNullOrWhiteSpace(para))
                        {
                            mail.To.Add(new MailAddress(para));
                        }

                        mail.Subject = assunto;
                        mail.Body = corpo;

                        //envia o email
                        await smtp.SendMailAsync(mail);
                    }

                }               

            }
            catch (Exception ex)
            {
                throw(ex);
            }

        }
    }
}
