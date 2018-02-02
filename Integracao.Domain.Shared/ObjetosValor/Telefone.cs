using Contmatic.Integracao.Domain.ObjetosValor.Shared;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Telefone : ObjetoValor
    {
        public Telefone(){}

        public string DDI { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public bool NumeroConfirmado { get; set; }
    }
}