using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vEcom.Models
{
    public class VehModels
    {
        [Key]
        public int ModelId { get; set; }
        public string ModelName { get; set; }
    }
}
