namespace Contmatic.Integracao.Domain.ObjetosValor.Shared
{
    public abstract class Documento : ObjetoValor
    {
        public Documento(){}

        public string Identificacao { get; set; }
    }
}