using Contmatic.Integracao.Domain.ObjetosValor.Shared;

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
            return codigo;
        }
    }
}