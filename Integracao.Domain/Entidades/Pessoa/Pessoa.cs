using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public abstract class Pessoa : Entidade
    {
        protected Pessoa(Codigo codigo, Apelido apelido, Email email):base()
        {
            Codigo = Codigo;
            Apelido = Apelido;
            Email = Email;
        }

        public static PessoaFisica Factory(Codigo codigo, Apelido apelido, Email email)
        {      

            return null;
        }        

        public Codigo Codigo { get; }
        public Apelido Apelido { get; }
        public Email Email { get; }
    }
}