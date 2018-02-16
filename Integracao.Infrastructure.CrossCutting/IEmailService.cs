using System.Threading.Tasks;

namespace Contmatic.Integracao.Infrastructure.CrossCutting
{
    public interface IEmailService
    {
        /// <summary>
        /// Envia email
        /// </summary>
        /// <param name="assunto"></param>
        /// <param name="corpo"></param>
        /// <param name="de"></param>
        /// <param name="para"></param>
        /// <param name="senha"></param>
        /// <param name="conta"></param>
        /// <param name="servidor"></param>
        /// <param name="porta"></param>
        /// <returns></returns>
        Task EnviarEmailAsync(string assunto, string corpo, string de, string para, string senha, string conta, string servidor, int porta);
    }
}