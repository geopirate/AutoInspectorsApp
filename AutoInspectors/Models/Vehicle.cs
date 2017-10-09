using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInspectors.Models
{
    public class Vehicle
    {
        [Key]
        public int ID { get; set; }
        public string VIN { get; set; }
        public string LicensePlate { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal EngineSize { get; set; }
        public string TransmissionType { get; set; }
    }
}
