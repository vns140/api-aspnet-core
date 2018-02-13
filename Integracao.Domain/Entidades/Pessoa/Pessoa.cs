using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public abstract class Pessoa
    {
        public Pessoa()
        {
            
        }
        protected Pessoa(Email email, Telefone celular) : base()
        {
            Email = email;
            Celular = celular;
            Celular.TipoCelular();         
        }

        public Email Email { get; private set; }

        public Telefone Celular { get; private set; }

    }
}