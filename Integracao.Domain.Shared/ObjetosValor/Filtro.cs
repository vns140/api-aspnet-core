using Integracao.Domain.Shared.Validacoes;

namespace Contmatic.Integracao.Domain.ObjetosValor.Shared
{
    public abstract class Filtro : Validacao
    {
        public int Limit { get; }

        public int Offset { get; }
        
        public Filtro(int limit, int offset)
        {
            Limit = limit;
            Offset = offset;
        }
    }
}