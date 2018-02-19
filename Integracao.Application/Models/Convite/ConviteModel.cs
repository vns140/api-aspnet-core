using static Contmatic.Integracao.Domain.Enums.EConviteType;

namespace Contmatic.Integracao.Application.Models
{
    public class ConviteModel
    {     
       public ClienteConvidado ClienteConvidado { get; set; }
       public ClienteSolicitante ClienteSolicitante { get; set; }
    }
}