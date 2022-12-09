using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration_WinForm.data
{
    public class Teacher
    {
        public Guid id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
