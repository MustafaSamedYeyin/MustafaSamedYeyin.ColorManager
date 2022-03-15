using Bussiness.GenericService;
using Core.Entities;
using Core.Interfaces.Bussiness.Services;
using Data.EfCore.Context;
using DTOs.Concrete.ServiceDtos.CategoryDtos;

namespace Bussiness.Services
{
    public class CategoryService : GenericService<CategoryGenericDto, Category>, ICategoryService
    {
        public CategoryService(ColorManagerContext context) : base(context)
        {
        }
    }
}