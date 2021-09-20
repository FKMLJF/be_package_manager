using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string PackageId { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string StatusShortHand { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Status { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
        public User User { get; set; }

    }
}
