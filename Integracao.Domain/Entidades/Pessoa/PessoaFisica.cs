using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class PessoaFisica : Pessoa
    {
        private PessoaFisica(CPF cPF, Nome nome,Email email,Telefone celular):base(email,celular)
        {
            CPF = cPF;
            Nome = nome;
        }

        public static PessoaFisica Factory(CPF cPF, Nome nome, Email email,Telefone celular)
        {
            PessoaFisica pessoaFisica = new PessoaFisica(cPF,nome,email,celular);
            return pessoaFisica;
        }

        public CPF CPF { get; }
        public Nome Nome { get; }        
    }
}