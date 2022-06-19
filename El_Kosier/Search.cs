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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            Preview f = new Preview();
            f.Show();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {

        }

        private void studentNameComboBox17_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                studentIdTextBox10.Focus();
        }
        }

        private void groupComboBox18_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filterByComboBox1.Focus();
            }
        }

        private void filterByComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (monthComboBox1.Visible)
                {
                    monthComboBox1.Focus();
                }
                else {
                    runButton.Focus();
                }
            }
        }

        private void monthComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                statusComboBox1.Focus();
            }
        }
        private void statusComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lectureNumberComboBox3.Visible)
                {
                    lectureNumberComboBox3.Focus();
                }
                else {
                    runButton.Focus();
                }
            }
        }

        private void lectureNumberComboBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                runButton.Focus();
            }
        } 

        private void filterByComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(filterByComboBox1.SelectedItem) == "Attendance")
            {
                lectureNumberComboBox3.Visible = true;
                label6.Visible = true;
                statusComboBox1.Visible = true;
                label7.Visible = true;
                monthComboBox1.Visible = true;
                label5.Visible = true;
            }
            else 
            {
                lectureNumberComboBox3.Visible = false;
                label6.Visible = false;
                if (Convert.ToString(filterByComboBox1.SelectedItem) == "")
                {
                    statusComboBox1.Visible = false;
                    label7.Visible = false;
                    monthComboBox1.Visible = false;
                    label5.Visible = false;
                }
                else 
                {
                    statusComboBox1.Visible = true;
                    label7.Visible = true;
                    monthComboBox1.Visible = true;
                    label5.Visible = true;
                }
            }
        }

        private void studentIdTextBox10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                placeComboBox17.Focus();
        }
        }

        private void placeComboBox17_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                groupComboBox18.Focus();
            }
        }
        }
}