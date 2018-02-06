using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class ClienteConvidado : Cliente
    {        
       private ClienteConvidado(CNPJ cNPJ, string razaoSocial, Codigo codigo, Apelido apelido, Email email)
        : base(cNPJ, razaoSocial, codigo, apelido, email)
        {

        }

        public static ClienteConvidado Factory(CNPJ cNPJ, string razaoSocial, Codigo codigo, Apelido apelido, Email email)
        {
            ClienteConvidado clienteSolicitante = new ClienteConvidado(cNPJ, razaoSocial, codigo, apelido, email);
            return clienteSolicitante;
        }
    }
}