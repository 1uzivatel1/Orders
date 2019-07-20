using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Table("Dodavatels")]
    class Dodavatel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Nespravný formát telefonního čísla")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Nesprávný formát emailové adresy")]
        public string Email { get; set; }
        public virtual List<Product> Produkts { get; set; }
    }
}
