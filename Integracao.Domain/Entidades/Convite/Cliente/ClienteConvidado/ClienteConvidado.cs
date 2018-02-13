using Contmatic.Integracao.Domain.ObjetosValor;

namespace Contmatic.Integracao.Domain.Entidades
{
    public class ClienteConvidado : Cliente
    {

        public ClienteConvidado()
        {
            
        }
        private ClienteConvidado(Pessoa pessoa, Codigo codigo, Apelido apelido)
          : base(codigo, apelido, pessoa)
        {

        }

        public static ClienteConvidado Factory(Pessoa pessoa, Codigo codigo, Apelido apelido)
        {
            ClienteConvidado clienteSolicitante = new ClienteConvidado(pessoa, codigo, apelido);
            return clienteSolicitante;
        }
    }
}