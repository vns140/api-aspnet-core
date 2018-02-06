using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public abstract class Cliente
    {
        public Pessoa Pessoa { get;}

        public Cliente(CNPJ cNPJ, string razaoSocial, Codigo codigo, Apelido apelido, Email email)
        {
           
        }
    }
}