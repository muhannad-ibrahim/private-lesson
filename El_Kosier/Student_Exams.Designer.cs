namespace El_Kosier
{
    partial class StudentExams
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
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(250, 8);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(20, 423);
            this.vScrollBar3.TabIndex = 65;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(265, 428);
            this.dataGridView3.TabIndex = 64;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(156, 452);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 66;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // StudentExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 499);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.dataGridView3);
            this.MaximizeBox = false;
            this.Name = "StudentExams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Exams";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button returnButton;
    }
}

