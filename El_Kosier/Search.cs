using El_Kosier.Models;
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
            List<string> studentsName = Student.getAllStudentName();
            foreach (string name in studentsName)
            {
                studentNameComboBox15.Items.Add(name);
            }
            List<string> placesName = Place.getAllplacesName();
            placeComboBox17.Items.Add(" ");
            foreach (string name in placesName)
            {
                placeComboBox17.Items.Add(name);
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                String studentName = (String)dataGridView1.SelectedRows[0].Cells[0].Value;
                int studentId = Student.getStudentIdByName(studentName);
                Preview studentPassedData = new Preview(studentId);
                studentPassedData.ShowDialog(this);
            }
            else {
                MessageBox.Show("Sorry, There's no data to view");
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if ((studentNameComboBox15.Text == "") & ((placeComboBox17.SelectedIndex < 0) || (placeComboBox17.Text == " ")) & (filterByComboBox1.SelectedIndex < 0))
            {
                DataTable dt = Student.getAllStudentData();
                this.dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 40;
                return;
            }
            if ((studentNameComboBox15.Text != "") & ((placeComboBox17.SelectedIndex < 0) || (placeComboBox17.Text == " ")) & (filterByComboBox1.SelectedIndex < 0))
            {
                DataTable dt = Student.getStudentData(studentNameComboBox15.Text);
                this.dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 40;
                return;
            }
            if ((placeComboBox17.SelectedIndex > -1) & (placeComboBox17.Text != " ") & (studentNameComboBox15.Text == "") & (filterByComboBox1.SelectedIndex < 0))
            {
                if (groupComboBox18.SelectedIndex > -1)
                {
                    int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                    int groupId = Group.getGroupIdByName(groupComboBox18.SelectedItem.ToString());
                    DataTable dt = Student.getStudentsPlace_Group(placeId, groupId);
                    this.dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[1].Width = 40;
                    return;
                }
                else
                {
                    int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                    DataTable dt = Student.getStudentsPlace_Group(placeId, 0);
                    this.dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[1].Width = 40;
                    return;
                }
            }
            if ((placeComboBox17.SelectedIndex > -1) & (placeComboBox17.Text != " ") & (studentNameComboBox15.Text != "") & (filterByComboBox1.SelectedIndex < 0))
            {
                if (groupComboBox18.SelectedIndex > -1)
                {
                    string studentName = studentNameComboBox15.Text;
                    int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                    int groupId = Group.getGroupIdByName(groupComboBox18.SelectedItem.ToString());
                    DataTable dt = Student.getStudentDataWithPlace_Group(studentName, placeId, groupId);
                    this.dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[1].Width = 40;
                    return;
                }
                else
                {
                    string studentName = studentNameComboBox15.Text;
                    int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                    DataTable dt = Student.getStudentDataWithPlace_Group(studentName, placeId, 0);
                    this.dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 200;
                    dataGridView1.Columns[1].Width = 40;
                    return;
                }
            }
            if ((filterByComboBox1.SelectedIndex > -1) & (placeComboBox17.SelectedIndex > -1) & (placeComboBox17.Text != " ") & (studentNameComboBox15.Text == ""))
            {
                if (filterByComboBox1.SelectedItem.ToString() == "Payment")
                {
                    DataTable dt = new DataTable();
                    if (groupComboBox18.SelectedIndex > -1)
                    {
                        int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                        int groupId = Group.getGroupIdByName(groupComboBox18.SelectedItem.ToString());
                        int month = 0;
                        if (monthComboBox1.SelectedIndex > -1)
                        {
                            month = Convert.ToInt32(monthComboBox1.Text);
                            dt = Student.getStudentDataWithPlace_Group_Payment(placeId, groupId, month);
                        }
                        else
                        {
                            dt = Student.getAllPayments(placeId, groupId);
                        }
                        this.dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].Width = 200;
                        dataGridView1.Columns[1].Width = 40;
                        return;
                    }
                    else
                    {
                        int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                        int month = 0;
                        if (monthComboBox1.SelectedIndex > -1)
                        {
                            month = Convert.ToInt32(monthComboBox1.Text);
                            dt = Student.getStudentDataWithPlace_Group_Payment(placeId, 0, month);
                        }
                        else
                        {
                            dt = Student.getAllPayments(placeId, 0);
                        }
                        this.dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].Width = 200;
                        dataGridView1.Columns[1].Width = 40;
                        return;
                    }
                }
                else if (filterByComboBox1.SelectedItem.ToString() == "Attendance")
                {
                    DataTable dt = new DataTable();
                    if (groupComboBox18.SelectedIndex > -1)
                    {
                        int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                        int groupId = Group.getGroupIdByName(groupComboBox18.SelectedItem.ToString());
                        int month = 0;
                        int lectureNumber = 0;
                        if (monthComboBox1.SelectedIndex > -1 && lectureNumberComboBox3.SelectedIndex < 0)
                        {
                            month = Convert.ToInt32(monthComboBox1.Text);
                            dt = Student.getStudentDataWithPlace_Group_Attendace(placeId, groupId, month,lectureNumber);
                        }
                        else if (monthComboBox1.SelectedIndex > -1 && lectureNumberComboBox3.SelectedIndex > -1)
                        {
                            month = Convert.ToInt32(monthComboBox1.Text);
                            lectureNumber = Convert.ToInt32(lectureNumberComboBox3.Text);
                            dt = Student.getStudentDataWithPlace_Group_Attendace(placeId, groupId, month,lectureNumber);
                        }
                        else
                        {
                            dt = Student.getAllAttendace(placeId, groupId);
                        }
                        this.dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].Width = 200;
                        dataGridView1.Columns[1].Width = 40;
                        return;
                    }
                    else
                    {
                        int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                        int month = 0;
                        int lectureNumber = 0;
                        if (monthComboBox1.SelectedIndex > -1 && lectureNumberComboBox3.SelectedIndex < 0)
                        {
                            month = Convert.ToInt32(monthComboBox1.Text);
                            dt = Student.getStudentDataWithPlace_Group_Attendace(placeId, 0, month,lectureNumber);
                        }
                        else if (monthComboBox1.SelectedIndex > -1 && lectureNumberComboBox3.SelectedIndex > -1)
                        {
                            month = Convert.ToInt32(monthComboBox1.Text);
                            lectureNumber = Convert.ToInt32(lectureNumberComboBox3.Text);
                            dt = Student.getStudentDataWithPlace_Group_Attendace(placeId, 0, month,lectureNumber);
                        }
                        else
                        {
                            dt = Student.getAllAttendace(placeId, 0);
                        }
                        this.dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].Width = 200;
                        dataGridView1.Columns[1].Width = 40;
                        return;
                    }
                }
                else if (filterByComboBox1.SelectedItem.ToString() == "Exam")
                {
                    DataTable dt = new DataTable();
                    if (groupComboBox18.SelectedIndex > -1)
                    {
                        int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                        int groupId = Group.getGroupIdByName(groupComboBox18.SelectedItem.ToString());
                        int month = 0;
                        if (monthComboBox1.SelectedIndex > -1)
                        {
                            month = Convert.ToInt32(monthComboBox1.Text);
                            dt = Student.getStudentDataWithPlace_Group_Exam(placeId, groupId, month);
                        }
                        else
                        {
                            dt = Student.getAllExams(placeId, groupId);
                        }
                        this.dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].Width = 200;
                        dataGridView1.Columns[1].Width = 40;
                        return;
                    }
                    else
                    {
                        int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                        int month = 0;
                        if (monthComboBox1.SelectedIndex > -1)
                        {
                            month = Convert.ToInt32(monthComboBox1.Text);
                            dt = Student.getStudentDataWithPlace_Group_Exam(placeId, 0, month);
                        }
                        else
                        {
                            dt = Student.getAllExams(placeId, 0);
                        }
                        this.dataGridView1.DataSource = dt;
                        dataGridView1.Columns[0].Width = 200;
                        dataGridView1.Columns[1].Width = 40;
                        return;
                    }
                }
            }
            if ((filterByComboBox1.SelectedIndex > -1) & (studentNameComboBox15.Text != "") & ((placeComboBox17.SelectedIndex < 0) || (placeComboBox17.Text == " ")))
            {

            }
            if ((filterByComboBox1.SelectedIndex > -1) & (studentNameComboBox15.Text != "") & (placeComboBox17.SelectedIndex > -1) & (placeComboBox17.Text != " "))
            {

            }

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
                else
                {
                    runButton.Focus();
                }
            }
        }

        private void monthComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lectureNumberComboBox3.Focus();
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
                monthComboBox1.Visible = true;
                label5.Visible = true;
            }
            else
            {
                lectureNumberComboBox3.Visible = false;
                label6.Visible = false;
                if (Convert.ToString(filterByComboBox1.SelectedItem) == " ")
                {
                    monthComboBox1.Visible = false;
                    label5.Visible = false;
                }
                else
                {
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
                if (placeComboBox17.Text != " ")
                {
                    groupComboBox18.Focus();
                }
                else
                {
                    filterByComboBox1.Focus();
                }
            }
        }

        private void placeComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (placeComboBox17.Text != " ")
            {
                groupComboBox18.Enabled = true;
                groupComboBox18.Items.Clear();
                int placeId = Place.getPlaceIdByName(placeComboBox17.SelectedItem.ToString());
                List<string> groupsName = Group.getAllGroupsNameById(placeId);
                foreach (string name in groupsName)
                {
                    groupComboBox18.Items.Add(name);
                }
                groupComboBox18.Text = "";
            }
            else
            {
                groupComboBox18.Enabled = false;
            }

        }

        private void studentNameComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            int studentCode = Student.getStudentCodeByName(studentNameComboBox15.SelectedItem.ToString());
            studentIdTextBox10.Text = studentCode.ToString();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.Rows.Count);
        }

        private void refreshButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Search searchForm = new Search();
            searchForm.Show();
        }
        
        private void monthComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lectureNumberComboBox3.Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                String studentName = (String)dataGridView1.SelectedRows[0].Cells[0].Value;
                int studentId = Student.getStudentIdByName(studentName);
                Preview studentPassedData = new Preview(studentId);
                studentPassedData.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sorry, There's no data to view");
            }
        }
    }
}