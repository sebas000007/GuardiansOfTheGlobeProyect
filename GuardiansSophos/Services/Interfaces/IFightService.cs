using GuardiansSophos.Entities;

namespace GuardiansSophos.Services.Interfaces
{
    public interface IFightService
    {
        Task<List<FightsResults>> GetAll();
        Task<FightsResults> GetById(string id);
    }
}
