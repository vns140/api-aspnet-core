using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;

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
            CPFValidator cpfValidator = new CPFValidator();

            cpf.IncluirValidacao(cpfValidator.Validate(cpf));
            return cpf;
        }
    }
}