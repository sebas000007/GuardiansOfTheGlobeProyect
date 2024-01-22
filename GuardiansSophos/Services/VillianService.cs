using GuardiansSophos.Entities;
using GuardiansSophos.Repository;
using GuardiansSophos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace GuardiansSophos.Services
{
    public class VillianService : IVillianService
    {
        private readonly MongoDBContext _mongoDBContext;
        private readonly IMongoCollection<Villain> _VilalinCollection;
        private readonly ICommonService _commonService;
        public VillianService(MongoDBContext mongoDBContext, ICommonService commonService)
        {
            _mongoDBContext = mongoDBContext;
            _VilalinCollection = _mongoDBContext.VillainCollection();
            _commonService = commonService;
        }
        public async Task<List<Villain>> GetAll()
        {
            return await _commonService.GetAll(_VilalinCollection);
        }

        public async Task<Villain> GetById(string id)
        {
            return await _commonService.GetItemByIdAsync(_VilalinCollection, id);
        }
    }
}
