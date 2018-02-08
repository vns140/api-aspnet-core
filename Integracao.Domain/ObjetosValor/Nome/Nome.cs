using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;

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
            NomeValidator nomeValidator = new NomeValidator();

            nome.IncluirValidacao(nomeValidator.Validate(nome));
            return nome;
        }

        public string PrimeiroNome { get;}
        public string SobreNome { get;}
    }
}