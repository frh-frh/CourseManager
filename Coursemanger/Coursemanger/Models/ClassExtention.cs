using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursemanger.Models
{
    public partial class Classes
    {
        public string TeacherName {
            get {
                if (!TeacherId.HasValue) {
                    return "";
                }

                 CourseManagerEntities db = new CourseManagerEntities();
                 var teacher = db.Teacheres.Where(t => t.Id == TeacherId.Value).FirstOrDefault();
                 if (teacher == null)
                 {
                     return "";
                 }
                return teacher.Name;
            }
        }
    }
}