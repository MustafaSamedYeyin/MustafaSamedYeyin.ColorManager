using Core.Entities;
using Core.Interfaces.Data.Repository;
using Core.StringValues;
using Data.EfCore.Context;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;
using Microsoft.EntityFrameworkCore;

namespace Data.EfCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ColorManagerContext _context;

        public UserRepository(ColorManagerContext context)
        {
            _context = context;
        }

        public async Task AddToAdminRoleAsync(User user)
        {
            var findedUser = await _context.Users.FindAsync(user.Id);
            var role = await _context.Roles.Where(i => i.Name == RoleValues.Admin).FirstOrDefaultAsync();
            if (findedUser != null)
            {
                await _context.UserRoles.AddAsync(new UserRole()
                {
                    RoleId = role.Id,
                    Role = role,
                    User = findedUser,
                    UserId = user.Id
                });
            }
        }

        public Task AddToDesignerRoleAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task AddToModRoleAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task AddToViewerRoleAsync(User user)
        {
            var findedUser = await _context.Users.Where(i=> i.Email == user.Email).FirstOrDefaultAsync();
            var role = await _context.Roles.Where(i => i.Name == RoleValues.Viewer).FirstOrDefaultAsync();
            await _context.UserRoles.AddAsync(new UserRole()
            {
                RoleId = role.Id,
                //Role = role,
                //User = findedUser,
                UserId = findedUser.Id
            });
        }

        public Task<bool> ChechUserExistAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await _context.AddAsync(user);
            return user;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            var user = await _context.Users.Where(i => i.Email == email).FirstOrDefaultAsync();
            return user;
        }

        public  User GetByIdAsync(int id)
        {
            var user =  _context.Users.Find(id);
            return user;
        }

        public Task<User> GetByUserNameAsync(string Email)
        {
            throw new NotImplementedException();
        }

        public async Task<Role> GetUserRoleByIdAsync(int userId)
        {

            var role = await _context.Roles.Include(i => i.UserRoles.Where(i => i.UserId == userId)).Select(i => new Role
            {
                Name = i.Name
            }).FirstOrDefaultAsync();
            return role;
        }
    }
}