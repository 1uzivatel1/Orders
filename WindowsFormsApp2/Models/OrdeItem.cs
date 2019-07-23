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

        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }

        [Required]
        public int Quantity { get; set; }

        public double ItemPrize { get; set; }
  
        public int Stredisko { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        private string itemName;
        private double itemPrize;

    }
}
