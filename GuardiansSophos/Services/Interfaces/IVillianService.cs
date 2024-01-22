using GuardiansSophos.Entities;

namespace GuardiansSophos.Services.Interfaces
{
    public interface IVillianService
    {
        Task<List<Villain>> GetAll();
        Task<Villain> GetById(string id);
    }
}
