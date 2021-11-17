using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgOdev.Models
{
    public class HomePageViewModels
    {
        [Key]
        public int id { get; set; }
        public IEnumerable<Category> Kategori { get; set; }
        public IEnumerable<Text> Yazi { get; set; }
    }
}
