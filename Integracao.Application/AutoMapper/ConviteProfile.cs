using AutoMapper;
using Contmatic.Integracao.Application.Models;
using Contmatic.Integracao.Domain.Entidades;

namespace Integracao.Application.AutoMapper
{
    public class ConviteProfile : Profile
    {
        public ConviteProfile()
        {
            CreateMap<Convite, ConviteModel>();
        }
    }
}