using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CourseManager.Models
{
    public class ActionLinks
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Contorller { get; set; }
        [Required]
        [StringLength(20)]
        public string Action { get; set; }
    }
}
