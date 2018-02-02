using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class ClienteSolicitante : Cliente
    {
        private ClienteSolicitante(string cNPJ, string razaoSocial, string codigo, string apelido, Email email)
        : base(cNPJ, razaoSocial, codigo, apelido, email)
        {

        }

        public static ClienteSolicitante Factory(string cNPJ, string razaoSocial, string codigo, string apelido, Email email)
        {
            ClienteSolicitante clienteSolicitante = new ClienteSolicitante(cNPJ, razaoSocial, codigo, apelido, email);
            return clienteSolicitante;
        }
        

    }
}