using Contmatic.Integracao.Domain.Entidades.Shared;
using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class ClienteSolicitante : Cliente
    {        
        private ClienteSolicitante(Pessoa pessoa, Codigo codigo, Apelido apelido)
        : base(codigo,apelido,pessoa)
        {

        }

        public static ClienteSolicitante Factory(Pessoa pessoa, Codigo codigo, Apelido apelido)
        {
            ClienteSolicitante clienteSolicitante = new ClienteSolicitante( pessoa,  codigo,  apelido);
            return clienteSolicitante;
        }
        

    }
}