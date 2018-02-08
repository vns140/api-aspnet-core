using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Codigo : ObjetoValor
    {
        private Codigo(string identificacao)
        {
            Identificacao = identificacao;
        }

        public string Identificacao { get; }

        public static Codigo Factory(string identificacao)
        {
            Codigo codigo = new Codigo(identificacao);
            CodigoValidator codigoValidator = new CodigoValidator();

            codigo.IncluirValidacao(codigoValidator.Validate(codigo));
            return codigo;
        }
    }
}