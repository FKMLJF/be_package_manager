using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PackageManagerAPI.Models
{
    public class User
    {  
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Password { get; set; }
        public List<Order> Orders { get; set; }

    }
}
