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
    public partial class StudentExams : Form
    {
        int studentId;

        public StudentExams(int passedStudentId)
        {
            InitializeComponent();
            this.studentId = passedStudentId;
            showStudentPayemnt(studentId);
        }

        private void showStudentPayemnt(int studentId)
        {
            DataTable dt = Models.Exam.getExamById(studentId);
            this.dataGridView3.DataSource = dt;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
