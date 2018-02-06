using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class PessoaJuridica :Pessoa
    {
        private PessoaJuridica(CNPJ cNPJ, string razaoSocial, Codigo codigo, Apelido apelido, Email email):base(codigo,  apelido,email)
        {
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
        }

        public CNPJ CNPJ { get; }
        public string RazaoSocial { get; }
    }
}