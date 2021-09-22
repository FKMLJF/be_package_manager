using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.DTOModels
{
    public class OrderDetailDTO
    {
        public int OrderId { get; set; }
        public string PackageId { get; set; }
        public string StatusShortHand { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public List<ProductDTO> Products { get; set; }
    }
}
