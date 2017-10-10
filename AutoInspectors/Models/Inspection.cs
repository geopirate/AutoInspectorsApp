using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInspectors.Models
{   
    public class Inspection
    {
<<<<<<< HEAD
        public int ID { get; set; }
        
        [StringLength(100)]
=======
        public int InspectionID { get; set; }

>>>>>>> unit-tests
        [Display(Name = "DTC Code")]
        public string DTCCode { get; set; }

        [StringLength(100)]
        [Display(Name = "Engine Oil")]
        public string EngineOil { get; set; }
<<<<<<< HEAD
        
        [StringLength(100)]
        [Display(Name = "Transmission Oil")]
        public string Transmission { get; set; }
=======

        public string TransmissionFluid { get; set; }
>>>>>>> unit-tests

        [StringLength(100)]
        [Display(Name = "Coolant Level")]
        public string CoolantLevel { get; set; }

        [StringLength(100)]
        [Display(Name = "Coolant PH")]
        public string CoolantPH { get; set; }

        [StringLength(100)]
        [Display(Name = "Brake Fluid")]
        public string BrakeFluid { get; set; }

        [StringLength(100)]
        [Display(Name = "Battery Load Test")]
        public string BatteryTest { get; set; }

        [StringLength(100)]
        [Display(Name = "Alternator Test")]
        public string AlternatorTest { get; set; }

        [StringLength(100)]
        [Display(Name = "Air Filter")]
        public string AirFilter { get; set; }

        [StringLength(100)]
        [Display(Name = "Hoses")]
        public string Hoses { get; set; }

        [StringLength(100)]
        [Display(Name = "Wires")]
        public string Wires { get; set; }

        [StringLength(200)]
        [Display(Name = "Front Brakes")]
        public string FrontBrakes { get; set; }

        [StringLength(200)]
        [Display(Name = "Rear Brakes")]
        public string RearBrakes { get; set; }

        [StringLength(100)]
        [Display(Name = "Tire Rotation")]
        public string TireRotation { get; set; }

        [Required]
        public int VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
