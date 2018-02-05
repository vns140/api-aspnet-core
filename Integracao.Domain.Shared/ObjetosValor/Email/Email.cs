using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using Integracao.Domain.Shared.ObjetosValor.Validacoes;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Email : ObjetoValor
    {
        public string Endereco { get; }

        private Email(string endereco)
        {
            Endereco = endereco;
        }

        public static Email Factory(string endereco)
        {
            Email email = new Email(endereco);
            EmailValidator emailValidator = new EmailValidator();

            email.IncluirValidacao(emailValidator.Validate(email));

            return email;
        }
    }
}