using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transystem.API.Models;
using Transystem.Domain.Entitys;

namespace Transystem.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Client, ClientModel>().ReverseMap();
            CreateMap<Address, AddressModel>().ReverseMap();
            //CreateMap<Palestrante, PalestranteDTO>()
            //    .ForMember(dest => dest.Eventos, opt =>
            //    {
            //        opt.MapFrom(src => src.PalestrantesEventos.Select(e => e.Evento));
            //    }).ReverseMap();

        }

    }
}
