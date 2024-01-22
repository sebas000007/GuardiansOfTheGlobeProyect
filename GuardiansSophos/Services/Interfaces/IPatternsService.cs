using GuardiansSophos.Entities;

namespace GuardiansSophos.Services.Interfaces
{
    public interface IPatternsService
    {
        Task<List<Patterns>> GetAll();
        Task<Patterns> GetById(string id);
    }
}
