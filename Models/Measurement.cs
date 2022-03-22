using System;
using System.Text.Json.Serialization;

namespace MentalShower.Models
{
    public class Measurement
    {
        [JsonIgnore]
        public string? Id { get; set; }
        public int Zone { get; set; }
        public int Temperature { get; set; }
        public int AirQuality { get; set; }
        public int Humidity { get; set; }
        public DateTime? TimeStamp { get; set; }

        public Measurement()
        {
            
        }

        public Measurement(MeasurementDto dto)
        {
            Zone = dto.Zone;
            Temperature = dto.Temperature;
            AirQuality = dto.AirQuality;
            Humidity = dto.Humidity;
            Id = Guid.NewGuid().ToString();
            TimeStamp = DateTime.Now;
        }
    }
}
