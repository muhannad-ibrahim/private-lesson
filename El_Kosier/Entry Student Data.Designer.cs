namespace El_Kosier
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.gradeComboBox11 = new System.Windows.Forms.ComboBox();
            this.notesTextBox5 = new System.Windows.Forms.TextBox();
            this.guardianNumberTextBox4 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.studentNameTextBox3 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.studentIdTextBox2 = new System.Windows.Forms.TextBox();
            this.groupComboBox10 = new System.Windows.Forms.ComboBox();
            this.placeComboBox9 = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.studentNumberTextBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(76, 591);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 35);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(640, 591);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 63;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // gradeComboBox11
            // 
            this.gradeComboBox11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeComboBox11.FormattingEnabled = true;
            this.gradeComboBox11.ItemHeight = 23;
            this.gradeComboBox11.Items.AddRange(new object[] {
            "",
            "Excellent",
            "Very Good",
            "Good",
            "Acceptable"});
            this.gradeComboBox11.Location = new System.Drawing.Point(227, 325);
            this.gradeComboBox11.Name = "gradeComboBox11";
            this.gradeComboBox11.Size = new System.Drawing.Size(177, 31);
            this.gradeComboBox11.TabIndex = 8;
            this.gradeComboBox11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.levelComboBox11_KeyUp);
            // 
            // notesTextBox5
            // 
            this.notesTextBox5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox5.Location = new System.Drawing.Point(227, 388);
            this.notesTextBox5.Multiline = true;
            this.notesTextBox5.Name = "notesTextBox5";
            this.notesTextBox5.Size = new System.Drawing.Size(396, 165);
            this.notesTextBox5.TabIndex = 9;
            this.notesTextBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.notesTextBox5_KeyUp);
            // 
            // guardianNumberTextBox4
            // 
            this.guardianNumberTextBox4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardianNumberTextBox4.Location = new System.Drawing.Point(632, 270);
            this.guardianNumberTextBox4.Name = "guardianNumberTextBox4";
            this.guardianNumberTextBox4.Size = new System.Drawing.Size(177, 30);
            this.guardianNumberTextBox4.TabIndex = 7;
            this.guardianNumberTextBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.guardianNumberTextBox4_KeyUp);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Silver;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(21, 390);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(197, 30);
            this.Label8.TabIndex = 59;
            this.Label8.Text = "Notes";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Silver;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(21, 325);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(197, 30);
            this.Label6.TabIndex = 58;
            this.Label6.Text = "Grade";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Silver;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(462, 270);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(161, 30);
            this.Label7.TabIndex = 57;
            this.Label7.Text = "Guardian No.";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentNameTextBox3
            // 
            this.studentNameTextBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextBox3.Location = new System.Drawing.Point(227, 210);
            this.studentNameTextBox3.Name = "studentNameTextBox3";
            this.studentNameTextBox3.Size = new System.Drawing.Size(396, 30);
            this.studentNameTextBox3.TabIndex = 5;
            this.studentNameTextBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentNameTextBox3_KeyUp);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Silver;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(21, 210);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(197, 30);
            this.Label5.TabIndex = 55;
            this.Label5.Text = "Student Name";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentIdTextBox2
            // 
            this.studentIdTextBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTextBox2.Location = new System.Drawing.Point(633, 150);
            this.studentIdTextBox2.Name = "studentIdTextBox2";
            this.studentIdTextBox2.Size = new System.Drawing.Size(177, 30);
            this.studentIdTextBox2.TabIndex = 4;
            this.studentIdTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idStudentTextBox2_KeyUp);
            // 
            // groupComboBox10
            // 
            this.groupComboBox10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox10.FormattingEnabled = true;
            this.groupComboBox10.Items.AddRange(new object[] {
            "Prim 4A",
            "Prim 4B",
            "Prim 5A",
            "Prim 5B",
            "Prim 6A",
            "Prim 6B",
            "Prep 1A",
            "Prep 1B",
            "Prep 2A",
            "Prep 2B",
            "Prep 3A",
            "Prep 3B",
            "Sec 1A",
            "Sec 1B",
            "Sec 2A",
            "Sec 2B",
            "Sec 3A",
            "Sec 3B"});
            this.groupComboBox10.Location = new System.Drawing.Point(633, 90);
            this.groupComboBox10.Name = "groupComboBox10";
            this.groupComboBox10.Size = new System.Drawing.Size(177, 31);
            this.groupComboBox10.TabIndex = 2;
            this.groupComboBox10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupComboBox10_KeyUp);
            // 
            // placeComboBox9
            // 
            this.placeComboBox9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeComboBox9.FormattingEnabled = true;
            this.placeComboBox9.Items.AddRange(new object[] {
            "Dessouk",
            "Kafr Magar"});
            this.placeComboBox9.Location = new System.Drawing.Point(227, 90);
            this.placeComboBox9.Name = "placeComboBox9";
            this.placeComboBox9.Size = new System.Drawing.Size(177, 31);
            this.placeComboBox9.TabIndex = 1;
            this.placeComboBox9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.placeComboBox9_KeyUp);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Silver;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(462, 150);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(161, 30);
            this.Label4.TabIndex = 49;
            this.Label4.Text = "Student ID";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Silver;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(21, 150);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(197, 30);
            this.Label2.TabIndex = 48;
            this.Label2.Text = "Date ";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Silver;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(462, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(161, 30);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Group";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Silver;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(21, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(197, 30);
            this.Label1.TabIndex = 46;
            this.Label1.Text = "Place";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 30);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyUp);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(21, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 30);
            this.label10.TabIndex = 67;
            this.label10.Text = "Student No.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentNumberTextBox1
            // 
            this.studentNumberTextBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumberTextBox1.Location = new System.Drawing.Point(227, 270);
            this.studentNumberTextBox1.Name = "studentNumberTextBox1";
            this.studentNumberTextBox1.Size = new System.Drawing.Size(177, 30);
            this.studentNumberTextBox1.TabIndex = 6;
            this.studentNumberTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentNumberTextBox1_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(263, 24);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.label9.Size = new System.Drawing.Size(301, 39);
            this.label9.TabIndex = 91;
            this.label9.Text = "Entry Student Data";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 638);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.studentNumberTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.gradeComboBox11);
            this.Controls.Add(this.notesTextBox5);
            this.Controls.Add(this.guardianNumberTextBox4);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.studentNameTextBox3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.studentIdTextBox2);
            this.Controls.Add(this.groupComboBox10);
            this.Controls.Add(this.placeComboBox9);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry Student Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ComboBox gradeComboBox11;
        private System.Windows.Forms.TextBox notesTextBox5;
        private System.Windows.Forms.TextBox guardianNumberTextBox4;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox studentNameTextBox3;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox studentIdTextBox2;
        private System.Windows.Forms.ComboBox groupComboBox10;
        private System.Windows.Forms.ComboBox placeComboBox9;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox studentNumberTextBox1;
        private System.Windows.Forms.Label label9;






    }
}