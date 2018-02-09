namespace Contmatic.Integracao.Domain.ObjetosValor.Shared
{
    public abstract class Filtro
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