using GuardiansSophos.Entities;
using GuardiansSophos.Entities.DBSettings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using static MongoDB.Driver.WriteConcern;

namespace GuardiansSophos.Repository
{
    public class MongoDBContext
    {
        private readonly IMongoCollection<Diary> _DiaryCollection;
        private readonly IMongoCollection<FightsResults> _FightsResultsCollection;
        private readonly IMongoCollection<Heroes> _HeroesCollection;
        private readonly IMongoCollection<Patterns> _PatternsCollection;
        private readonly IMongoCollection<Villain> _VillainCollection;

        public MongoDBContext(IOptions<MongoDBSettings> mongoDBSettings, IOptions<Collections> Collections)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            var database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _DiaryCollection = database.GetCollection<Diary>(Collections.Value.Diary);
            _FightsResultsCollection = database.GetCollection<FightsResults>(Collections.Value.FightsResults);
            _HeroesCollection = database.GetCollection<Heroes>(Collections.Value.Heroes);
            _PatternsCollection = database.GetCollection<Patterns>(Collections.Value.Patterns);
            _VillainCollection = database.GetCollection<Villain>(Collections.Value.Villain);
        }

        public IMongoCollection<Diary> DiaryCollection() => _DiaryCollection;
        public IMongoCollection<Heroes> HeroesCollection() => _HeroesCollection;
        public IMongoCollection<FightsResults> FightsResultsCollection() => _FightsResultsCollection;
        public IMongoCollection<Patterns> PatternsCollection() => _PatternsCollection;
        public IMongoCollection<Villain> VillainCollection() => _VillainCollection;
    }

}
