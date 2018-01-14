using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("Categories Details")]
    public class GifNames
    {
        [Key]
        public int GifNames_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string GifName { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Categories Categories { get; set; }

        public override string ToString()
        {
            return GifName.ToString();
        }
    }
}
