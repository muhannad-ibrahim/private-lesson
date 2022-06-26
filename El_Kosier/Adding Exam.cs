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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
            List<string> studentsName = Student.getAllStudentName();
            foreach (string name in studentsName)
            {
                studentNameComboBox14.Items.Add(name);
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void studentNameComboBox14_KeyUp(object sender, KeyEventArgs e)
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
                 examMonthComboBox1.Focus();
             }
         }
        private void examMonthComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                resultTextBox7.Focus();
            }
        }

        private void studentNameComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            int studentCode = Student.getStudentCodeByName(studentNameComboBox14.SelectedItem.ToString());
            studentIdTextBox2.Text = studentCode.ToString();
        }

        private void resultTextBox7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButton.Focus();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int month = examMonthComboBox1.SelectedIndex + 1;
            string result = resultTextBox7.Text;
            int studentId = Student.getStudentIdByName(studentNameComboBox14.SelectedItem.ToString());
            Models.Exam.inertExamRes(result,month, studentId);
        }
    }
}
