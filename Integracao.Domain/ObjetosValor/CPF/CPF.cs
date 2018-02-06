using Contmatic.Integracao.Domain.ObjetosValor.Shared;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class CPF : Documento
    {
        private CPF(string identificacao) : base(identificacao)
        {
        }
        public static CPF Factory(string identificacao)
        {
            CPF cpf = new CPF(identificacao);
            return cpf;
        }
    }
}