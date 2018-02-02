using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;
using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class Integracao : Entidade
    {
        public Integracao() : base() { }
        public Chave Chave { get;}
        public DateTime DataCriacao { get;}
        public ClienteSolicitante ClienteSolicitante { get; }
        public ReadOnlyCollection<Convite> Convites { get; }

        private Integracao(ClienteSolicitante clienteSolicitante)
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
            Chave.Gerar();           
        }        
         
    }
}