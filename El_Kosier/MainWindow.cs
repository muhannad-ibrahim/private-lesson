﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entry f = new Entry();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search f = new Search();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
