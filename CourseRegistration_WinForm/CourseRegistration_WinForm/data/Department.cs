using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CourseRegistration_WinForm.data
{
    public class Department
    {
        public Guid id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return code;
        }
    }
}
