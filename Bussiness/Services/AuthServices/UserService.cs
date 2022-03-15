using Bussiness.AutoMappers;
using Bussiness.GenericService;
using Core.Entities;
using Core.Interfaces.Bussiness.Services.AuthServices;
using Core.Interfaces.Data.Repository;
using Data.EfCore.Context;
using DTOs.Concrete.AuthDtos.UserDtos;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;

namespace Bussiness.Services.AuthServices
{
    public class UserService : GenericService<UserGenericDto,User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(ColorManagerContext context, IUserRepository userRepository) : base(context)
        {
            _userRepository = userRepository;
        }

        public async Task<GetUserDto> GetById(int id)
        {
            return Mapping.EfMap().Map<GetUserDto>(await _userRepository.GetByIdAsync(id)) ;
        }

    }
}