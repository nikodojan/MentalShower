using System;
using System.Text.Json.Serialization;

namespace MentalShower.Models
{
    /// <summary>
    /// Measurement class used as entity model and to return data in response to GET requests.
    /// Id property will not be returned.
    /// </summary>
    public class Measurement
    {
        [JsonIgnore]
        public string? Id { get; set; }
        [JsonPropertyName("zone")]
        public int Zone { get; set; }
        [JsonPropertyName("Temperature")]
        public int Temperature { get; set; }
        [JsonPropertyName("AirQuality")]
        public int AirQuality { get; set; }
        [JsonPropertyName("Humidity")]
        public int Humidity { get; set; }
        [JsonPropertyName("Timestamp")]
        public DateTime? TimeStamp { get; set; }

        public Measurement()
        {
            
        }

        /// <summary>
        /// Constructor to create a new Measurement object from a DTO.
        /// </summary>
        /// <param name="dto"></param>
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
