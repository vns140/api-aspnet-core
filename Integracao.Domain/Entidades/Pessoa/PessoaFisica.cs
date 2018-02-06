using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class PessoaFisica : Pessoa
    {
        private PessoaFisica(CPF cPF, Nome nome, Codigo codigo, Apelido apelido, Email email):base(codigo,  apelido,email)
        {
            CPF = cPF;
            Nome = nome;
        }

        public CPF CPF { get; }
        public Nome Nome { get; }
        
    }
}