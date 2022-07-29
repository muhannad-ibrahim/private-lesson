using El_Kosier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier
{
    public partial class Preview : Form
    {
        int studentId;
        public Preview(int passedStudentId)
        {
            InitializeComponent();
            this.studentId = passedStudentId;
            showStudentData(studentId);
        }

        private void showStudentData(int studentId) {
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM student  WHERE id = {studentId}", cn))
                {
                    SqlDataReader studentReader = cmd.ExecuteReader();
                    while (studentReader.Read())
                    {
                        studentNameTextBox9.Text = studentReader.GetValue(1).ToString();
                        studentIdTextBox10.Text = studentReader.GetValue(2).ToString();
                        gradeTextBox12.Text = studentReader.GetValue(3).ToString();
                        guardianNumberTextBox13.Text = studentReader.GetValue(4).ToString();
                        notesTextBox19.Text = studentReader.GetValue(5).ToString();
                        placeTextBox15.Text = Place.getPlaceNameById((int)studentReader.GetValue(6));
                        groupTextBox14.Text = Group.getGroupNameById((int)studentReader.GetValue(7));
                        studentNumberTextBox1.Text = studentReader.GetValue(8).ToString();
                        dateTextBox11.Text = studentReader.GetValue(9).ToString();
                    }
                    studentReader.Close();
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int getStudentId() {

            String studentName = studentNameTextBox9.Text;
            int id = Student.getStudentIdByName(studentName);
            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int studentId = getStudentId();
            StudentAttendance studentPassedData = new StudentAttendance(studentId);
            studentPassedData.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int studentId = getStudentId();
            StudentPayment studentPassedData = new StudentPayment(studentId);
            studentPassedData.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int studentId = getStudentId();
            StudentExams studentPassedData = new StudentExams(studentId);
            studentPassedData.ShowDialog(this);
        }

        private void deletebutton5_Click(object sender, EventArgs e)
        {
            int studentId = getStudentId();
            string message = "By clicking OK, this student will be permenantly DELETED\nmake sure from your choice";
            string title = "student will be deleted";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result != DialogResult.OK)
            {
                return;
            }
            else
            {
                Student.deleteStudent(studentId);
                MessageBox.Show("student is deleted successfully..!");
                this.Close();
            }
        }

        private void studentNameTextBox9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTextBox11.Focus();
        }
        }

        private void dateTextBox11_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gradeTextBox12.Focus();
            }
        }

        private void gradeTextBox12_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                studentNumberTextBox1.Focus();
            }
        }

        private void studentNumberTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guardianNumberTextBox13.Focus();
            }
        }

        private void guardianNumberTextBox13_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                groupTextBox14.Focus();
            }
        }

        private void groupTextBox14_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                placeTextBox15.Focus();
            }
        }

        private void placeTextBox15_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                studentIdTextBox10.Focus();
            }
        }

        private void studentIdTextBox10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notesTextBox19.Focus();
            }
        }

        private void notesTextBox19_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                savebutton4.Focus();
            }
        }
    }
}