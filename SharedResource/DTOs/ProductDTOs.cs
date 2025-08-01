using SharedResource.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResource.DTOs
{
    public class ProductDTOs : ProductEntity
    {
        public string? ID { get; set; }
    }
}
