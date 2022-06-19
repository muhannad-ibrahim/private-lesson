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
    public partial class adding_places : Form
    {
        public adding_places()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Place.insertPlace(textBox1.Text.ToString());
            this.Close();
        }
    }
}
