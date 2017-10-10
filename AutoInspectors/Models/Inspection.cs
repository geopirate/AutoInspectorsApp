using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInspectors.Models
{
    public class Inspection
    {
        public int InspectionID { get; set; }

        [Display(Name = "DTC Code")]
        public string DTCCode { get; set; }

        [Display(Name = "Engine Oil")]
        public string EngineOil { get; set; }

        public string TransmissionFluid { get; set; }

        [Display(Name = "Coolant Level")]
        public string CoolantLevel { get; set; }

        [Display(Name = "Coolant PH")]
        public string CoolantPH { get; set; }

        [Display(Name = "Brake Fluid")]
        public string BrakeFluid { get; set; }

        [Display(Name = "Battery Load Test")]
        public string BatteryTest { get; set; }

        [Display(Name = "Alternator Test")]
        public string AlternatorTest { get; set; }

        [Display(Name = "Air Filter")]
        public string AirFilter { get; set; }

        public string Hoses { get; set; }

        public string Wires { get; set; }

        [Display(Name = "Front Brakes")]
        public string FrontBrakes { get; set; }

        [Display(Name = "Rear Brakes")]
        public string RearBrakes { get; set; }

        [Display(Name = "Tire Rotation")]
        public string TireRotation { get; set; }

        [Required]
        public int VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
