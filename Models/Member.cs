using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgOdev.Models
{
    public class Member:IdentityUser
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public virtual ICollection<Text> TextMember { get; set; }
        public virtual ICollection<Comment> CommentMember { get; set; }
    }
}
