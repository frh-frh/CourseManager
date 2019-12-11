using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursemanger.Models
{
    public partial class Users
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "用户账号")]

        public string Account {get ;set ; }

        [Required]
        [StringLength(20)]
        [Display(Name = "用户名")]

        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "用户密码")]
        [DataType(DataType.Password)]

        public String Password { get; set; }
    }
}