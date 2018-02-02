using Contmatic.Integracao.Domain.Integracao.Enums;
using Contmatic.Integracao.Domain.ObjetosValor;
using System;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class Convite 
    {
        public Convite(){}     
        public Chave Chave { get; set; }
        public UsuarioSolicitante UsuarioSolicitante { get; set; }
        public EStatus Status { get; set; }
        public DateTime Data { get; set; }
        public DateTime? DataAceite { get; set; }
        public ClienteConvidado ClienteConvidado { get; set; }
    }
}