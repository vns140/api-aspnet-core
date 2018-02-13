using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using System;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Chave : ObjetoValor
    {
       
        private Chave(string identificacao)
        {
            Identificacao = identificacao;
            Validade = DateTime.Now.AddYears(3);
        }      
        public string Identificacao { get; private set;}

        public DateTime Validade { get; private set;}

        public static Chave Factory()
        {
            string identificacao = Guid.NewGuid().ToString().Replace("-", "").ToUpper();
            Chave chave = new Chave(identificacao);

            ChaveValidator chaveValidator = new ChaveValidator();
            chave.IncluirValidacao(chaveValidator.Validate(chave));

            return chave;
        }
    }
}