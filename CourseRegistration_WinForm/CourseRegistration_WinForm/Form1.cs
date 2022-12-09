using CourseRegistration_WinForm.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CourseRegistration_WinForm
{
    public partial class Form1 : Form
    {
        List<CourseRegDetails> courseRegDetails;
        public Form1()
        {
            InitializeComponent();
            InitCoursesTable();
            RefreshData();
        }
        private void InitCoursesTable()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            courseRegTable.Columns.Add(btn);
            btn.HeaderText = "Remove";
            btn.Text = "Remove";
            btn.Name = "removeEntry";
            btn.UseColumnTextForButtonValue = true;
            courseRegTable.CellClick += new DataGridViewCellEventHandler(courseRegTable_CellContentClick);
        }
        private void RefreshData()
        {
            EmptyCourseRegTable();
            GetDataFromAPIs();
            courseDropdown.Items.Clear();
            clearSectionData();
        }
        private void GetDataFromAPIs()
        {
            getDepartments();
            getTeachers();
            getRegistrationCourses();
        }
        private void getTeachers()
        {
            teacherDropdown.Items.Clear();

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create
            (string.Format("https://localhost:7006/api/Teacher"));
            WebReq.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Stream TeacherStream = WebResp.GetResponseStream();
            StreamReader reader = new StreamReader(TeacherStream);

            string TeacherJSON = reader.ReadToEnd();

            List<Teacher> teacherList = JsonSerializer.Deserialize<List<Teacher>>(TeacherJSON);

            foreach (var teacher in teacherList)
            {
                teacherDropdown.Items.Add(teacher);
            }
        }
        private void getDepartments()
        {
            deptDropdown.Items.Clear();

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create
            (string.Format("https://localhost:7006/api/Department"));
            WebReq.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Stream DepartmentStream = WebResp.GetResponseStream();
            StreamReader reader = new StreamReader(DepartmentStream);

            string DepartmentJSON = reader.ReadToEnd();

            List<Department> deptList = JsonSerializer.Deserialize<List<Department>>(DepartmentJSON);

            foreach (var dept in deptList)
            {
                deptDropdown.Items.Add(dept);
            }
        }
        private void getCoursesByDept(Guid deptID)
        {
            courseDropdown.Items.Clear();
            courseDropdown.Text = "";
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create
            (string.Format("https://localhost:7006/api/Course/Dept/{0}", deptID));
            WebReq.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Stream CourseStream = WebResp.GetResponseStream();
            StreamReader reader = new StreamReader(CourseStream);

            string CourseJSON = reader.ReadToEnd();

            List<Course> courseList = JsonSerializer.Deserialize<List<Course>>(CourseJSON);

            foreach (var course in courseList)
            {
                courseDropdown.Items.Add(course);
            }
        }
        private List<Section> getSectionsByDept(Guid deptID, bool sectionCheckboxes)
        {
            if (sectionCheckboxes) { clearSectionData(); }
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create
            (string.Format("https://localhost:7006/api/Section/Dept/{0}", deptID));
            WebReq.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Stream SecStream = WebResp.GetResponseStream();
            StreamReader reader = new StreamReader(SecStream);

            string SecJSON = reader.ReadToEnd();

            List<Section> secList = JsonSerializer.Deserialize<List<Section>>(SecJSON);

            if (sectionCheckboxes)
            {
                foreach (var sec in secList)
                {
                    if (sec.semesterNo == 1) { sem1.Enabled = true; }
                    else if (sec.semesterNo == 2) { sem2.Enabled = true; }
                    else if (sec.semesterNo == 3) { sem3.Enabled = true; }
                    else if (sec.semesterNo == 4) { sem4.Enabled = true; }
                    else if (sec.semesterNo == 5) { sem5.Enabled = true; }
                    else if (sec.semesterNo == 6) { sem6.Enabled = true; }
                    else if (sec.semesterNo == 7) { sem7.Enabled = true; }
                    else if (sec.semesterNo == 8) { sem8.Enabled = true; }

                    if (sec.postfixCharacter == 'A') { secA.Enabled = true; }
                    else if (sec.postfixCharacter == 'B') { secB.Enabled = true; }
                    else if (sec.postfixCharacter == 'C') { secC.Enabled = true; }
                    else if (sec.postfixCharacter == 'D') { secD.Enabled = true; }
                    else if (sec.postfixCharacter == 'E') { secE.Enabled = true; }
                    else if (sec.postfixCharacter == 'F') { secF.Enabled = true; }
                    else if (sec.postfixCharacter == 'G') { secG.Enabled = true; }
                    else if (sec.postfixCharacter == 'H') { secH.Enabled = true; }
                    else if (sec.postfixCharacter == 'I') { secI.Enabled = true; }
                    else if (sec.postfixCharacter == 'J') { secJ.Enabled = true; }
                }
            }
            return secList;
        }
        private void clearSectionData()
        {
            sem1.Enabled = false;
            sem2.Enabled = false;
            sem3.Enabled = false;
            sem4.Enabled = false;
            sem5.Enabled = false;
            sem6.Enabled = false;
            sem7.Enabled = false;
            sem8.Enabled = false;

            sem1.Checked = false;
            sem2.Checked = false;
            sem3.Checked = false;
            sem4.Checked = false;
            sem5.Checked = false;
            sem6.Checked = false;
            sem7.Checked = false;
            sem8.Checked = false;

            secA.Enabled = false;
            secB.Enabled = false;
            secC.Enabled = false;
            secD.Enabled = false;
            secE.Enabled = false;
            secF.Enabled = false;
            secG.Enabled = false;
            secH.Enabled = false;
            secI.Enabled = false;
            secJ.Enabled = false;

            secA.Checked = false;
            secB.Checked = false;
            secC.Checked = false;
            secD.Checked = false;
            secE.Checked = false;
            secF.Checked = false;
            secG.Checked = false;
            secH.Checked = false;
            secI.Checked = false;
            secJ.Checked = false;
        }
        private void deptDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department dept = (Department)deptDropdown.SelectedItem;
            getCoursesByDept(dept.id);
            getSectionsByDept(dept.id, true);
        }

        private void addCourseReg_Click(object sender, EventArgs e)
        {
            List<Section> sectionsSelected = new List<Section>();
            
            int semesterSelected = 0;
            if(sem1.Checked == true) { semesterSelected = 1; }
            else if (sem2.Checked == true) { semesterSelected = 2; }
            else if (sem3.Checked == true) { semesterSelected = 3; }
            else if (sem4.Checked == true) { semesterSelected = 4; }
            else if (sem5.Checked == true) { semesterSelected = 5; }
            else if (sem6.Checked == true) { semesterSelected = 6; }
            else if (sem7.Checked == true) { semesterSelected = 7; }
            else if (sem8.Checked == true) { semesterSelected = 8; }

            List<char> sectionsCharSelected = new List<char>();
            if (secA.Checked == true) { sectionsCharSelected.Add('A'); }
            if (secB.Checked == true) { sectionsCharSelected.Add('B'); }
            if (secC.Checked == true) { sectionsCharSelected.Add('C'); }
            if (secD.Checked == true) { sectionsCharSelected.Add('D'); }
            if (secE.Checked == true) { sectionsCharSelected.Add('E'); }
            if (secF.Checked == true) { sectionsCharSelected.Add('F'); }
            if (secG.Checked == true) { sectionsCharSelected.Add('G'); }
            if (secH.Checked == true) { sectionsCharSelected.Add('H'); }
            if (secI.Checked == true) { sectionsCharSelected.Add('I'); }
            if (secJ.Checked == true) { sectionsCharSelected.Add('J'); }


            Department deptSelected = (Department)deptDropdown.SelectedItem;

            List<Section> sections = getSectionsByDept(deptSelected.id, false);
            foreach (var section in sections)
            {
                if(section.semesterNo == semesterSelected && sectionsCharSelected.Contains(section.postfixCharacter))
                {
                    sectionsSelected.Add(section);
                }
            }
            foreach(var selectedSec in sectionsSelected)
            {
                CourseLog CourseReg = new CourseLog();
                CourseReg.courseID = ((Course)courseDropdown.SelectedItem).id;
                CourseReg.teacherID = ((Teacher)teacherDropdown.SelectedItem).id;
                CourseReg.sectionID = selectedSec.id;
                CourseReg.status = "Open";
                addCourseRegistration(CourseReg);
            }

            RefreshData();
        }
        private void addCourseRegistration(CourseLog data)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:7006/api/CourseLog");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(data);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                MessageBox.Show(result);
            }
        }
        private void getRegistrationCourses()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create
            (string.Format("https://localhost:7006/api/CourseLog"));
            WebReq.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Stream DepartmentStream = WebResp.GetResponseStream();
            StreamReader reader = new StreamReader(DepartmentStream);

            string CourseRegJSON = reader.ReadToEnd();

            courseRegDetails = JsonSerializer.Deserialize<List<CourseRegDetails>>(CourseRegJSON);

            foreach (var courseReg in courseRegDetails)
            {
                string sectionStr = courseReg.sectionDept + "-" + courseReg.semesterNo.ToString() + courseReg.sectionChar;
                string[] row = new string[] { courseReg.courseLogID.ToString(), courseReg.courseCode, courseReg.courseTitle, courseReg.courseType, sectionStr, courseReg.teacherName };
                courseRegTable.Rows.Add(courseReg.courseLogID, courseReg.courseCode, courseReg.courseTitle, courseReg.courseType, sectionStr, courseReg.teacherName);
            }
        }
        private void courseRegTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Guid courseLogDeleteID = (Guid)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                deleteCourseLog(courseLogDeleteID);
            }
            RefreshData();
        }
        private void deleteCourseLog(Guid id)
        {
            try
            {
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(
                string.Format("https://localhost:7006/api/CourseLog/{0}", id));
                WebReq.Method = "DELETE";
                WebReq.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

                var httpResponse = (HttpWebResponse)WebReq.GetResponse();
                MessageBox.Show("Server Response (Status Code): " + httpResponse.StatusCode.ToString());
            }
            catch (WebException webException)
            {
                MessageBox.Show("Server Response (Status Code): " + (webException.Response as HttpWebResponse)?.StatusCode.ToString());
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void EmptyCourseRegTable()
        {
            do
            {
                foreach (DataGridViewRow row in courseRegTable.Rows)
                {
                    try
                    {
                        courseRegTable.Rows.Remove(row);
                    }
                    catch (InvalidOperationException exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                    catch (Exception) { }
                }
            } while (courseRegTable.Rows.Count > 0);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string filterValue = filterTextBox.Text;
            filterTextBox.Text = "";
            
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach(DataGridViewRow row in courseRegTable.Rows)
            {
                if (row.Cells[1].Value.ToString() == filterValue)
                {
                    rows.Add(row);
                }
            }
            EmptyCourseRegTable();
            foreach(var row in rows)
            {
                courseRegTable.Rows.Add(row);
            }
        }
    }
}
