using GuardiansSophos.Entities;
using GuardiansSophos.Repository;
using GuardiansSophos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace GuardiansSophos.Services
{
    public class PatternsService : IPatternsService
    {
        private readonly MongoDBContext _mongoDBContext;
        private readonly IMongoCollection<Patterns> _PatternsCollection;
        private readonly ICommonService _commonService;
        public PatternsService(MongoDBContext mongoDBContext, ICommonService commonService)
        {
            _mongoDBContext = mongoDBContext;
            _PatternsCollection = _mongoDBContext.PatternsCollection();
            _commonService = commonService;
        }
        public async Task<List<Patterns>> GetAll()
        {
            return await _commonService.GetAll(_PatternsCollection);
        }

        public async Task<Patterns> GetById(string id)
        {
            return await _commonService.GetItemByIdAsync(_PatternsCollection, id);
        }
    }
}
