using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Table("Orders")]
    class OrderItem
    {

            [Key]
            public int Id { get; set; }
            public int Stredisko { get; set; }
            [Required]
            public int Quantity { get; set; }
            [Required]
            public virtual Product P { get; set; }
            [Required]
            public double ItemPrize { get { return Quantity * P.Prize; } }

    }
}
