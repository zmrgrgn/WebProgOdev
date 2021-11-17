using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgOdev.Models
{
    public class Comment
    {
        [Key]
        public int yorumID { get; set; }

        public DateTime yorumTarih { get; set; }
        public string yorumIcerik { get; set; }
        public bool yorumAktifMi { get; set; }
        public int? FKyaziID { get; set; }
        [ForeignKey("FKyaziID")]
        public virtual Text TextCommentProp { get; set; }

        public string FKuyeID { get; set; }
        [ForeignKey("FKuyeID")]
        public virtual Member MemberCommentProp { get; set; }

    }
}
