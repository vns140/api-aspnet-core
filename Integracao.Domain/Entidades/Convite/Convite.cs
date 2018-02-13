using System;

using Contmatic.Integracao.Domain.ObjetosValor;
using Contmatic.Integracao.Domain.Entidades.Shared;
using static Contmatic.Integracao.Domain.Enums.EConviteType;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class Convite : Entidade
    {
        public Convite()
        {
            
        }
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

        public Chave Chave { get; private set; }
        public ClienteSolicitante ClienteSolicitante { get; private set; }
        public EStatus Status { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataAceite { get; private set; }
        public ClienteConvidado ClienteConvidado { get; private set; }

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