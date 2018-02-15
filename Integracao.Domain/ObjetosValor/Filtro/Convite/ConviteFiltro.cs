using Contmatic.Integracao.Domain.Entidades;
using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using Contmatic.Integracao.Domain.ObjetosValor.Validacoes;
using static Contmatic.Integracao.Domain.Enums.EConviteType;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class ConviteFiltro : Filtro
    {
        public ConviteFiltro(Pessoa clienteConvidado, Pessoa clienteSolicitante,
        EStatus? status, int limit, int offset) : base(limit, offset)
        {
            Status = status;
            ClienteConvidado = clienteConvidado;
            ClienteSolicitante = clienteSolicitante;
        }

        public EStatus? Status { get; private set; }
        public Pessoa ClienteConvidado { get; private set; }
        public Pessoa ClienteSolicitante { get; private set; }


        public static ConviteFiltro Factory(Pessoa clienteConvidado, Pessoa clienteSolicitante,
        EStatus? status, int limit, int offset)
        {
            ConviteFiltro filtro = new ConviteFiltro(clienteConvidado, clienteSolicitante,status, limit, offset);
            ConviteFiltroValidator conviteFiltroValidator = new ConviteFiltroValidator();
            filtro.IncluirValidacao(conviteFiltroValidator.Validate(filtro));

            return filtro;
        }
    }
}