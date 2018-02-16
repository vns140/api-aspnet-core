using System.Threading.Tasks;
using Contmatic.Integracao.Infrastructure.CrossCutting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Integracao.Infrastructure.CrossCutting.Test
{
    [TestClass]
    public class EmailServiceTest
    {
        [TestMethod]
        public async Task DeveEnviarUmEmail()
        {
            IEmailService emailservice = new EmailService();

            await emailservice.EnviarEmailAsync
            (
                "[Contmatic] Solicitação de Integração",
                "<h1> Teste Integração</h1> </br> <p> teste e-mail de envio </p>",
                "devops@contmatic.com.br",
                "vinicius.silva@contmatic.com.br",
                "r34fagj",
                "vinicius.silva",
                "mailserver.contmatic.com.br",
                587
            );
        }
    }
}
