using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class CNPJ : Documento
    {
        private CNPJ(string identificacao) : base(identificacao)
        {

        }

        public static CNPJ Factory(string identificacao)
        {
            CNPJ cnpj = new CNPJ(identificacao);

            CNPJValidator cnpjValidator = new CNPJValidator();
            cnpj.IncluirValidacao(cnpjValidator.Validate(cnpj)); 
                   
            return cnpj;
        }

    }
}