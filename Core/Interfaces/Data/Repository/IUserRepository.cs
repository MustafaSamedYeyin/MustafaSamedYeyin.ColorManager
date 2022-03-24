using System;
using Core.Entities;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;

namespace Core.Interfaces.Data.Repository
{
    public interface IUserRepository
    {
        User GetByIdAsync(int id);
        Task<User> GetByUserNameAsync(string Email);
        Task<bool> ChechUserExistAsync(User user);
        Task AddToAdminRoleAsync(User user);
        Task AddToModRoleAsync(User user);
        Task AddToDesignerRoleAsync(User user);
        Task AddToViewerRoleAsync(User user);
        Task<User> GetByEmailAsync(string email);
        Task<User> CreateUserAsync(User user);
        Task<Role> GetUserRoleByIdAsync(int userId);
    }
}
