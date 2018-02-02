
using System;

namespace Contmatic.Integracao.Domain.Entidades.Shared
{
    public abstract class Entidade
    {
        public  Entidade(){}

    
        public Guid Id { get; set; }
    }
}