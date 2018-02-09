using Contmatic.Integracao.Domain.ObjetosValor.Shared;
using static Contmatic.Integracao.Domain.Enums.EConviteType;

namespace Contmatic.Integracao.Domain.ObjetosValor
{
    public class ConviteFiltro : Filtro
    {
        public ConviteFiltro(int limit, int offset) : base(limit, offset)
        {
        }

        public EStatus Status { get; set; }
        public string CNPJ { get;}
        public string CPF { get; }
        public ETipoCliente TipoCliente { get;}
    }
}