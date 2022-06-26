using El_Kosier.Models;
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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            List<string> studentsName = Student.getAllStudentName();
            foreach (string name in studentsName)
            {
                studentNameComboBox4.Items.Add(name);
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void studentNameComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int studentCode = Student.getStudentCodeByName(studentNameComboBox4.SelectedItem.ToString());
            studentIdTextBox2.Text = studentCode.ToString();
        }
                
        private void studentNameComboBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                studentIdTextBox2.Focus();
            }
        }
        private void idStudentTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
        if (e.KeyCode == Keys.Enter)
            {
                attendanceMonthComboBox1.Focus();
            }
            }
        private void monthNumberComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lectureNumberComboBox3.Focus();
            }
        }

        private void classNumberComboBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                presentRadioButton.Focus();
            }
        }

        private void presentRadioButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButton.Focus();
            }
        }

        private void absentRadioButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButton.Focus();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string attendanceType = " ";
            int month = attendanceMonthComboBox1.SelectedIndex + 1;
            int LecNumber = lectureNumberComboBox3.SelectedIndex + 1;
            if (presentRadioButton.Checked) {
                attendanceType = presentRadioButton.Text;
            }
            if (absentRadioButton.Checked) {
                attendanceType = absentRadioButton.Text;
            }
            int studentId = Student.getStudentIdByName(studentNameComboBox4.SelectedItem.ToString());
            Models.Attendance.inertAttendeance(LecNumber, month, attendanceType, studentId);
        }
    }
}