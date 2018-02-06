using Contmatic.Integracao.Domain.ObjetosValor.Shared;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Nome : ObjetoValor
    {
        private Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
        }

        public static Nome Factory(string primeiroNome, string sobreNome)
        {
            Nome nome = new Nome(primeiroNome,sobreNome);
            return nome;
        }

        public string PrimeiroNome { get;}
        public string SobreNome { get;}
    }
}