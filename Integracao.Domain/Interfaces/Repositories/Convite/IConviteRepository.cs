using System.Collections.Generic;
using System.Threading.Tasks;
using Contmatic.Integracao.Domain.Entidades;
using Contmatic.Integracao.Domain.ObjetosValor;
using static Contmatic.Integracao.Domain.Enums.EConviteType;

namespace Contmatic.Integracao.Domain.Interfaces.Repositories
{
    public interface IConviteRepository
    {

        /// <summary>
        /// Cliente solicitante envia um convite de integração que será 
        /// visualizado pelo cliente convidado, usuário dentro dos sistemas vizinhos.
        /// </summary>
        /// <param name="convite">representa um convite</param>
        Task EnviarConvite(Convite convite);

        /// <summary>
        ///  Permite ao cliente covidado, dar o aceite ao convite.
        /// </summary>
        /// <param name="chave">chave que representa o convite entre convidado X solicitante</param>
        Task AceitarConvite(Chave chave);

        /// <summary>
        /// Permite ao cliente recusar o convite de integração de sistemas.
        /// </summary>
        /// <param name="chave">chave que representa o convite entre convidado X solicitante</param>
        Task RecusarConvite(Chave chave);

        /// <summary>
        /// Obtem os convites conforme filtro
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        Task<IEnumerable<Convite>> ObterConvitesAsync(ConviteFiltro filtro);

        /// <summary>
        /// Obtem Convite por Chave
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        Task<Convite> ObterPorChave(Chave chave);



    }
}