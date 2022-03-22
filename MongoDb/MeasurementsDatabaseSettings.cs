namespace MentalShower.MongoDb
{
    public class MeasurementsDatabaseSettings
    {
        public string ConnectionString { get; set; } = null;
        public string DatabaseName { get; set; } = null;
        public string BookCollectionName { get; set; } = null;
    }
}
