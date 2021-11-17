using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgOdev.Models
{
    public class Category
    {
        [Key]
        public int kategoriID { get; set; }
        public string kategoriAdi { get; set; }
        public virtual ICollection<Text> TextCategory { get; set; }
    }
}
