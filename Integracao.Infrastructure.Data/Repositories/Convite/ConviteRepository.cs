using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contmatic.Integracao.Domain.Entidades;
using Contmatic.Integracao.Domain.Interfaces.Repositories;
using Contmatic.Integracao.Domain.ObjetosValor;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using static Contmatic.Integracao.Domain.Enums.EConviteType;

namespace Contmatic.Integracao.Infrastructure.Data.Repositories
{
    public class ConviteRepository : IConviteRepository
    {
        Contexto _ctx;

        public ConviteRepository()
        {
            _ctx = new Contexto();
        }

        public async Task EnviarConviteAsync(Convite convite)
        {
            try
            {
                await _ctx.Convites.InsertOneAsync(convite);
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task AceitarConviteAsync(Chave chave)
        {
            try
            {
                await _ctx.Convites.UpdateOneAsync(
                                Builders<Convite>.Filter.Eq(o => o.Chave.Identificacao, chave.Identificacao),
                                Builders<Convite>.Update.Set(o => o.Status, EStatus.Ativo).Set(o => o.DataAceite, DateTime.Now));
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task RecusarConviteAsync(Chave chave)
        {
            try
            {
                await _ctx.Convites.UpdateOneAsync(
                                Builders<Convite>.Filter.Eq(o => o.Chave.Identificacao, chave.Identificacao),
                                Builders<Convite>.Update.Set(o => o.Status, EStatus.Recusado));
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task<IEnumerable<Convite>> ObterAsync(ConviteFiltro filtro)
        {
            try
            {
                var query = _ctx.Convites.AsQueryable();

                if (filtro.Status != null)
                    query = query.Where(c => c.Status == filtro.Status);

                if (filtro.ClienteConvidado != null && filtro.ClienteConvidado is PessoaFisica)
                    query = FiltroClienteConvidadoPessoaFisica(filtro, query);

                else if (filtro.ClienteConvidado != null && filtro.ClienteConvidado is PessoaJuridica)
                    query = FiltroClienteConvidadoPessoaJuridica(filtro, query);

                if (filtro.ClienteSolicitante != null && filtro.ClienteSolicitante is PessoaFisica)
                    query = FiltroClienteSolicitantePessoaFisica(filtro, query);

                else if (filtro.ClienteSolicitante != null && filtro.ClienteSolicitante is PessoaJuridica)
                    query = FiltroClienteSolicitantePessoaJuridica(filtro, query);

                return await query.Skip(filtro.Offset).Take(filtro.Limit).ToListAsync();
            }
            catch (Exception ex) { throw ex; }
        }

        #region auxiliares no filtro
        private static IMongoQueryable<Convite> FiltroClienteConvidadoPessoaFisica(ConviteFiltro filtro, IMongoQueryable<Convite> query)
        {

            string cpf = (filtro.ClienteConvidado as PessoaFisica).CPF.Identificacao;
            string primeiroNome = (filtro.ClienteConvidado as PessoaFisica).Nome.PrimeiroNome;
            string sobreNome = (filtro.ClienteConvidado as PessoaFisica).Nome.SobreNome;

            if (!String.IsNullOrEmpty(cpf))
            {
                query = query.Where(x => ((x.ClienteConvidado as Cliente).Pessoa as PessoaFisica).CPF.Identificacao == (filtro.ClienteConvidado as PessoaFisica).CPF.Identificacao);
            }

            if (!String.IsNullOrEmpty(primeiroNome))
            {
                query = query.Where(x => ((x.ClienteConvidado as Cliente).Pessoa as PessoaFisica).Nome.PrimeiroNome.ToUpper().Contains((filtro.ClienteConvidado as PessoaFisica).Nome.PrimeiroNome.ToUpper()));
            }

            if (!String.IsNullOrEmpty(sobreNome))
            {
                query = query.Where(x => ((x.ClienteConvidado as Cliente).Pessoa as PessoaFisica).Nome.PrimeiroNome.ToUpper().Contains((filtro.ClienteConvidado as PessoaFisica).Nome.PrimeiroNome.ToUpper()));
            }


            return query;
        }

        private static IMongoQueryable<Convite> FiltroClienteConvidadoPessoaJuridica(ConviteFiltro filtro, IMongoQueryable<Convite> query)
        {

            string cnpj = (filtro.ClienteConvidado as PessoaJuridica).CNPJ.Identificacao;
            string razaoSocial = (filtro.ClienteConvidado as PessoaJuridica).RazaoSocial;

            if (!String.IsNullOrEmpty(cnpj))
            {
                query = query.Where(x => ((x.ClienteConvidado as Cliente).Pessoa as PessoaJuridica).CNPJ.Identificacao == (filtro.ClienteConvidado as PessoaJuridica).CNPJ.Identificacao);
            }

            if (!String.IsNullOrEmpty(razaoSocial))
            {
                query = query.Where(x => ((x.ClienteConvidado as Cliente).Pessoa as PessoaJuridica).RazaoSocial.ToUpper().Contains((filtro.ClienteConvidado as PessoaJuridica).RazaoSocial.ToUpper()));
            }


            return query;
        }

        private static IMongoQueryable<Convite> FiltroClienteSolicitantePessoaFisica(ConviteFiltro filtro, IMongoQueryable<Convite> query)
        {
            if (filtro.ClienteSolicitante != null && filtro.ClienteSolicitante is PessoaFisica)
            {
                string cpf = (filtro.ClienteSolicitante as PessoaFisica).CPF.Identificacao;
                string primeiroNome = (filtro.ClienteSolicitante as PessoaFisica).Nome.PrimeiroNome;
                string sobreNome = (filtro.ClienteSolicitante as PessoaFisica).Nome.SobreNome;

                if (!String.IsNullOrEmpty(cpf))
                {
                    query = query.Where(x => ((x.ClienteSolicitante as Cliente).Pessoa as PessoaFisica).CPF.Identificacao == (filtro.ClienteSolicitante as PessoaFisica).CPF.Identificacao);
                }

                if (!String.IsNullOrEmpty(primeiroNome))
                {
                    query = query.Where(x => ((x.ClienteSolicitante as Cliente).Pessoa as PessoaFisica).Nome.PrimeiroNome.ToUpper().Contains((filtro.ClienteSolicitante as PessoaFisica).Nome.PrimeiroNome.ToUpper()));
                }

                if (!String.IsNullOrEmpty(sobreNome))
                {
                    query = query.Where(x => ((x.ClienteSolicitante as Cliente).Pessoa as PessoaFisica).Nome.PrimeiroNome.ToUpper().Contains((filtro.ClienteSolicitante as PessoaFisica).Nome.PrimeiroNome.ToUpper()));
                }
            }

            return query;
        }

        private static IMongoQueryable<Convite> FiltroClienteSolicitantePessoaJuridica(ConviteFiltro filtro, IMongoQueryable<Convite> query)
        {

            string cnpj = (filtro.ClienteSolicitante as PessoaJuridica).CNPJ.Identificacao;
            string razaoSocial = (filtro.ClienteSolicitante as PessoaJuridica).RazaoSocial;

            if (!String.IsNullOrEmpty(cnpj))
            {
                query = query.Where(x => ((x.ClienteSolicitante as Cliente).Pessoa as PessoaJuridica).CNPJ.Identificacao == (filtro.ClienteSolicitante as PessoaJuridica).CNPJ.Identificacao);
            }

            if (!String.IsNullOrEmpty(razaoSocial))
            {
                query = query.Where(x => ((x.ClienteSolicitante as Cliente).Pessoa as PessoaJuridica).RazaoSocial.ToUpper().Contains((filtro.ClienteSolicitante as PessoaJuridica).RazaoSocial.ToUpper()));
            }

            return query;
        }
        #endregion

        public async Task<Convite> ObterPorChaveAsync(Chave chave)
        {
            try
            {
                return await _ctx.Convites.Find(x => x.Chave.Identificacao == chave.Identificacao).FirstAsync();

            }
            catch (Exception ex) { throw ex; }
        }


    }
}