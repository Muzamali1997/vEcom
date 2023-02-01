using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vEcom.Models
{
    public class Brands
    {

        [Key]

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandLogo { get; set; }
        public string brandssss { get; set;}
    }
}
