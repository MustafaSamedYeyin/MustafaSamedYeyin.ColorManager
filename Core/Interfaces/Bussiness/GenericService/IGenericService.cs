using Core.Entities.Interface;
using DTOs.Interfaces;

namespace Core.Interfaces.Bussiness.GenericService
{
    public interface IGenericService<TDTO,TEntity> where TDTO : IDto,new() where TEntity : class,IEntity
    {
        Task<TDTO> Add(TDTO dto);
        TDTO Update(TDTO dto);
        void Delete(TDTO dto);
        Task<TDTO> GetById(TDTO dto);
        Task<IEnumerable<TDTO>> GetAll();
    }
}