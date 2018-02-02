using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class ClienteConvidado : Cliente
    {
        public ClienteConvidado() : base() { }

        private ClienteConvidado(string cNPJ, string razaoSocial, string codigo, string apelido, Email email)
        : base(cNPJ, razaoSocial, codigo, apelido, email)
        {

        }

        public static ClienteConvidado Factory(string cNPJ, string razaoSocial, string codigo, string apelido, Email email)
        {
            ClienteConvidado clienteSolicitante = new ClienteConvidado(cNPJ, razaoSocial, codigo, apelido, email);
            return clienteSolicitante;
        }
    }
}