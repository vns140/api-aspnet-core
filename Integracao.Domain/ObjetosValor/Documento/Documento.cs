using Contmatic.Integracao.Domain.ObjetosValor.Shared;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public abstract class Documento : ObjetoValor
    {
        public Documento(){}

        protected Documento(string identificacao)
        {
            Identificacao = identificacao;
        }

        public string Identificacao { get; private set;}
    }
}