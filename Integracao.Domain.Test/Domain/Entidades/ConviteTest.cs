using Contmatic.Integracao.Domain.Entidades;
using Contmatic.Integracao.Domain.ObjetosValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Integracao.Domain.Test
{
    [TestClass]
    public class ConviteTest
    {
        [TestMethod]
        public void DeveCriarUmConvite()
        {
           //Solicitante do convite
           Email emailSolicitante = Email.Factory("vns140@hotmail.com");
           ClienteSolicitante clienteSolicitante =  ClienteSolicitante.Factory("12572857000165","HIGH PERFECTION LTDA","21789","HIGH",emailSolicitante);
           
           //Solicitante do convite
           Email emailConvidado = Email.Factory("jose@hotmail.com");
           ClienteConvidado clienteConvidado =  ClienteConvidado.Factory("33587499837","VINICIUS CONTABILIDADE","21789","HIGH",emailConvidado);

           Convite convite = Convite.Factory(clienteSolicitante,clienteConvidado);
        }
    }
}
