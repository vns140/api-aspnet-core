
using System;
using Integracao.Domain.Shared.Validacoes;

namespace Contmatic.Integracao.Domain.Entidades.Shared
{
    public abstract class Entidade : Validacao
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Entidade(Guid id)
        {
            Id = id;
        }
        
        public Guid Id { get; }
    }
}