using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public virtual List<GifNames> GifNames { get; set; } = new List<GifNames>();

        public override string ToString()
        {
            return CategoryName.ToString();
        }
    }
}
