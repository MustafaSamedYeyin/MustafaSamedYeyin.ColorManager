using Core.Interfaces.Bussiness.GenericService;
using DTOs.Interfaces;

namespace Bussiness.GenericService
{
    public class GenericService<TDTO> : IGenericService<TDTO> where TDTO : IDto, new()
    {
        public Task<TDTO> Add(TDTO dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(TDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TDTO>> GetAll(TDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<TDTO> GetById(TDTO dto)
        {
            throw new NotImplementedException();
        }

        public TDTO Update(TDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}