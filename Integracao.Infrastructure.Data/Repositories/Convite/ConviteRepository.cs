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

        public async Task EnviarConvite(Convite convite)
        {
            try
            {
                await _ctx.Convites.InsertOneAsync(convite);
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task AceitarConvite(Chave chave)
        {
            try
            {
                await _ctx.Convites.UpdateOneAsync(
                                Builders<Convite>.Filter.Eq(o => o.Chave.Identificacao, chave.Identificacao),
                                Builders<Convite>.Update.Set(o => o.Status, EStatus.Ativo));
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task RecusarConvite(Chave chave)
        {
            try
            {
                await _ctx.Convites.UpdateOneAsync(
                                Builders<Convite>.Filter.Eq(o => o.Chave.Identificacao, chave.Identificacao),
                                Builders<Convite>.Update.Set(o => o.Status, EStatus.Recusado));
            }
            catch (Exception ex) { throw ex; }
        }

        public Task<IEnumerable<Convite>> ObterConvites(ConviteFiltro filtro)
        {
            try
            {         
               /* var query =  _ctx.Convites.AsQueryable().Where(c => c.Status == filtro.Status);
                if(filtro.CNPJ != string.Empty)
                {
                    query = query.Aggregate()
                    .OfType<PessoaJuridica>().Where(c => c.ClienteConvidado.Pessoa as PessoaJuridica == )    
                }/* */
                return null;
            }
            catch (Exception ex) { throw ex; }
        }

        public Task<Convite> ObterPorChave(Chave chave)
        {
            throw new System.NotImplementedException();
        }


    }
}