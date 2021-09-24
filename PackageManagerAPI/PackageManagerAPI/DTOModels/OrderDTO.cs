using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.DTOModels
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public string PackageId { get; set; }
        public string StatusShortHand { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int ItemCount { get; set; }
    }
}
