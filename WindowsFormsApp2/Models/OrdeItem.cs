using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Table("OrderItems")]
    class OrderItem
    {
        public OrderItem()
        {
            this.Orders = new HashSet<Order>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string ItemName  { get { return Product.Name; }  private set { } }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double ItemPrize { get { return Quantity * Product.Prize; } private set { } }
        public int Stredisko { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
