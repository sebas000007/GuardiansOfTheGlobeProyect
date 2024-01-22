using GuardiansSophos.Entities;

namespace GuardiansSophos.Services.Interfaces
{
    public interface IHeroesService
    {
        Task<List<Heroes>> GetAll();
        Task<Heroes> GetById(string id);
    }
}
