using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using System;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Chave : ObjetoValor
    {      
        private Chave(string identificacao)
        {
            Identificacao = identificacao;
            Validade = DateTime.Now.AddYears(3);
        }
        
        public string Identificacao { get;}

        public DateTime Validade { get;}

        public static Chave Factory()
        {
            string identificacao = Guid.NewGuid().ToString().Replace("-", "").ToUpper();            
            Chave  chave = new Chave(identificacao);
            return chave;
        }       
    }
}