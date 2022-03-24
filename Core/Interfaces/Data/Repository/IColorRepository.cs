using Core.Entities;

namespace Core.Interfaces.Data.Repository
{
    public interface IColorRepository
    {
        Task<List<Color>> GetColorsByUserId(int id);

    }
}