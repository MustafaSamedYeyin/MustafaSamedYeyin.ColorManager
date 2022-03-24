using AutoMapper;
using Core.Entities;
using DTOs.Concrete.AuthDtos;
using DTOs.Concrete.AuthDtos.RoleDtos;
using DTOs.Concrete.AuthDtos.RoleDtos.CRUD;
using DTOs.Concrete.AuthDtos.UserDtos;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;
using DTOs.Concrete.ServiceDtos.CategoryDtos;
using DTOs.Concrete.ServiceDtos.ColorDtos;
using DTOs.Concrete.ServiceDtos.ColorDtos.CRUD;
using DTOs.Concrete.ServiceDtos.PalatteDtos;

namespace Bussiness.AutoMappers
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<UserGenericDto,User>().ReverseMap();
            CreateMap<RoleGenericDto,Role>().ReverseMap();
            CreateMap<ColorGenericDto, Color>().ReverseMap();
            CreateMap<CategoryGenericDto,Category>().ReverseMap();
            CreateMap<PalatteGenericDto,Palatte>().ReverseMap();


            CreateMap<GetRoleDto, Role>().ReverseMap();

            CreateMap<GetUserDto, User>().ReverseMap();

            CreateMap<ColorGenericDto, Color>().ReverseMap();
            CreateMap<RegisterDto,User>().ReverseMap();


        }
    }
}