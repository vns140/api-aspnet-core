using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Contmatic.Integracao.Domain.Entidades;
using Contmatic.Integracao.Domain.ObjetosValor;
using Contmatic.Integracao.Infrastructure.Data;
using Contmatic.Integracao.Infrastructure.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Contmatic.Integracao.Domain.Enums.EConviteType;
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
            CPF cpfSolicitante = CPF.Factory("11111111111");
            Nome nomeSolicitante = Nome.Factory("Homero", "Silva");
            Telefone celularSolicitante = Telefone.Factory(55, 11, 969055218, TipoTelefone.Celular);
            Email emailSolicitante = Email.Factory("advhomero@hotmail.com");
            Pessoa pessoaSolicitante = PessoaFisica.Factory(cpfSolicitante, nomeSolicitante, emailSolicitante, celularSolicitante);
            Codigo codigoSolicitante = Codigo.Factory("1232");
            Apelido apelidoSolicitante = Apelido.Factory("MERAO");
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
            await conviteRepo.EnviarConviteAsync(convite);
        }

        [TestMethod]
        public async Task DeveAceitarUmConvite()
        {
            Chave chave = Chave.Factory("BC695B93A14648E59BB3F403BCA178C3");
            ConviteRepository conviteRepo = new ConviteRepository();
            await conviteRepo.AceitarConviteAsync(chave);
        }

        [TestMethod]
        public async Task DeveRecusarUmConvite()
        {
            Chave chave = Chave.Factory("ACB50A784D9B4A688149CEBB72199DBE");
            ConviteRepository conviteRepo = new ConviteRepository();
            await conviteRepo.RecusarConviteAsync(chave);
        }

        [TestMethod]
        public async Task DeveBuscarPorChave()
        {
            Chave chave = Chave.Factory("BC695B93A14648E59BB3F403BCA178C3");
            ConviteRepository conviteRepo = new ConviteRepository();
            var convite = await conviteRepo.ObterPorChaveAsync(chave);
        }

        [TestMethod]
        public async Task DeveBuscarPeloFiltroStatus()
        {
            ConviteFiltro filtro = ConviteFiltro.Factory(null, null,
            EStatus.Pendente, 10, 0);

            ConviteRepository conviteRepo = new ConviteRepository();
            var convite = await conviteRepo.ObterAsync(filtro);
        }

        [TestMethod]
        public async Task DeveBuscarPeloFiltroClienteConvidado()
        {
            PessoaFisica clienteConvidado = PessoaFisica.Factory(CPF.Factory(""), Nome.Factory("Vi", ""), Email.Factory(""), Telefone.Factory(0,0,0,TipoTelefone.Celular));
            ConviteFiltro filtro = ConviteFiltro.Factory(clienteConvidado, null, null, 10, 0);


            ConviteRepository conviteRepo = new ConviteRepository();
            var convite = await conviteRepo.ObterAsync(filtro);
        }
    }
}
