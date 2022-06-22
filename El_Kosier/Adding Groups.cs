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
    public partial class adding_groups : Form
    {
        public adding_groups()
        {
            InitializeComponent();
            List<string> placesName = Place.getAllplacesName();
            foreach (string name in placesName)
            {
                placeComboBox9.Items.Add(name);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void placeComboBox9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nameTextBox1.Focus();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton.Focus();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(nameTextBox1.Text)))
            {
                int placeId = Place.getPlaceIdByName(placeComboBox9.SelectedItem.ToString());
                Group.insertGroup(nameTextBox1.Text, placeId);
                this.Close();
            }
            else {
                MessageBox.Show("please check if you didn't write name for the group or select a place");
            }
        }

        private void adding_groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.place' table. You can move, or remove it, as needed.
            this.placeTableAdapter.Fill(this.database1DataSet.place);

        }
        
    }
}
