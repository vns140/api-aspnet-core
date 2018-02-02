using System;

using Contmatic.Integracao.Domain.ObjetosValor;
using Contmatic.Integracao.Domain.Entidades.Shared;
using static Contmatic.Integracao.Domain.Enums.EConviteType;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class Convite : Entidade
    {
        private Convite(ClienteSolicitante clienteSolicitante, ClienteConvidado clienteConvidado) : base()
        {
            Chave = Chave.Factory();
            Status = EStatus.Pendente;
            DataCriacao = DateTime.Now;
            ClienteSolicitante = clienteSolicitante;
            ClienteConvidado = clienteConvidado;
        }

        public static Convite Factory(ClienteSolicitante clienteSolicitante, ClienteConvidado clienteConvidado)
        {
            Convite convite = new Convite(clienteSolicitante, clienteConvidado);
            return convite;
        }

        public Chave Chave { get; }
        public ClienteSolicitante ClienteSolicitante { get; }
        public EStatus Status { get; }
        public DateTime DataCriacao { get; }
        public DateTime? DataAceite { get; }
        public ClienteConvidado ClienteConvidado { get; }
    }
}