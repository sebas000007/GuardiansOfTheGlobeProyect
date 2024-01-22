using GuardiansSophos.Entities;

namespace GuardiansSophos.Services.Interfaces
{
    public interface IDiaryService
    {
        Task<List<Diary>> GetAll();
        Task<Diary> GetById(string id);
    }
}
