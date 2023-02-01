using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vEcom.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string SKU { get; set; }
        public string PartNumber { get; set; }
        public string Title { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string Weight { get; set; }
        public string TaxStatus { get; set; }
        public string TaxClass { get; set; }
        public string StockStatus { get; set; }
        public float SalePrice { get; set; }
        public float SalePercent { get; set; }
        public float RegularPrice { get; set; }
        public string ImageUrl { get; set; }

        //Relationship
        public List<Categories> Category { get; set; }
        public List<Colors> Color { get; set; }


    }
}
