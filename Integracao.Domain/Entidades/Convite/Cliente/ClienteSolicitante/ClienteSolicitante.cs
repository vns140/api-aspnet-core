using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class ClienteSolicitante : Cliente
    {
        private ClienteSolicitante(CNPJ cNPJ, string razaoSocial, Codigo codigo, Apelido apelido, Email email)
        : base(cNPJ, razaoSocial, codigo, apelido, email)
        {

        }

        public static ClienteSolicitante Factory(CNPJ cNPJ, string razaoSocial, Codigo codigo, Apelido apelido, Email email)
        {
            ClienteSolicitante clienteSolicitante = new ClienteSolicitante(cNPJ, razaoSocial, codigo, apelido, email);
            return clienteSolicitante;
        }
        

    }
}