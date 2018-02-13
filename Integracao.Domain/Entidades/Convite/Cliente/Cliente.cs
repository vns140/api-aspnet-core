using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public abstract class Cliente
    {
        public Cliente()
        {

        }
        protected Cliente(Codigo codigo, Apelido apelido, Pessoa pessoa)
        {
            Codigo = codigo;
            Apelido = apelido;
            Pessoa = pessoa;
        }

        public Pessoa Pessoa { get; private set; }
        public Codigo Codigo { get; private set; }
        public Apelido Apelido { get; private set; }
    }
}