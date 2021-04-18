using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using teste_webmotors.Api.Dtos;
using teste_webmotors.Domain.Models;
using teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates.Entities;

namespace teste_webmotors.Api.AutoMapper
{
    public class AnuncioWebmotorsMapper : Profile
    {
        public AnuncioWebmotorsMapper()
        {
            CreateMap<AnuncioWebmotors, AnuncioWebmotorsCreateDto>().ReverseMap();
            CreateMap<AnuncioWebmotors, AnuncioWebmotorsUpdateDto>().ReverseMap();
        }
    }
}
