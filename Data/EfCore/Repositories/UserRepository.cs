using Core.Entities;
using Core.Interfaces.Data.Repository;
using Data.EfCore.Context;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;

namespace Data.EfCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ColorManagerContext _context;

        public UserRepository(ColorManagerContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}