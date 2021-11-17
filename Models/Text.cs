using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgOdev.Models
{
    public class Text
    {
        [Key]
        public int yaziID { get; set; }

        public string yaziBaslik { get; set; }
        public DateTime yaziTarih { get; set; }
        public string yaziIcerik { get; set; }
        public virtual ICollection<TextImage> TextImageText { get; set; }
        public virtual ICollection<Comment> CommentText { get; set; }
        public int? FKkategoriID { get; set; }
        [ForeignKey("FKkategoriID")]
        public virtual Category CategoryTextProp { get; set; }
        public string FKuyeID { get; set; }
        [ForeignKey("FKuyeID")]
        public virtual Member MemberTextProp { get; set; }
    }
}
