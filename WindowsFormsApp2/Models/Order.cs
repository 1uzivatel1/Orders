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
    class Order
    {
        public Order()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}
