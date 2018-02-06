
using Contmatic.Integracao.Domain.ObjetosValor.Shared;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Telefone : ObjetoValor
    {
        private Telefone(string dDI, string dDD, string numero, bool numeroConfirmado)
        {
            DDI = dDI;
            DDD = dDD;
            Numero = numero;
            NumeroConfirmado = numeroConfirmado;
        }

        public static Telefone Factory(string dDI, string dDD, string numero, bool numeroConfirmado)
        {
            Telefone telefone = new Telefone(dDI, dDD, numero, numeroConfirmado);
            return telefone;
        }

        public string DDI { get; }
        public string DDD { get; }
        public string Numero { get; }
        public bool NumeroConfirmado { get; }
    }
}