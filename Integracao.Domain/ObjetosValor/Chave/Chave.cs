using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using System;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Chave : ObjetoValor
    {      
        private Chave(string identificacao)
        {
            Identificacao = identificacao;
        }
        public string Identificacao { get;}

        public static Chave Factory()
        {
            string identificacao = Guid.NewGuid().ToString().Replace("-", "").ToUpper();            
            Chave  chave = new Chave(identificacao);
            return chave;
        }

       
    }
}