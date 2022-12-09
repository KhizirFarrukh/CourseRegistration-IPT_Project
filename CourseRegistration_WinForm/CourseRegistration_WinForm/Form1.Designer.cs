namespace CourseRegistration_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.deptDropdown = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCourseReg = new System.Windows.Forms.Button();
            this.secJ = new System.Windows.Forms.CheckBox();
            this.secI = new System.Windows.Forms.CheckBox();
            this.secH = new System.Windows.Forms.CheckBox();
            this.secG = new System.Windows.Forms.CheckBox();
            this.secF = new System.Windows.Forms.CheckBox();
            this.secE = new System.Windows.Forms.CheckBox();
            this.secD = new System.Windows.Forms.CheckBox();
            this.secC = new System.Windows.Forms.CheckBox();
            this.secB = new System.Windows.Forms.CheckBox();
            this.secA = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sem8 = new System.Windows.Forms.RadioButton();
            this.sem7 = new System.Windows.Forms.RadioButton();
            this.sem6 = new System.Windows.Forms.RadioButton();
            this.sem5 = new System.Windows.Forms.RadioButton();
            this.sem4 = new System.Windows.Forms.RadioButton();
            this.sem3 = new System.Windows.Forms.RadioButton();
            this.sem2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.sem1 = new System.Windows.Forms.RadioButton();
            this.teacherDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.courseRegTable = new System.Windows.Forms.DataGridView();
            this.courseLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // deptDropdown
            // 
            this.deptDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptDropdown.FormattingEnabled = true;
            this.deptDropdown.Location = new System.Drawing.Point(120, 12);
            this.deptDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.deptDropdown.Name = "deptDropdown";
            this.deptDropdown.Size = new System.Drawing.Size(156, 24);
            this.deptDropdown.TabIndex = 1;
            this.deptDropdown.SelectedIndexChanged += new System.EventHandler(this.deptDropdown_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addCourseReg);
            this.panel1.Controls.Add(this.secJ);
            this.panel1.Controls.Add(this.secI);
            this.panel1.Controls.Add(this.secH);
            this.panel1.Controls.Add(this.secG);
            this.panel1.Controls.Add(this.secF);
            this.panel1.Controls.Add(this.secE);
            this.panel1.Controls.Add(this.secD);
            this.panel1.Controls.Add(this.secC);
            this.panel1.Controls.Add(this.secB);
            this.panel1.Controls.Add(this.secA);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.sem8);
            this.panel1.Controls.Add(this.sem7);
            this.panel1.Controls.Add(this.sem6);
            this.panel1.Controls.Add(this.sem5);
            this.panel1.Controls.Add(this.sem4);
            this.panel1.Controls.Add(this.sem3);
            this.panel1.Controls.Add(this.sem2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sem1);
            this.panel1.Controls.Add(this.teacherDropdown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.courseDropdown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deptDropdown);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 178);
            this.panel1.TabIndex = 2;
            // 
            // addCourseReg
            // 
            this.addCourseReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseReg.Location = new System.Drawing.Point(899, 96);
            this.addCourseReg.Margin = new System.Windows.Forms.Padding(4);
            this.addCourseReg.Name = "addCourseReg";
            this.addCourseReg.Size = new System.Drawing.Size(152, 59);
            this.addCourseReg.TabIndex = 26;
            this.addCourseReg.Text = "Add Course Registration";
            this.addCourseReg.UseVisualStyleBackColor = true;
            this.addCourseReg.Click += new System.EventHandler(this.addCourseReg_Click);
            // 
            // secJ
            // 
            this.secJ.AutoSize = true;
            this.secJ.Enabled = false;
            this.secJ.Location = new System.Drawing.Point(564, 134);
            this.secJ.Margin = new System.Windows.Forms.Padding(4);
            this.secJ.Name = "secJ";
            this.secJ.Size = new System.Drawing.Size(36, 20);
            this.secJ.TabIndex = 25;
            this.secJ.Text = "J";
            this.secJ.UseVisualStyleBackColor = true;
            // 
            // secI
            // 
            this.secI.AutoSize = true;
            this.secI.Enabled = false;
            this.secI.Location = new System.Drawing.Point(515, 134);
            this.secI.Margin = new System.Windows.Forms.Padding(4);
            this.secI.Name = "secI";
            this.secI.Size = new System.Drawing.Size(32, 20);
            this.secI.TabIndex = 24;
            this.secI.Text = "I";
            this.secI.UseVisualStyleBackColor = true;
            // 
            // secH
            // 
            this.secH.AutoSize = true;
            this.secH.Enabled = false;
            this.secH.Location = new System.Drawing.Point(465, 134);
            this.secH.Margin = new System.Windows.Forms.Padding(4);
            this.secH.Name = "secH";
            this.secH.Size = new System.Drawing.Size(39, 20);
            this.secH.TabIndex = 23;
            this.secH.Text = "H";
            this.secH.UseVisualStyleBackColor = true;
            // 
            // secG
            // 
            this.secG.AutoSize = true;
            this.secG.Enabled = false;
            this.secG.Location = new System.Drawing.Point(416, 134);
            this.secG.Margin = new System.Windows.Forms.Padding(4);
            this.secG.Name = "secG";
            this.secG.Size = new System.Drawing.Size(39, 20);
            this.secG.TabIndex = 22;
            this.secG.Text = "G";
            this.secG.UseVisualStyleBackColor = true;
            // 
            // secF
            // 
            this.secF.AutoSize = true;
            this.secF.Enabled = false;
            this.secF.Location = new System.Drawing.Point(367, 134);
            this.secF.Margin = new System.Windows.Forms.Padding(4);
            this.secF.Name = "secF";
            this.secF.Size = new System.Drawing.Size(37, 20);
            this.secF.TabIndex = 21;
            this.secF.Text = "F";
            this.secF.UseVisualStyleBackColor = true;
            // 
            // secE
            // 
            this.secE.AutoSize = true;
            this.secE.Enabled = false;
            this.secE.Location = new System.Drawing.Point(317, 134);
            this.secE.Margin = new System.Windows.Forms.Padding(4);
            this.secE.Name = "secE";
            this.secE.Size = new System.Drawing.Size(38, 20);
            this.secE.TabIndex = 20;
            this.secE.Text = "E";
            this.secE.UseVisualStyleBackColor = true;
            // 
            // secD
            // 
            this.secD.AutoSize = true;
            this.secD.Enabled = false;
            this.secD.Location = new System.Drawing.Point(268, 134);
            this.secD.Margin = new System.Windows.Forms.Padding(4);
            this.secD.Name = "secD";
            this.secD.Size = new System.Drawing.Size(39, 20);
            this.secD.TabIndex = 19;
            this.secD.Text = "D";
            this.secD.UseVisualStyleBackColor = true;
            // 
            // secC
            // 
            this.secC.AutoSize = true;
            this.secC.Enabled = false;
            this.secC.Location = new System.Drawing.Point(219, 134);
            this.secC.Margin = new System.Windows.Forms.Padding(4);
            this.secC.Name = "secC";
            this.secC.Size = new System.Drawing.Size(38, 20);
            this.secC.TabIndex = 18;
            this.secC.Text = "C";
            this.secC.UseVisualStyleBackColor = true;
            // 
            // secB
            // 
            this.secB.AutoSize = true;
            this.secB.Enabled = false;
            this.secB.Location = new System.Drawing.Point(169, 134);
            this.secB.Margin = new System.Windows.Forms.Padding(4);
            this.secB.Name = "secB";
            this.secB.Size = new System.Drawing.Size(38, 20);
            this.secB.TabIndex = 17;
            this.secB.Text = "B";
            this.secB.UseVisualStyleBackColor = true;
            // 
            // secA
            // 
            this.secA.AutoSize = true;
            this.secA.Enabled = false;
            this.secA.Location = new System.Drawing.Point(120, 134);
            this.secA.Margin = new System.Windows.Forms.Padding(4);
            this.secA.Name = "secA";
            this.secA.Size = new System.Drawing.Size(38, 20);
            this.secA.TabIndex = 16;
            this.secA.Text = "A";
            this.secA.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Section";
            // 
            // sem8
            // 
            this.sem8.AutoSize = true;
            this.sem8.Enabled = false;
            this.sem8.Location = new System.Drawing.Point(465, 94);
            this.sem8.Margin = new System.Windows.Forms.Padding(4);
            this.sem8.Name = "sem8";
            this.sem8.Size = new System.Drawing.Size(35, 20);
            this.sem8.TabIndex = 14;
            this.sem8.TabStop = true;
            this.sem8.Text = "8";
            this.sem8.UseVisualStyleBackColor = true;
            // 
            // sem7
            // 
            this.sem7.AutoSize = true;
            this.sem7.Enabled = false;
            this.sem7.Location = new System.Drawing.Point(416, 94);
            this.sem7.Margin = new System.Windows.Forms.Padding(4);
            this.sem7.Name = "sem7";
            this.sem7.Size = new System.Drawing.Size(35, 20);
            this.sem7.TabIndex = 13;
            this.sem7.TabStop = true;
            this.sem7.Text = "7";
            this.sem7.UseVisualStyleBackColor = true;
            // 
            // sem6
            // 
            this.sem6.AutoSize = true;
            this.sem6.Enabled = false;
            this.sem6.Location = new System.Drawing.Point(367, 94);
            this.sem6.Margin = new System.Windows.Forms.Padding(4);
            this.sem6.Name = "sem6";
            this.sem6.Size = new System.Drawing.Size(35, 20);
            this.sem6.TabIndex = 12;
            this.sem6.TabStop = true;
            this.sem6.Text = "6";
            this.sem6.UseVisualStyleBackColor = true;
            // 
            // sem5
            // 
            this.sem5.AutoSize = true;
            this.sem5.Enabled = false;
            this.sem5.Location = new System.Drawing.Point(317, 94);
            this.sem5.Margin = new System.Windows.Forms.Padding(4);
            this.sem5.Name = "sem5";
            this.sem5.Size = new System.Drawing.Size(35, 20);
            this.sem5.TabIndex = 11;
            this.sem5.TabStop = true;
            this.sem5.Text = "5";
            this.sem5.UseVisualStyleBackColor = true;
            // 
            // sem4
            // 
            this.sem4.AutoSize = true;
            this.sem4.Enabled = false;
            this.sem4.Location = new System.Drawing.Point(268, 94);
            this.sem4.Margin = new System.Windows.Forms.Padding(4);
            this.sem4.Name = "sem4";
            this.sem4.Size = new System.Drawing.Size(35, 20);
            this.sem4.TabIndex = 10;
            this.sem4.TabStop = true;
            this.sem4.Text = "4";
            this.sem4.UseVisualStyleBackColor = true;
            // 
            // sem3
            // 
            this.sem3.AutoSize = true;
            this.sem3.Enabled = false;
            this.sem3.Location = new System.Drawing.Point(219, 94);
            this.sem3.Margin = new System.Windows.Forms.Padding(4);
            this.sem3.Name = "sem3";
            this.sem3.Size = new System.Drawing.Size(35, 20);
            this.sem3.TabIndex = 9;
            this.sem3.TabStop = true;
            this.sem3.Text = "3";
            this.sem3.UseVisualStyleBackColor = true;
            // 
            // sem2
            // 
            this.sem2.AutoSize = true;
            this.sem2.Enabled = false;
            this.sem2.Location = new System.Drawing.Point(169, 94);
            this.sem2.Margin = new System.Windows.Forms.Padding(4);
            this.sem2.Name = "sem2";
            this.sem2.Size = new System.Drawing.Size(35, 20);
            this.sem2.TabIndex = 8;
            this.sem2.TabStop = true;
            this.sem2.Text = "2";
            this.sem2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Semester";
            // 
            // sem1
            // 
            this.sem1.AutoSize = true;
            this.sem1.Enabled = false;
            this.sem1.Location = new System.Drawing.Point(120, 94);
            this.sem1.Margin = new System.Windows.Forms.Padding(4);
            this.sem1.Name = "sem1";
            this.sem1.Size = new System.Drawing.Size(35, 20);
            this.sem1.TabIndex = 6;
            this.sem1.TabStop = true;
            this.sem1.Text = "1";
            this.sem1.UseVisualStyleBackColor = true;
            // 
            // teacherDropdown
            // 
            this.teacherDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherDropdown.FormattingEnabled = true;
            this.teacherDropdown.Location = new System.Drawing.Point(120, 52);
            this.teacherDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.teacherDropdown.Name = "teacherDropdown";
            this.teacherDropdown.Size = new System.Drawing.Size(415, 24);
            this.teacherDropdown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teacher";
            // 
            // courseDropdown
            // 
            this.courseDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseDropdown.FormattingEnabled = true;
            this.courseDropdown.Location = new System.Drawing.Point(407, 12);
            this.courseDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.courseDropdown.Name = "courseDropdown";
            this.courseDropdown.Size = new System.Drawing.Size(564, 24);
            this.courseDropdown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.filterTextBox);
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Controls.Add(this.filterButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.courseRegTable);
            this.panel2.Location = new System.Drawing.Point(16, 213);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 541);
            this.panel2.TabIndex = 3;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(1017, 442);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(175, 47);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(835, 450);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(107, 37);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 446);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "Filter by Course";
            // 
            // courseRegTable
            // 
            this.courseRegTable.AllowUserToAddRows = false;
            this.courseRegTable.AllowUserToResizeColumns = false;
            this.courseRegTable.AllowUserToResizeRows = false;
            this.courseRegTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseRegTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseLogID,
            this.CourseCode,
            this.CourseTitle,
            this.Type,
            this.CourseSection,
            this.CourseTeacher});
            this.courseRegTable.Location = new System.Drawing.Point(20, 20);
            this.courseRegTable.Margin = new System.Windows.Forms.Padding(4);
            this.courseRegTable.Name = "courseRegTable";
            this.courseRegTable.RowHeadersWidth = 51;
            this.courseRegTable.Size = new System.Drawing.Size(1172, 384);
            this.courseRegTable.TabIndex = 0;
            // 
            // courseLogID
            // 
            this.courseLogID.HeaderText = "courseLogID";
            this.courseLogID.MinimumWidth = 6;
            this.courseLogID.Name = "courseLogID";
            this.courseLogID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.courseLogID.Visible = false;
            this.courseLogID.Width = 125;
            // 
            // CourseCode
            // 
            this.CourseCode.HeaderText = "Course Code";
            this.CourseCode.MinimumWidth = 6;
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.ReadOnly = true;
            this.CourseCode.Width = 80;
            // 
            // CourseTitle
            // 
            this.CourseTitle.HeaderText = "Course Title";
            this.CourseTitle.MinimumWidth = 6;
            this.CourseTitle.Name = "CourseTitle";
            this.CourseTitle.ReadOnly = true;
            this.CourseTitle.Width = 300;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 60;
            // 
            // CourseSection
            // 
            this.CourseSection.HeaderText = "Course Section";
            this.CourseSection.MinimumWidth = 6;
            this.CourseSection.Name = "CourseSection";
            this.CourseSection.ReadOnly = true;
            this.CourseSection.Width = 60;
            // 
            // CourseTeacher
            // 
            this.CourseTeacher.HeaderText = "Course Teacher";
            this.CourseTeacher.MinimumWidth = 6;
            this.CourseTeacher.Name = "CourseTeacher";
            this.CourseTeacher.ReadOnly = true;
            this.CourseTeacher.Width = 220;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.Location = new System.Drawing.Point(299, 452);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(512, 34);
            this.filterTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 769);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseRegTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deptDropdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox courseDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox teacherDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sem1;
        private System.Windows.Forms.RadioButton sem7;
        private System.Windows.Forms.RadioButton sem6;
        private System.Windows.Forms.RadioButton sem5;
        private System.Windows.Forms.RadioButton sem4;
        private System.Windows.Forms.RadioButton sem3;
        private System.Windows.Forms.RadioButton sem2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton sem8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox secC;
        private System.Windows.Forms.CheckBox secB;
        private System.Windows.Forms.CheckBox secA;
        private System.Windows.Forms.CheckBox secE;
        private System.Windows.Forms.CheckBox secD;
        private System.Windows.Forms.CheckBox secJ;
        private System.Windows.Forms.CheckBox secI;
        private System.Windows.Forms.CheckBox secH;
        private System.Windows.Forms.CheckBox secG;
        private System.Windows.Forms.CheckBox secF;
        private System.Windows.Forms.Button addCourseReg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView courseRegTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTeacher;
        private System.Windows.Forms.TextBox filterTextBox;
    }
}

