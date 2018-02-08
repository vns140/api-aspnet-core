using System;

using Contmatic.Integracao.Domain.ObjetosValor;
using Contmatic.Integracao.Domain.Entidades.Shared;
using static Contmatic.Integracao.Domain.Enums.EConviteType;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;

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

            ConviteValidator conviteValidator = new ConviteValidator();
            convite.IncluirValidacao(conviteValidator.Validate(convite)); 
            
            return convite;
        }

        public Chave Chave { get; }
        public ClienteSolicitante ClienteSolicitante { get; }
        public EStatus Status { get; private set; }
        public DateTime DataCriacao { get; }
        public DateTime? DataAceite { get; private set; }
        public ClienteConvidado ClienteConvidado { get; }

        public void AceitarConvite()
        {
            Status = EStatus.Ativo;
            DataAceite = DateTime.Now;
        }

        public void RecusarConvite()
        {
            Status = EStatus.Ativo;
            DataAceite = DateTime.Now;
        }
    }
}