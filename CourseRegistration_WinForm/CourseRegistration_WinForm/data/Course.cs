using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration_WinForm.data
{
    public class Course
    {
        public Guid id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public Guid deptID { get; set; }
        public int creditHours { get; set; }

        public override string ToString()
        {
            return code + " | " + name;
        }
    }
}
