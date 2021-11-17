using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgOdev.Models
{
    public class TextImage
    {
        [Key]
        public int gorselID { get; set; }

        public string gorselAdi { get; set; }
        public int? FKyaziID { get; set; }

        [ForeignKey("FKyaziID")]
        public virtual Text TextTextImageProp { get; set; }
    }
}
