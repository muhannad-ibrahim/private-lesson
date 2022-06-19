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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Form3 f = new Form3();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attendance f = new Attendance();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment f = new Payment();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exam f = new Exam();
            f.Show();
        }

        private void placesButton_Click(object sender, EventArgs e)
        {
            adding_places f = new adding_places();
            f.Show();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            adding_groups f = new adding_groups();
            f.Show();
        }

        private void addNewSourceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addNewSourceCheckBox.Checked)
            {
                placesButton.Enabled = true;
                groupsButton.Enabled = true;
            }
            else
            {
                placesButton.Enabled = false;
                groupsButton.Enabled = false;
            }

        }
    }
}
