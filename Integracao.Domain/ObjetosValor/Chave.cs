using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using System;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class Chave : ObjetoValor
    {
        public Chave() { }

        public string Identificacao { get; private set; }

        public void Gerar()
        {
            string chave = Guid.NewGuid().ToString().Replace("-", "").ToUpper();
            Identificacao = chave;
        }

        public void Set(string chave)
        {
            Identificacao = chave;     
        }
    }
}