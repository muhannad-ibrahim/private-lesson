namespace El_Kosier
{
    partial class Exam
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
            this.resultTextBox7 = new System.Windows.Forms.TextBox();
            this.studentNameComboBox14 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.examMonthComboBox1 = new System.Windows.Forms.ComboBox();
            this.studentIdTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultTextBox7
            // 
            this.resultTextBox7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox7.Location = new System.Drawing.Point(201, 310);
            this.resultTextBox7.Name = "resultTextBox7";
            this.resultTextBox7.Size = new System.Drawing.Size(120, 30);
            this.resultTextBox7.TabIndex = 4;
            this.resultTextBox7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.resultTextBox7_KeyUp);
            // 
            // studentNameComboBox14
            // 
            this.studentNameComboBox14.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.studentNameComboBox14.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.studentNameComboBox14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameComboBox14.FormattingEnabled = true;
            this.studentNameComboBox14.Location = new System.Drawing.Point(201, 100);
            this.studentNameComboBox14.Name = "studentNameComboBox14";
            this.studentNameComboBox14.Size = new System.Drawing.Size(297, 31);
            this.studentNameComboBox14.TabIndex = 1;
            this.studentNameComboBox14.SelectedIndexChanged += new System.EventHandler(this.studentNameComboBox14_SelectedIndexChanged);
            this.studentNameComboBox14.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentNameComboBox14_KeyUp);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Silver;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(21, 100);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(170, 30);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "Student Name";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Silver;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(20, 310);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(170, 30);
            this.Label4.TabIndex = 38;
            this.Label4.Text = "Result";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(366, 380);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 45;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.Return_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(65, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 35);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 30);
            this.label5.TabIndex = 85;
            this.label5.Text = "Exam Month";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examMonthComboBox1
            // 
            this.examMonthComboBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examMonthComboBox1.FormattingEnabled = true;
            this.examMonthComboBox1.Items.AddRange(new object[] {
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
            this.examMonthComboBox1.Location = new System.Drawing.Point(202, 240);
            this.examMonthComboBox1.Name = "examMonthComboBox1";
            this.examMonthComboBox1.Size = new System.Drawing.Size(48, 31);
            this.examMonthComboBox1.TabIndex = 3;
            this.examMonthComboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.examMonthComboBox1_KeyUp);
            // 
            // studentIdTextBox2
            // 
            this.studentIdTextBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTextBox2.Location = new System.Drawing.Point(202, 170);
            this.studentIdTextBox2.Name = "studentIdTextBox2";
            this.studentIdTextBox2.ReadOnly = true;
            this.studentIdTextBox2.Size = new System.Drawing.Size(177, 30);
            this.studentIdTextBox2.TabIndex = 2;
            this.studentIdTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idStudentTextBox2_KeyUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 91;
            this.label1.Text = "Student ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(125, 29);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.label8.Size = new System.Drawing.Size(293, 39);
            this.label8.TabIndex = 92;
            this.label8.Text = "Entry Exam Result";
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 442);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.studentIdTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.examMonthComboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.resultTextBox7);
            this.Controls.Add(this.studentNameComboBox14);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.MaximizeBox = false;
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox7;
        private System.Windows.Forms.ComboBox studentNameComboBox14;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox examMonthComboBox1;
        private System.Windows.Forms.TextBox studentIdTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}