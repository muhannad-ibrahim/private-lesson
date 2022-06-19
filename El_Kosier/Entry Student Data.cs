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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
                
        private void placeComboBox9_KeyUp(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                groupComboBox10.Focus();
        }
    }

        private void groupComboBox10_KeyUp(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
        }
        }
        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
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
                studentNameTextBox3.Focus();
        }
        }

        private void studentNameTextBox3_KeyUp(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                studentNumberTextBox1.Focus();
        }
        }

        private void levelComboBox11_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notesTextBox5.Focus();
            }
        }

        private void studentNumberTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guardianNumberTextBox4.Focus();
            }
        }

        private void guardianNumberTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gradeComboBox11.Focus();
            }
        }

        private void notesTextBox5_KeyUp(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                saveButton.Focus();
            }
        }
                      
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
