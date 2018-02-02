using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class UsuarioSolicitante : Usuario
    {
        public UsuarioSolicitante():base()
        {
        }

        public Telefone Telefone { get; set; }
    }
}