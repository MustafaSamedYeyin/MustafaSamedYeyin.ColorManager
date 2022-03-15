using AutoMapper;
using Core.Entities;
using DTOs.Concrete.AuthDtos.UserDtos;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;

namespace Bussiness.AutoMappers
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<UserGenericDto,User>().ReverseMap();
        }
    }
}