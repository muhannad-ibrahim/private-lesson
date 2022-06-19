namespace El_Kosier
{
    partial class Form1
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchStudentTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.absentRadioButton = new System.Windows.Forms.RadioButton();
            this.presentRadioButton = new System.Windows.Forms.RadioButton();
            this.resultCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentCheckBox = new System.Windows.Forms.CheckBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.groupComboBox18 = new System.Windows.Forms.ComboBox();
            this.placeComboBox15 = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.studentNameComboBox17 = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(767, 290);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 366);
            this.vScrollBar1.TabIndex = 106;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(1, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 369);
            this.dataGridView1.TabIndex = 105;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID Student";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Place";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Group";
            this.Column4.Name = "Column4";
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Present";
            this.Column5.Name = "Column5";
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Absent";
            this.Column6.Name = "Column6";
            this.Column6.Width = 75;
            // 
            // searchStudentTextBox
            // 
            this.searchStudentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchStudentTextBox.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudentTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchStudentTextBox.Location = new System.Drawing.Point(225, 16);
            this.searchStudentTextBox.Multiline = true;
            this.searchStudentTextBox.Name = "searchStudentTextBox";
            this.searchStudentTextBox.Size = new System.Drawing.Size(297, 41);
            this.searchStudentTextBox.TabIndex = 104;
            this.searchStudentTextBox.Text = "Search For Students";
            this.searchStudentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Violet;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(698, 235);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 30);
            this.textBox1.TabIndex = 103;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Silver;
            this.totalLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.totalLabel.Location = new System.Drawing.Point(614, 235);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(85, 30);
            this.totalLabel.TabIndex = 102;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previewButton
            // 
            this.previewButton.BackColor = System.Drawing.Color.Red;
            this.previewButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.previewButton.ForeColor = System.Drawing.Color.White;
            this.previewButton.Location = new System.Drawing.Point(339, 673);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(111, 35);
            this.previewButton.TabIndex = 101;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = false;
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.Green;
            this.runButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.runButton.ForeColor = System.Drawing.Color.White;
            this.runButton.Location = new System.Drawing.Point(20, 673);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(111, 35);
            this.runButton.TabIndex = 100;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(667, 673);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 99;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            // 
            // absentRadioButton
            // 
            this.absentRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentRadioButton.Location = new System.Drawing.Point(386, 241);
            this.absentRadioButton.Name = "absentRadioButton";
            this.absentRadioButton.Size = new System.Drawing.Size(84, 23);
            this.absentRadioButton.TabIndex = 98;
            this.absentRadioButton.TabStop = true;
            this.absentRadioButton.Text = "Absent";
            this.absentRadioButton.UseVisualStyleBackColor = true;
            // 
            // presentRadioButton
            // 
            this.presentRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentRadioButton.Location = new System.Drawing.Point(228, 241);
            this.presentRadioButton.Name = "presentRadioButton";
            this.presentRadioButton.Size = new System.Drawing.Size(90, 23);
            this.presentRadioButton.TabIndex = 97;
            this.presentRadioButton.TabStop = true;
            this.presentRadioButton.Text = "Present";
            this.presentRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultCheckBox
            // 
            this.resultCheckBox.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultCheckBox.Location = new System.Drawing.Point(667, 192);
            this.resultCheckBox.Name = "resultCheckBox";
            this.resultCheckBox.Size = new System.Drawing.Size(15, 14);
            this.resultCheckBox.TabIndex = 96;
            this.resultCheckBox.UseVisualStyleBackColor = true;
            // 
            // paymentCheckBox
            // 
            this.paymentCheckBox.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentCheckBox.Location = new System.Drawing.Point(667, 136);
            this.paymentCheckBox.Name = "paymentCheckBox";
            this.paymentCheckBox.Size = new System.Drawing.Size(15, 30);
            this.paymentCheckBox.TabIndex = 95;
            this.paymentCheckBox.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Silver;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(431, 185);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(197, 30);
            this.Label7.TabIndex = 94;
            this.Label7.Text = "Result";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Silver;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(431, 135);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(197, 30);
            this.Label6.TabIndex = 93;
            this.Label6.Text = "Payment";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Silver;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(20, 235);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(197, 30);
            this.Label5.TabIndex = 92;
            this.Label5.Text = "Attendance";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupComboBox18
            // 
            this.groupComboBox18.BackColor = System.Drawing.SystemColors.Window;
            this.groupComboBox18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox18.FormattingEnabled = true;
            this.groupComboBox18.Items.AddRange(new object[] {
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
            this.groupComboBox18.Location = new System.Drawing.Point(227, 185);
            this.groupComboBox18.Name = "groupComboBox18";
            this.groupComboBox18.Size = new System.Drawing.Size(142, 31);
            this.groupComboBox18.TabIndex = 91;
            // 
            // placeComboBox15
            // 
            this.placeComboBox15.BackColor = System.Drawing.SystemColors.Window;
            this.placeComboBox15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeComboBox15.FormattingEnabled = true;
            this.placeComboBox15.Location = new System.Drawing.Point(227, 85);
            this.placeComboBox15.Name = "placeComboBox15";
            this.placeComboBox15.Size = new System.Drawing.Size(297, 31);
            this.placeComboBox15.TabIndex = 86;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Silver;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(20, 185);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(197, 30);
            this.Label4.TabIndex = 90;
            this.Label4.Text = "Group";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Silver;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(20, 135);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(197, 30);
            this.Label3.TabIndex = 89;
            this.Label3.Text = "Place";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentNameComboBox17
            // 
            this.studentNameComboBox17.BackColor = System.Drawing.Color.White;
            this.studentNameComboBox17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameComboBox17.FormattingEnabled = true;
            this.studentNameComboBox17.Items.AddRange(new object[] {
            "Dessouk",
            "Kafr Magar"});
            this.studentNameComboBox17.Location = new System.Drawing.Point(227, 135);
            this.studentNameComboBox17.Name = "studentNameComboBox17";
            this.studentNameComboBox17.Size = new System.Drawing.Size(141, 31);
            this.studentNameComboBox17.TabIndex = 88;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Silver;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(20, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(197, 30);
            this.Label1.TabIndex = 87;
            this.Label1.Text = "Student Name";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 724);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchStudentTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.absentRadioButton);
            this.Controls.Add(this.presentRadioButton);
            this.Controls.Add(this.resultCheckBox);
            this.Controls.Add(this.paymentCheckBox);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.groupComboBox18);
            this.Controls.Add(this.placeComboBox15);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.studentNameComboBox17);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox searchStudentTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.RadioButton absentRadioButton;
        private System.Windows.Forms.RadioButton presentRadioButton;
        private System.Windows.Forms.CheckBox resultCheckBox;
        private System.Windows.Forms.CheckBox paymentCheckBox;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ComboBox groupComboBox18;
        private System.Windows.Forms.ComboBox placeComboBox15;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ComboBox studentNameComboBox17;
        private System.Windows.Forms.Label Label1;
    }
}