using AutoMapper;

namespace Bussiness.AutoMappers
{
    internal static class Mapping
    {
        internal static IMapper EfMap()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapConfig());
            });
            return config.CreateMapper();
        }
    }
}