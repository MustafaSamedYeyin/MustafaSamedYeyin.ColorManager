using Core.Entities;
using System;

namespace Core.Interfaces.Data.Repository
{
    public interface IRoleRepository
    {
        Task<Role> CreateRole(Role role);
    }
}
