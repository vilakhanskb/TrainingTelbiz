using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResource.Entities
{
    public class ExchangeEntity
    {
        public string? Currency { get; set; }
        public double Rate { get; set; }
        public string? Symbol { get; set; }
        public StatusAtive Status { get; set; }
    }
}
