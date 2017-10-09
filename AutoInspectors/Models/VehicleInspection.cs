using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace AutoInspectors.Models
{
    public class VehicleInspection
    {   
        [Key]
        public int VehicleID {get; set;}

        [Key]
        public int InspectionID {get; set;}

        public Vehicle Vehicle {get; set;}
        public Inspection Inspection {get; set;}

    } 
}
