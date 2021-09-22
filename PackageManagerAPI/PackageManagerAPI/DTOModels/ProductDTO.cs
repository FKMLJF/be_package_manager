using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.DTOModels
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
    }
}
