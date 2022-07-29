namespace El_Kosier
{
    partial class StudentAttendance
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.absentTextBox18 = new System.Windows.Forms.TextBox();
            this.presentTextBox17 = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(448, 6);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 466);
            this.vScrollBar1.TabIndex = 58;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 469);
            this.dataGridView1.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Violet;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(248, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 30);
            this.label11.TabIndex = 64;
            this.label11.Text = "Absent";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 30);
            this.label10.TabIndex = 63;
            this.label10.Text = "Present";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // absentTextBox18
            // 
            this.absentTextBox18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.absentTextBox18.Location = new System.Drawing.Point(247, 510);
            this.absentTextBox18.Multiline = true;
            this.absentTextBox18.Name = "absentTextBox18";
            this.absentTextBox18.Size = new System.Drawing.Size(221, 30);
            this.absentTextBox18.TabIndex = 62;
            this.absentTextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // presentTextBox17
            // 
            this.presentTextBox17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.presentTextBox17.Location = new System.Drawing.Point(6, 510);
            this.presentTextBox17.Multiline = true;
            this.presentTextBox17.Name = "presentTextBox17";
            this.presentTextBox17.Size = new System.Drawing.Size(221, 30);
            this.presentTextBox17.TabIndex = 61;
            this.presentTextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(351, 549);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 65;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 596);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.absentTextBox18);
            this.Controls.Add(this.presentTextBox17);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "StudentAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox absentTextBox18;
        private System.Windows.Forms.TextBox presentTextBox17;
        private System.Windows.Forms.Button returnButton;
    }
}

