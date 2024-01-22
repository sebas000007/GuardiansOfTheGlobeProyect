using GuardiansSophos.Entities;
using GuardiansSophos.Repository;
using GuardiansSophos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace GuardiansSophos.Services
{
    public class DiaryService : IDiaryService
    {
        private readonly MongoDBContext _mongoDBContext;
        private readonly IMongoCollection<Diary> _DiaryCollection;
        private readonly ICommonService _commonService;
        public DiaryService(MongoDBContext mongoDBContext, ICommonService commonService)
        {
            _mongoDBContext = mongoDBContext;
            _DiaryCollection = _mongoDBContext.DiaryCollection();
            _commonService = commonService;
        }
        public async Task<List<Diary>> GetAll()
        {
            return await _commonService.GetAll(_DiaryCollection);
        }

        public async Task<Diary> GetById(string id)
        {
            return await _commonService.GetItemByIdAsync(_DiaryCollection, id);
        }
    }
}
