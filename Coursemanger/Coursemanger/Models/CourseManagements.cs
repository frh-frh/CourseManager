//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coursemanger.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class CourseManagements
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public int ClassId { get; set; }
        [StringLength(50)]
        public int CourseId { get; set; }
        [StringLength(50)]
        public int TeacherId { get; set; }

        public object Name { get; set; }
    }
}
