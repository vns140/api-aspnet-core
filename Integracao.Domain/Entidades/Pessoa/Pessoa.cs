using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public abstract class Pessoa
    {
        protected Pessoa(Email email, Telefone Celular) : base()
        {
            Email = Email;
            Celular.TipoCelular();         
        }

        public Email Email { get; }

        public Telefone Celular { get; }

    }
}