using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration_WinForm.data
{
    internal class CourseRegDetails
    {
        //"courseLogID": "e96f73ee-5836-46c7-add1-22682e47b954",
        //"courseCode": "CS-4091",
        //"courseTitle": "Final Year Project – I",
        //"courseType": "Core",
        //"courseCredHrs": 3,
        //"sectionDept": "BCS",
        //"semesterNo": 7,
        //"sectionChar": "B",
        //"teacherName": "Ms. Shaharbano"
        public Guid courseLogID { get; set; }
        public string courseCode { get; set; }
        public string courseTitle { get; set; }
        public string courseType { get; set; }
        public int courseCredHrs { get; set; }
        public string sectionDept { get; set; }
        public int semesterNo { get; set; }
        public string sectionChar { get; set; }
        public string teacherName { get; set; }
    }
}
