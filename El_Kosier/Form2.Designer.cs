namespace El_Kosier
{
    partial class Form2
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
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.classNumberComboBox3 = new System.Windows.Forms.ComboBox();
            this.monthComboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filterByComboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupComboBox18 = new System.Windows.Forms.ComboBox();
            this.placeComboBox15 = new System.Windows.Forms.ComboBox();
            this.studentNameComboBox17 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(767, 287);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 309);
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
            this.dataGridView1.Location = new System.Drawing.Point(8, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 313);
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
            this.textBox1.Location = new System.Drawing.Point(700, 235);
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
            this.totalLabel.Location = new System.Drawing.Point(616, 235);
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
            this.previewButton.Location = new System.Drawing.Point(339, 622);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(111, 35);
            this.previewButton.TabIndex = 101;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = false;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.Green;
            this.runButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.runButton.ForeColor = System.Drawing.Color.White;
            this.runButton.Location = new System.Drawing.Point(21, 622);
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
            this.returnButton.Location = new System.Drawing.Point(667, 622);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 99;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Silver;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(14, 185);
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
            this.Label3.Location = new System.Drawing.Point(14, 135);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(197, 30);
            this.Label3.TabIndex = 89;
            this.Label3.Text = "Place";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Silver;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(14, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(197, 30);
            this.Label1.TabIndex = 87;
            this.Label1.Text = "Student Name";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classNumberComboBox3
            // 
            this.classNumberComboBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNumberComboBox3.FormattingEnabled = true;
            this.classNumberComboBox3.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.classNumberComboBox3.Location = new System.Drawing.Point(617, 185);
            this.classNumberComboBox3.Name = "classNumberComboBox3";
            this.classNumberComboBox3.Size = new System.Drawing.Size(48, 31);
            this.classNumberComboBox3.TabIndex = 115;
            this.classNumberComboBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.classNumberComboBox3_KeyUp);
            // 
            // monthComboBox1
            // 
            this.monthComboBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox1.FormattingEnabled = true;
            this.monthComboBox1.Items.AddRange(new object[] {
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
            this.monthComboBox1.Location = new System.Drawing.Point(617, 135);
            this.monthComboBox1.Name = "monthComboBox1";
            this.monthComboBox1.Size = new System.Drawing.Size(48, 31);
            this.monthComboBox1.TabIndex = 114;
            this.monthComboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.monthComboBox1_KeyUp);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(407, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 30);
            this.label6.TabIndex = 113;
            this.label6.Text = "Class Number";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(407, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 30);
            this.label5.TabIndex = 112;
            this.label5.Text = "Month";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterByComboBox1
            // 
            this.filterByComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.filterByComboBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByComboBox1.FormattingEnabled = true;
            this.filterByComboBox1.Items.AddRange(new object[] {
            "",
            "Present",
            "Absent",
            "Payment",
            "Exam"});
            this.filterByComboBox1.Location = new System.Drawing.Point(219, 235);
            this.filterByComboBox1.Name = "filterByComboBox1";
            this.filterByComboBox1.Size = new System.Drawing.Size(142, 31);
            this.filterByComboBox1.TabIndex = 111;
            this.filterByComboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterByComboBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 30);
            this.label2.TabIndex = 110;
            this.label2.Text = "Filter By";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupComboBox18.Location = new System.Drawing.Point(219, 184);
            this.groupComboBox18.Name = "groupComboBox18";
            this.groupComboBox18.Size = new System.Drawing.Size(142, 31);
            this.groupComboBox18.TabIndex = 109;
            this.groupComboBox18.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupComboBox18_KeyUp);
            // 
            // placeComboBox15
            // 
            this.placeComboBox15.BackColor = System.Drawing.SystemColors.Window;
            this.placeComboBox15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeComboBox15.FormattingEnabled = true;
            this.placeComboBox15.Location = new System.Drawing.Point(219, 84);
            this.placeComboBox15.Name = "placeComboBox15";
            this.placeComboBox15.Size = new System.Drawing.Size(297, 31);
            this.placeComboBox15.TabIndex = 107;
            this.placeComboBox15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.placeComboBox15_KeyUp);
            // 
            // studentNameComboBox17
            // 
            this.studentNameComboBox17.BackColor = System.Drawing.Color.White;
            this.studentNameComboBox17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameComboBox17.FormattingEnabled = true;
            this.studentNameComboBox17.Items.AddRange(new object[] {
            "Dessouk",
            "Kafr Magar"});
            this.studentNameComboBox17.Location = new System.Drawing.Point(219, 134);
            this.studentNameComboBox17.Name = "studentNameComboBox17";
            this.studentNameComboBox17.Size = new System.Drawing.Size(141, 31);
            this.studentNameComboBox17.TabIndex = 108;
            this.studentNameComboBox17.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentNameComboBox17_KeyUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 679);
            this.Controls.Add(this.classNumberComboBox3);
            this.Controls.Add(this.monthComboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterByComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupComboBox18);
            this.Controls.Add(this.placeComboBox15);
            this.Controls.Add(this.studentNameComboBox17);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchStudentTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
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
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox classNumberComboBox3;
        private System.Windows.Forms.ComboBox monthComboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filterByComboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupComboBox18;
        private System.Windows.Forms.ComboBox placeComboBox15;
        private System.Windows.Forms.ComboBox studentNameComboBox17;
    }
}