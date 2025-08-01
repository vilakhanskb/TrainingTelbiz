using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResource.Entities
{
    public class ProductEntity
    {
        public string? CateID { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int PriceSale { get; set; }
        public int PriceImport { get; set; }
        public ImageURL Thumbnail { get; set; } = new();
        public StatusAtive Status { get; set; }
    }
}
