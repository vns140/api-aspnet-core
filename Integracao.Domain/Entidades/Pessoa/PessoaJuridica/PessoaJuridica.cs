using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class PessoaJuridica :Pessoa
    {
        public PessoaJuridica()
        {
            
        }
        private PessoaJuridica(CNPJ cNPJ, string razaoSocial,Email email,Telefone celular):base(email,celular)
        {
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
        }

        public static PessoaJuridica Factory(CNPJ cNPJ, string razaoSocial,Email email,Telefone celular)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica(cNPJ,razaoSocial,email,celular);
            return pessoaJuridica;
        }

        public CNPJ CNPJ { get; private set; }
        public string RazaoSocial { get; private set; }
    }
}