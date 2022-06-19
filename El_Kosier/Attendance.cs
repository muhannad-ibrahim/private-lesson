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
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void placeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            
        }

        private void groupComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void classNumberComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentNameComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void presentRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        }

        }
