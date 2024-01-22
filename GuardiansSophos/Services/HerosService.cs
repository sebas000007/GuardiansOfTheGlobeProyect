using GuardiansSophos.Entities;
using GuardiansSophos.Repository;
using GuardiansSophos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace GuardiansSophos.Services
{
    public class HerosService : IHeroesService
    {
        private readonly MongoDBContext _mongoDBContext;
        private readonly IMongoCollection<Heroes> _HerosCollection;
        private readonly ICommonService _commonService;
        public HerosService(MongoDBContext mongoDBContext, ICommonService commonService)
        {
            _mongoDBContext = mongoDBContext;
            _HerosCollection = _mongoDBContext.HeroesCollection();
            _commonService = commonService;
        }
        public async Task<List<Heroes>> GetAll()
        {
            return await _commonService.GetAll(_HerosCollection);
        }

        public async Task<Heroes> GetById(string id)
        {
            return await _commonService.GetItemByIdAsync(_HerosCollection, id);
        }
    }
}
