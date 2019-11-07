using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImageTest.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoType { get; set; }
        [Display(Name ="用户名")]
        public string UserName { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }

    }
}
