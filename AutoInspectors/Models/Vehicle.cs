using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoInspectors.Models
{   
    //This is the Vehical model with validation
    public class Vehicle
    {
        [Key]
        public int VehicleID { get; set; }
        [StringLength(17, MinimumLength = 2, ErrorMessage = "Please enter a valid VIN")] 
        [Required]
        public string VIN { get; set; }
        
        [StringLength(5, MinimumLength = 2)]
        [Required]
        [Display(Name = "License Plate Number")]
        public string LicensePlate { get; set; }
        
        [Range(1, 300000)]
        [Required]
        public int Mileage { get; set; }
       
        [Range(1900, 2100)]
        [Required]
        public int Year { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Please enter a valid MAKE")]
        [Required]
        public string Make { get; set; }
       
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space!")]
        [Required]
        public string Model { get; set; }
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space!")]
        [Required]
        [Display(Name = "Engine Size")]
        public string EngineSize { get; set; }

        //No validation needed, it is a drop down option.
        [Required]
        [Display(Name = "Transmission Type")]
        public string TransmissionType { get; set; }

        List<Inspection> Inspections { get; set; }
    }
}
