using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vEcom.Models
{
    public class Vehicles
    {
        [Key]
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
    }
}
