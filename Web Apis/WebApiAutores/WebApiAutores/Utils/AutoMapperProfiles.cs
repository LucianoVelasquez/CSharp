using AutoMapper;
using WebApiAutores.DTOS;
using WebApiAutores.Entidades;

namespace WebApiAutores.Utils
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AutorCreacionDTO, Autor>();
            CreateMap<Autor, AutorDTO>();
        }
    }
}
