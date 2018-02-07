using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public abstract class Cliente
    {      

        protected Cliente(Codigo codigo, Apelido apelido, Pessoa pessoa )
        {
            Codigo = codigo;
            Apelido = apelido;
            Pessoa = pessoa;
        }        

        public Pessoa Pessoa { get;}
        public Codigo Codigo { get;}
        public Apelido Apelido { get;}
    }
}