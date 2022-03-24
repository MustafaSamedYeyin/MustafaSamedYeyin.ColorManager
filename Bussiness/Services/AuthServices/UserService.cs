using Bussiness.AutoMappers;
using Bussiness.GenericService;
using Core.Entities;
using Core.Interfaces.Bussiness.Services.AuthServices;
using Core.Interfaces.Data.IUnitOfWork;
using Core.Interfaces.Data.Repository;
using Data.EfCore.Context;
using DTOs.Concrete.AuthDtos;
using DTOs.Concrete.AuthDtos.RoleDtos.CRUD;
using DTOs.Concrete.AuthDtos.UserDtos;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;

namespace Bussiness.Services.AuthServices
{
    public class UserService : GenericService<UserGenericDto,User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(ColorManagerContext context, IUserRepository userRepository, IUnitOfWork unitOfWork) : base(context)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateUserAsync(RegisterDto registerDto)
        {
            await _userRepository.CreateUserAsync(Mapping.EfMap().Map<User>(registerDto));
            await _unitOfWork.SaveChangesAsync();
            await _userRepository.AddToViewerRoleAsync(Mapping.EfMap().Map<User>(registerDto));
            await _unitOfWork.SaveChangesAsync();
        }

        public async  Task<GetUserDto> GetByEmailAsync(string Email)
        {
            var user = await _userRepository.GetByEmailAsync(Email);
            return Mapping.EfMap().Map<GetUserDto>(user);
        }

        public UserGenericDto GetByIdAsync(int id)
        {
            return Mapping.EfMap().Map<UserGenericDto>( _userRepository.GetByIdAsync(id));
        }

        public async Task<GetRoleDto> GetUserRoleByIdAsync(int userId)
        {
            return Mapping.EfMap().Map<GetRoleDto>(await _userRepository.GetUserRoleByIdAsync(userId));
        }
    }
}