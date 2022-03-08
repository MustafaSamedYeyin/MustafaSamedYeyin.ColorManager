using DTOs.Interfaces;

namespace Core.Interfaces.Bussiness.GenericService
{
    public interface IGenericService<TDTO> where TDTO : IDto,new()
    {
        Task<TDTO> Add(TDTO dto);
        TDTO Update(TDTO dto);
        void Delete(TDTO dto);
        Task<TDTO> GetById(TDTO dto);
        Task<IEnumerable<TDTO>> GetAll(TDTO dto);
    }
}