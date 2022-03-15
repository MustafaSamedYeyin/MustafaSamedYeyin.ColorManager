using Bussiness.AutoMappers;
using Core.Entities.Interface;
using Core.Interfaces.Bussiness.GenericService;
using Data.EfCore.Context;
using DTOs.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bussiness.GenericService
{
    public class GenericService<TDTO,TEntity> : IGenericService<TDTO,TEntity> where TDTO : IDto, new() where TEntity : class,IEntity
    {
        private readonly ColorManagerContext _context;
        private readonly DbSet<TEntity> _dbset;

        public GenericService(ColorManagerContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }

        public async Task<TDTO> Add(TDTO dto)
        {
            await _dbset.AddAsync(Mapping.EfMap().Map<TEntity>(dto));
            return dto;
        }

        public void Delete(TDTO dto)
        {
            _dbset.Remove(Mapping.EfMap().Map<TEntity>(dto));
        }

        public async Task<IEnumerable<TDTO>> GetAll()
        {
            return Mapping.EfMap().Map<IEnumerable<TDTO>>(await _dbset.ToListAsync());
        }

        public async Task<TDTO> GetById(TDTO dto)
        {
            var entity =  await _dbset.FindAsync(Mapping.EfMap().Map<TEntity>(dto));
            if (entity!=null)
            {
                return Mapping.EfMap().Map<TDTO>(entity);
            }
            else
            {
                TDTO empty = new TDTO();
                return empty;
            }
        }

        public TDTO Update(TDTO dto)
        {
            _dbset.Update(Mapping.EfMap().Map<TEntity>(dto));
            return dto;
        }
    }
}