using System.ComponentModel.DataAnnotations;

namespace MentalShower.Models
{
    public class MeasurementDto
    { 
        [Range(1,16)]
        public int Zone { get; set; }
        [Range(1,6)]
        public int Temperature { get; set; }
        [Range(1, 6)]
        public int AirQuality { get; set; }
        [Range(1, 6)]
        public int Humidity { get; set; }
    }
}
