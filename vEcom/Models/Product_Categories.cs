using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vEcom.Models
{
    public class Product_Categories
    {
        public int ProductId { get; set; }
        public Products Product { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
    }
}
