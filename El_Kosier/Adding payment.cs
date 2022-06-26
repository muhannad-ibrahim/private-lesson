using System;
using El_Kosier.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            List<string> studentsName = Student.getAllStudentName();
            foreach (string name in studentsName)
            {
                studentNameComboBox8.Items.Add(name);
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void studentNameComboBox8_KeyUp(object sender, KeyEventArgs e)
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
                paymentMonthcomboBox1.Focus();
            }
        }
        
        private void paymentMonthcomboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButton.Focus();
            }
        }

        private void studentNameComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int studentCode = Student.getStudentCodeByName(studentNameComboBox8.SelectedItem.ToString());
            studentIdTextBox2.Text = studentCode.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int month = paymentMonthcomboBox1.SelectedIndex + 1;
            int studentId = Student.getStudentIdByName(studentNameComboBox8.SelectedItem.ToString());
            Models.Payment.insertPayment(month,studentId);
        }
    }
    }
