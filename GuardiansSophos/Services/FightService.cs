using GuardiansSophos.Entities;
using GuardiansSophos.Repository;
using GuardiansSophos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace GuardiansSophos.Services
{
    public class FightService : IFightService
    {
        private readonly MongoDBContext _mongoDBContext;
        private readonly IMongoCollection<FightsResults> _FightCollection;
        private readonly ICommonService _commonService;
        public FightService(MongoDBContext mongoDBContext, ICommonService commonService)
        {
            _mongoDBContext = mongoDBContext;
            _FightCollection = _mongoDBContext.FightsResultsCollection();
            _commonService = commonService;
        }
        public async Task<List<FightsResults>> GetAll()
        {
            return await _commonService.GetAll(_FightCollection);
        }

        public async Task<FightsResults> GetById(string id)
        {
            return await _commonService.GetItemByIdAsync(_FightCollection, id);
        }
    }
}
