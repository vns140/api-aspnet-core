using Contmatic.Integracao.Domain.ObjetosValor.Shared;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Apelido : ObjetoValor
    {
        private Apelido(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; }

        public static Apelido Factory(string descricao)
        {
            Apelido apelido = new Apelido(descricao);
            return apelido;
        }
    }
}