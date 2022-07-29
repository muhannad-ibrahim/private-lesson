namespace El_Kosier
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.returnButton = new System.Windows.Forms.Button();
            this.groupComboBox18 = new System.Windows.Forms.ComboBox();
            this.studentNameComboBox15 = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.placeComboBox17 = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.filterByComboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthComboBox1 = new System.Windows.Forms.ComboBox();
            this.lectureNumberComboBox3 = new System.Windows.Forms.ComboBox();
            this.refreshButton1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.studentIdTextBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(665, 621);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 78;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // groupComboBox18
            // 
            this.groupComboBox18.BackColor = System.Drawing.SystemColors.Window;
            this.groupComboBox18.Enabled = false;
            this.groupComboBox18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox18.FormattingEnabled = true;
            this.groupComboBox18.Location = new System.Drawing.Point(218, 227);
            this.groupComboBox18.Name = "groupComboBox18";
            this.groupComboBox18.Size = new System.Drawing.Size(142, 31);
            this.groupComboBox18.TabIndex = 3;
            this.groupComboBox18.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupComboBox18_KeyUp);
            // 
            // studentNameComboBox15
            // 
            this.studentNameComboBox15.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.studentNameComboBox15.BackColor = System.Drawing.SystemColors.Window;
            this.studentNameComboBox15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameComboBox15.FormattingEnabled = true;
            this.studentNameComboBox15.ItemHeight = 23;
            this.studentNameComboBox15.Location = new System.Drawing.Point(218, 77);
            this.studentNameComboBox15.Name = "studentNameComboBox15";
            this.studentNameComboBox15.Size = new System.Drawing.Size(387, 31);
            this.studentNameComboBox15.TabIndex = 0;
            this.studentNameComboBox15.SelectedIndexChanged += new System.EventHandler(this.studentNameComboBox15_SelectedIndexChanged);
            this.studentNameComboBox15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentNameComboBox17_KeyUp);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Silver;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(11, 227);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(197, 30);
            this.Label4.TabIndex = 69;
            this.Label4.Text = "Group";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Silver;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(11, 177);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(197, 30);
            this.Label3.TabIndex = 68;
            this.Label3.Text = "Place";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // placeComboBox17
            // 
            this.placeComboBox17.BackColor = System.Drawing.Color.White;
            this.placeComboBox17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeComboBox17.FormattingEnabled = true;
            this.placeComboBox17.ItemHeight = 23;
            this.placeComboBox17.Location = new System.Drawing.Point(218, 177);
            this.placeComboBox17.Name = "placeComboBox17";
            this.placeComboBox17.Size = new System.Drawing.Size(141, 31);
            this.placeComboBox17.TabIndex = 2;
            this.placeComboBox17.SelectedIndexChanged += new System.EventHandler(this.placeComboBox17_SelectedIndexChanged);
            this.placeComboBox17.KeyUp += new System.Windows.Forms.KeyEventHandler(this.placeComboBox17_KeyUp);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Silver;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(11, 77);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(197, 30);
            this.Label1.TabIndex = 64;
            this.Label1.Text = "Student Name";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.Green;
            this.runButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.runButton.ForeColor = System.Drawing.Color.White;
            this.runButton.Location = new System.Drawing.Point(23, 621);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(111, 35);
            this.runButton.TabIndex = 5;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.BackColor = System.Drawing.Color.Red;
            this.previewButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.previewButton.ForeColor = System.Drawing.Color.White;
            this.previewButton.Location = new System.Drawing.Point(237, 621);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(111, 35);
            this.previewButton.TabIndex = 6;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = false;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Silver;
            this.totalLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.totalLabel.Location = new System.Drawing.Point(631, 277);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(70, 30);
            this.totalLabel.TabIndex = 81;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Violet;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(701, 277);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 30);
            this.textBox1.TabIndex = 40;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(785, 286);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(767, 316);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 283);
            this.vScrollBar1.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 30);
            this.label2.TabIndex = 86;
            this.label2.Text = "Filter By";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterByComboBox1
            // 
            this.filterByComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.filterByComboBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByComboBox1.FormattingEnabled = true;
            this.filterByComboBox1.Items.AddRange(new object[] {
            " ",
            "Attendance",
            "Payment",
            "Exam"});
            this.filterByComboBox1.Location = new System.Drawing.Point(218, 277);
            this.filterByComboBox1.Name = "filterByComboBox1";
            this.filterByComboBox1.Size = new System.Drawing.Size(142, 31);
            this.filterByComboBox1.TabIndex = 4;
            this.filterByComboBox1.SelectedIndexChanged += new System.EventHandler(this.filterByComboBox1_SelectedIndexChanged);
            this.filterByComboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterByComboBox1_KeyUp);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(408, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 30);
            this.label5.TabIndex = 88;
            this.label5.Text = "Month";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(408, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 30);
            this.label6.TabIndex = 89;
            this.label6.Text = "Lecture Number";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // monthComboBox1
            // 
            this.monthComboBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox1.FormattingEnabled = true;
            this.monthComboBox1.Items.AddRange(new object[] {
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
            this.monthComboBox1.Location = new System.Drawing.Point(618, 126);
            this.monthComboBox1.Name = "monthComboBox1";
            this.monthComboBox1.Size = new System.Drawing.Size(62, 31);
            this.monthComboBox1.TabIndex = 5;
            this.monthComboBox1.Visible = false;
            this.monthComboBox1.SelectedIndexChanged += new System.EventHandler(this.monthComboBox1_SelectedIndexChanged);
            this.monthComboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.monthComboBox1_KeyUp);
            // 
            // lectureNumberComboBox3
            // 
            this.lectureNumberComboBox3.Enabled = false;
            this.lectureNumberComboBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectureNumberComboBox3.FormattingEnabled = true;
            this.lectureNumberComboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.lectureNumberComboBox3.Location = new System.Drawing.Point(618, 176);
            this.lectureNumberComboBox3.Name = "lectureNumberComboBox3";
            this.lectureNumberComboBox3.Size = new System.Drawing.Size(62, 31);
            this.lectureNumberComboBox3.TabIndex = 7;
            this.lectureNumberComboBox3.Visible = false;
            this.lectureNumberComboBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lectureNumberComboBox3_KeyUp);
            // 
            // refreshButton1
            // 
            this.refreshButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshButton1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.refreshButton1.ForeColor = System.Drawing.Color.White;
            this.refreshButton1.Location = new System.Drawing.Point(451, 621);
            this.refreshButton1.Name = "refreshButton1";
            this.refreshButton1.Size = new System.Drawing.Size(111, 35);
            this.refreshButton1.TabIndex = 93;
            this.refreshButton1.Text = "Refresh";
            this.refreshButton1.UseVisualStyleBackColor = false;
            this.refreshButton1.Click += new System.EventHandler(this.refreshButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(243, 18);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.label8.Size = new System.Drawing.Size(313, 39);
            this.label8.TabIndex = 94;
            this.label8.Text = "Search For Students";
            // 
            // studentIdTextBox10
            // 
            this.studentIdTextBox10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTextBox10.Location = new System.Drawing.Point(217, 127);
            this.studentIdTextBox10.Name = "studentIdTextBox10";
            this.studentIdTextBox10.Size = new System.Drawing.Size(141, 30);
            this.studentIdTextBox10.TabIndex = 95;
            this.studentIdTextBox10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentIdTextBox10_KeyUp);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 30);
            this.label9.TabIndex = 96;
            this.label9.Text = "Student ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 679);
            this.Controls.Add(this.studentIdTextBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.refreshButton1);
            this.Controls.Add(this.lectureNumberComboBox3);
            this.Controls.Add(this.monthComboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterByComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.groupComboBox18);
            this.Controls.Add(this.studentNameComboBox15);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.placeComboBox17);
            this.Controls.Add(this.Label1);
            this.MaximizeBox = false;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ComboBox groupComboBox18;
        private System.Windows.Forms.ComboBox studentNameComboBox15;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ComboBox placeComboBox17;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filterByComboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox monthComboBox1;
        private System.Windows.Forms.ComboBox lectureNumberComboBox3;
        private System.Windows.Forms.Button refreshButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox studentIdTextBox10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}