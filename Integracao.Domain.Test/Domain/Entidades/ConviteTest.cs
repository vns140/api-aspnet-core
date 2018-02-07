using Contmatic.Integracao.Domain.Entidades;
using Contmatic.Integracao.Domain.ObjetosValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Contmatic.Integracao.Domain.Shared.Enums.ETelefone;

namespace Integracao.Domain.Test
{
    [TestClass]
    public class ConviteTest
    {
        [TestMethod]
        public void DeveCriarUmConvite()
        {
           //Dados Solicitante
           CPF cpfSolicitante = CPF.Factory("33587499837");
           Nome nomeSolicitante = Nome.Factory("Vinicius","Silva");
           Telefone celularSolicitante = Telefone.Factory("55","11","969055218",TipoTelefone.Celular);
           Email emailSolicitante = Email.Factory("vns140@hotmail.com");
           Pessoa pessoaSolicitante = PessoaFisica.Factory(cpfSolicitante,nomeSolicitante,emailSolicitante,celularSolicitante);           
           Codigo codigoSolicitante = Codigo.Factory("17854");
           Apelido apelidoSolicitante = Apelido.Factory("VINI");           
           ClienteSolicitante clienteSolicitante = ClienteSolicitante.Factory(pessoaSolicitante,codigoSolicitante,apelidoSolicitante);
           
           //Dados Convidado
           CPF cpfConvidado = CPF.Factory("33587499837");
           Nome nomeConvidado = Nome.Factory("Vinicius","Silva");
           Telefone celularConvidado = Telefone.Factory("55","11","969055218",TipoTelefone.Celular);
           Email emailConvidado = Email.Factory("vns140@hotmail.com");
           Pessoa pessoaConvidado = PessoaFisica.Factory(cpfSolicitante,nomeSolicitante,emailSolicitante,celularSolicitante);           
           Codigo codigoConvidado = Codigo.Factory("17854");
           Apelido apelidoConvidado = Apelido.Factory("VINI");           
           ClienteConvidado clienteConvidado = ClienteConvidado.Factory(pessoaSolicitante,codigoSolicitante,apelidoSolicitante);
           
           Convite convite = Convite.Factory(clienteSolicitante,clienteConvidado);
           
        }
    }
}
