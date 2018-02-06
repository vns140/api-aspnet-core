using Contmatic.Integracao.Domain.ObjetosValor.Shared;

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
            return cnpj;
        }

    }
}