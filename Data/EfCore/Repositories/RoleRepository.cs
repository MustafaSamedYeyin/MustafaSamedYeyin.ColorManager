using Core.Entities;
using Core.Interfaces.Data.Repository;
using Data.EfCore.Context;

namespace Data.EfCore.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ColorManagerContext _colorManagerContext;

        public RoleRepository(ColorManagerContext colorManagerContext)
        {
            _colorManagerContext = colorManagerContext;
        }

        public async Task<Role> CreateRole(Role role)
        {
            await _colorManagerContext.Roles!.AddAsync(role);
            return role;
        }
    }
}