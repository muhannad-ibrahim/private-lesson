using El_Kosier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier
{
    public partial class StudentPayment : Form
    {
        int studentId;

        public StudentPayment(int passedStudentId)
        {
            InitializeComponent();
            this.studentId = passedStudentId;
            showStudentPayemnt(studentId);
        }

        private void showStudentPayemnt(int studentId)
        {
            DataTable dt = Models.Payment.getPaymentById(studentId);
            this.dataGridView2.DataSource = dt;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
