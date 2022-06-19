namespace El_Kosier
{
    partial class adding_places
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.returnButton.Location = new System.Drawing.Point(235, 78);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.Green;
            this.runButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.runButton.ForeColor = System.Drawing.Color.White;
            this.runButton.Location = new System.Drawing.Point(28, 78);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(111, 35);
            this.runButton.TabIndex = 80;
            this.runButton.Text = "Add";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 88;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adding_places
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 125);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "adding_places";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding Places";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label2;
    }
}