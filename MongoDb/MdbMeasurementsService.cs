using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MentalShower.Models;
using MongoDB.Driver;

namespace MentalShower.MongoDb
{
    public class MdbMeasurementsService
    {
        private readonly IMongoCollection<Measurement> _measurements;

        public MdbMeasurementsService()
        {
            var settings = MongoClientSettings.FromConnectionString(Secrets.ConnectionString);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("MeasurementsDB");
            _measurements = database.GetCollection<Measurement>("Measurements");
        }

        public async Task<List<Measurement>> GetAsync() =>
            await _measurements.Find(_ => true).ToListAsync();

        public async Task CreateAsync(Measurement measurement) =>
            await _measurements.InsertOneAsync(measurement);
    }
}
