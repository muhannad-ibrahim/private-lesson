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
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void studentNameComboBox14_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tudentIdTextBox2.Focus();
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

        }

        private void resultTextBox7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButton.Focus();
            }
        }
    }
}
