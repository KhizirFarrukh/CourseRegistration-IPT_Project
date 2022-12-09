using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration_WinForm.data
{
    public class Section
    {
        public Guid id { get; set; }
        public Guid deptID { get; set; }
        public char postfixCharacter { get; set; }
        public int semesterNo { get; set; }
    }
}
