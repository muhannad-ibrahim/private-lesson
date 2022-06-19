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
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }
        
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentAttendance f = new StudentAttendance();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentPayment f = new StudentPayment();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentExams f = new StudentExams();
            f.Show();
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