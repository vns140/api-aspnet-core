using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Apelido : ObjetoValor
    {
        private Apelido(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }

        public static Apelido Factory(string descricao)
        {
            Apelido apelido = new Apelido(descricao);

            ApelidoValidator apelidoValidator = new ApelidoValidator();
            apelido.IncluirValidacao(apelidoValidator.Validate(apelido)); 
            return apelido;
        }
    }
}