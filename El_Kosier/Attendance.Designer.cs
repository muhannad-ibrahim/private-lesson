namespace El_Kosier
{
    partial class Attendance
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.lectureNumberComboBox3 = new System.Windows.Forms.ComboBox();
            this.studentNameComboBox4 = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.presentRadioButton = new System.Windows.Forms.RadioButton();
            this.absentRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.attendanceMonthComboBox1 = new System.Windows.Forms.ComboBox();
            this.studentIdTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Silver;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(16, 280);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(206, 30);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Lecture Number";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Silver;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(16, 100);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(206, 30);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Student Name";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(350, 410);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 19;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.Return_Click);
            // 
            // lectureNumberComboBox3
            // 
            this.lectureNumberComboBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectureNumberComboBox3.FormattingEnabled = true;
            this.lectureNumberComboBox3.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.lectureNumberComboBox3.Location = new System.Drawing.Point(231, 280);
            this.lectureNumberComboBox3.Name = "lectureNumberComboBox3";
            this.lectureNumberComboBox3.Size = new System.Drawing.Size(48, 31);
            this.lectureNumberComboBox3.TabIndex = 4;
            this.lectureNumberComboBox3.SelectedIndexChanged += new System.EventHandler(this.classNumberComboBox3_SelectedIndexChanged);
            this.lectureNumberComboBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.classNumberComboBox3_KeyUp);
            // 
            // studentNameComboBox4
            // 
            this.studentNameComboBox4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameComboBox4.FormattingEnabled = true;
            this.studentNameComboBox4.Location = new System.Drawing.Point(231, 99);
            this.studentNameComboBox4.Name = "studentNameComboBox4";
            this.studentNameComboBox4.Size = new System.Drawing.Size(297, 31);
            this.studentNameComboBox4.TabIndex = 1;
            this.studentNameComboBox4.SelectedIndexChanged += new System.EventHandler(this.studentNameComboBox4_SelectedIndexChanged);
            this.studentNameComboBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentNameComboBox4_KeyUp);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Silver;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(16, 340);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(206, 30);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Attendance";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // presentRadioButton
            // 
            this.presentRadioButton.AutoSize = true;
            this.presentRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentRadioButton.Location = new System.Drawing.Point(231, 345);
            this.presentRadioButton.Name = "presentRadioButton";
            this.presentRadioButton.Size = new System.Drawing.Size(90, 23);
            this.presentRadioButton.TabIndex = 5;
            this.presentRadioButton.TabStop = true;
            this.presentRadioButton.Text = "Present";
            this.presentRadioButton.UseVisualStyleBackColor = true;
            this.presentRadioButton.CheckedChanged += new System.EventHandler(this.presentRadioButton_CheckedChanged);
            this.presentRadioButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.presentRadioButton_KeyUp);
            // 
            // absentRadioButton
            // 
            this.absentRadioButton.AutoSize = true;
            this.absentRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentRadioButton.Location = new System.Drawing.Point(389, 345);
            this.absentRadioButton.Name = "absentRadioButton";
            this.absentRadioButton.Size = new System.Drawing.Size(84, 23);
            this.absentRadioButton.TabIndex = 6;
            this.absentRadioButton.TabStop = true;
            this.absentRadioButton.Text = "Absent";
            this.absentRadioButton.UseVisualStyleBackColor = true;
            this.absentRadioButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.absentRadioButton_KeyUp);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.ImageKey = "(none)";
            this.saveButton.Location = new System.Drawing.Point(88, 410);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 35);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 30);
            this.label6.TabIndex = 43;
            this.label6.Text = "Attendance Month";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // attendanceMonthComboBox1
            // 
            this.attendanceMonthComboBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceMonthComboBox1.FormattingEnabled = true;
            this.attendanceMonthComboBox1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.attendanceMonthComboBox1.Location = new System.Drawing.Point(232, 220);
            this.attendanceMonthComboBox1.Name = "attendanceMonthComboBox1";
            this.attendanceMonthComboBox1.Size = new System.Drawing.Size(48, 31);
            this.attendanceMonthComboBox1.TabIndex = 3;
            this.attendanceMonthComboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.monthNumberComboBox1_KeyUp);
            // 
            // studentIdTextBox2
            // 
            this.studentIdTextBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTextBox2.Location = new System.Drawing.Point(232, 160);
            this.studentIdTextBox2.Name = "studentIdTextBox2";
            this.studentIdTextBox2.Size = new System.Drawing.Size(177, 30);
            this.studentIdTextBox2.TabIndex = 2;
            this.studentIdTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idStudentTextBox2_KeyUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 89;
            this.label1.Text = "Student ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(134, 24);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.label8.Size = new System.Drawing.Size(280, 39);
            this.label8.TabIndex = 90;
            this.label8.Text = "Entry Attendance";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 474);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.studentIdTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attendanceMonthComboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.absentRadioButton);
            this.Controls.Add(this.presentRadioButton);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.studentNameComboBox4);
            this.Controls.Add(this.lectureNumberComboBox3);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.MaximizeBox = false;
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ComboBox lectureNumberComboBox3;
        private System.Windows.Forms.ComboBox studentNameComboBox4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.RadioButton presentRadioButton;
        private System.Windows.Forms.RadioButton absentRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox attendanceMonthComboBox1;
        private System.Windows.Forms.TextBox studentIdTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;

    }
}