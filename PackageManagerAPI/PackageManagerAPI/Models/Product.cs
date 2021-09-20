using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string ProductName { get; set; }

        [Column(TypeName = "float")]
        public float ProductPrice { get; set; }

        [Column(TypeName = "int")]
        public int ProductQuantity { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ProductQuantityUnit { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
