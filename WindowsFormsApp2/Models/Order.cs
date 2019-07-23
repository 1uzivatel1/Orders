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

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }


    }
}
