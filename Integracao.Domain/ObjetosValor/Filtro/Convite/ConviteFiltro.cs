using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using static Contmatic.Integracao.Domain.Enums.EConviteType;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class ConviteFiltro : Filtro
    {
        public ConviteFiltro(int limit, int offset) : base(limit, offset)
        {
        }

        public EStatus Status { get; private set; }
        public string CNPJ { get; private set; }
        public string CPF { get; private set; }
        public ETipoCliente TipoCliente { get; private set; }
    }
}