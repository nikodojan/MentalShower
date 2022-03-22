using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MentalShower.Models
{
    /// <summary>
    /// DTO used for POST request to the API
    /// </summary>
    public class MeasurementDto
    {
        [JsonPropertyName("zone")]
        [Range(1,16)]
        public int Zone { get; set; }
        [JsonPropertyName("Temperature")]
        [Range(1,6)]
        public int Temperature { get; set; }
        [JsonPropertyName("AirQuality")]
        [Range(1, 6)]
        public int AirQuality { get; set; }
        [JsonPropertyName("Humidity")]
        [Range(1, 6)]
        public int Humidity { get; set; }
    }
}
