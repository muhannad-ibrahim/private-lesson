using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier
{
    public partial class StudentAttendance : Form
    {
        int studentId;
        public StudentAttendance()
        {
            InitializeComponent();
        }

        public StudentAttendance(int passedStudentId)
        {
            InitializeComponent();
            this.studentId = passedStudentId;
            showStudentPayemnt(studentId);
        }

        private void showStudentPayemnt(int studentId)
        {
            DataTable dt = Models.Attendance.getAttendanceById(studentId);
            this.dataGridView1.DataSource = dt;
            int countAbsent = 0;
            int countPresent = 0;
            if (dt.Rows.Count > 0) {
                foreach (DataRow row in dt.Rows)
                {
                    string attendanceType = row["attendance"].ToString();
                    if (String.Concat(attendanceType.Where(c => !Char.IsWhiteSpace(c))) == "Absent")
                    {
                        countAbsent++;
                    }
                    else if (String.Concat(attendanceType.Where(c => !Char.IsWhiteSpace(c))) == "Present")
                    {
                        countPresent++;
                    }
                    
                }
                this.absentTextBox18.Text = countAbsent.ToString();
                this.presentTextBox17.Text = countPresent.ToString();
            }
            else
            {
                this.absentTextBox18.Text = countAbsent.ToString();
                this.presentTextBox17.Text = countPresent.ToString();
            }

            /*if (dt.Rows.Count > 0)
            {
                var countAbsent = this.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["attendance"].Value == "Absent");
                var countPresent = this.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["attendance"].Value == "Present");

                this.absentTextBox18.Text = countAbsent.ToString();
                this.presentTextBox17.Text = countPresent.ToString();
            }
            else {
                this.absentTextBox18.Text = "0" ;
                this.presentTextBox17.Text = "0";
            }*/
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
