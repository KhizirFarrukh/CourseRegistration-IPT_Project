using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration_WinForm.data
{
    public class CourseLog
    {
        public Guid id { get; set; }
        public Guid courseID { get; set; }
        public Guid teacherID { get; set; }
        public Guid sectionID { get; set; }
        public int year { get; set; }
        public string status { get; set; }
    }
}
