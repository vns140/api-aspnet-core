using Contmatic.Integracao.Domain.ObjetosValor.Shared;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Email : ObjetoValor
    {
        public Email(){}

        private  Email(string endereco)
        {
            Endereco = endereco;
        }

        public static Email Factory(string endereco)
        {
            Email email = new Email(endereco);
            return email;
        }

        public string Endereco { get; set; }
    }
}