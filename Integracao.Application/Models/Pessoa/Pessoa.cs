using static Contmatic.Integracao.Domain.Shared.Enums.ETelefone;

namespace Contmatic.Integracao.Application.Models
{
    public class PessoaModel
    {
        public string Email { get; set; }
        public string DDDTelefone { get; set; }
        public string DDITelefone { get; set; }
        public string NumeroTelefone { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
    }
}