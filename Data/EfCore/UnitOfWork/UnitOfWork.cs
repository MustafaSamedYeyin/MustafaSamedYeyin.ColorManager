using Core.Interfaces.Data.IUnitOfWork;
using Data.EfCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EfCore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ColorManagerContext _colorManagerContext;
        public UnitOfWork(ColorManagerContext colorManagerContext)
        {
            _colorManagerContext = colorManagerContext;
        }
        public void SaveChanges()
        {
            _colorManagerContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _colorManagerContext.SaveChangesAsync();
        }
    }
}
