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
        [Required]
        public string VIN { get; set; }

        [Required]
        [Display(Name = "License Plate Number")]
        public string LicensePlate { get; set; }

        [Required]
        public int Mileage { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Engine Size")]
        public decimal EngineSize { get; set; }

        [Required]
        [Display(Name = "Transmission Type")]
        public string TransmissionType { get; set; }
    }
}
