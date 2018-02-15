using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Contmatic.Integracao.Domain.Entidades;
using Contmatic.Integracao.Domain.ObjetosValor;
using Contmatic.Integracao.Infrastructure.Data;
using Contmatic.Integracao.Infrastructure.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Contmatic.Integracao.Domain.Shared.Enums.ETelefone;

namespace Integracao.Infrastructure.Data.Test
{
    [TestClass]
    public class ConviteRepositoryTest
    {
        [TestMethod]
        public async Task DeveEnviarUmConviteAsync()
        {

            ConviteRepository conviteRepo = new ConviteRepository();

            //Dados Solicitante
            CPF cpfSolicitante = CPF.Factory("33587499837");
            Nome nomeSolicitante = Nome.Factory("Vinicius", "Silva");
            Telefone celularSolicitante = Telefone.Factory(55, 11, 969055218, TipoTelefone.Celular);
            Email emailSolicitante = Email.Factory("vns140@hotmail.com");
            Pessoa pessoaSolicitante = PessoaFisica.Factory(cpfSolicitante, nomeSolicitante, emailSolicitante, celularSolicitante);
            Codigo codigoSolicitante = Codigo.Factory("17854");
            Apelido apelidoSolicitante = Apelido.Factory("VINI");
            ClienteSolicitante clienteSolicitante = ClienteSolicitante.Factory(pessoaSolicitante, codigoSolicitante, apelidoSolicitante);

            //Dados Convidado
            CPF cpfConvidado = CPF.Factory("33587499837");
            Nome nomeConvidado = Nome.Factory("Vinicius", "Silva");
            Telefone celularConvidado = Telefone.Factory(55, 11, 969055218, TipoTelefone.Celular);
            Email emailConvidado = Email.Factory("vns140@hotmail.com");
            Pessoa pessoaConvidado = PessoaFisica.Factory(cpfSolicitante, nomeSolicitante, emailSolicitante, celularSolicitante);
            Codigo codigoConvidado = Codigo.Factory("17854");
            Apelido apelidoConvidado = Apelido.Factory("VINI");
            ClienteConvidado clienteConvidado = ClienteConvidado.Factory(pessoaSolicitante, codigoSolicitante, apelidoSolicitante);

            Convite convite = Convite.Factory(clienteSolicitante, clienteConvidado);
            await conviteRepo.EnviarConvite(convite);
        }

        [TestMethod]
        public async Task DeveAceitarUmConvite()
        {
            Chave chave = Chave.Factory("ACB50A784D9B4A688149CEBB72199DBE");
            ConviteRepository conviteRepo = new ConviteRepository();
            await conviteRepo.AceitarConvite(chave);
        }

        [TestMethod]
        public async Task DeveRecusarUmConvite()
        {
            Chave chave = Chave.Factory("ACB50A784D9B4A688149CEBB72199DBE");
            ConviteRepository conviteRepo = new ConviteRepository();
            await conviteRepo.RecusarConvite(chave);
        }

        [TestMethod]
        public async Task DeveBuscarPorChave()
        {
            Chave chave = Chave.Factory("BC695B93A14648E59BB3F403BCA178C3");
            ConviteRepository conviteRepo = new ConviteRepository();
            var convite = await conviteRepo.ObterPorChave(chave);
        }

        [TestMethod]
        public async Task DeveBuscarPeloFiltro()
        {
            //ConviteFiltro filtro = new ConviteFiltro();
            
            Chave chave = Chave.Factory("BC695B93A14648E59BB3F403BCA178C3");
            ConviteRepository conviteRepo = new ConviteRepository();
            var convite = await conviteRepo.ObterPorChave(chave);
        }
    }
}
