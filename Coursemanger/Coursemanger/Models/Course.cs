using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursemanger.Models
{
    public class Course
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(20)]
        public Nullable<int> CourseId { get; set; }
    }
}