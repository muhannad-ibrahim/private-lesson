namespace El_Kosier
{
    partial class adding_groups
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
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.placeComboBox9 = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Green;
            this.addButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(24, 135);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 35);
            this.addButton.TabIndex = 83;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox1.Location = new System.Drawing.Point(134, 79);
            this.nameTextBox1.Multiline = true;
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(187, 33);
            this.nameTextBox1.TabIndex = 2;
            this.nameTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            this.returnButton.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.returnButton.Location = new System.Drawing.Point(240, 135);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(111, 35);
            this.returnButton.TabIndex = 84;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click_1);
            // 
            // placeComboBox9
            // 
            this.placeComboBox9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeComboBox9.FormattingEnabled = true;
            this.placeComboBox9.Items.AddRange(new object[] {
            "Dessouk",
            "Kafr Magar"});
            this.placeComboBox9.Location = new System.Drawing.Point(134, 30);
            this.placeComboBox9.Name = "placeComboBox9";
            this.placeComboBox9.Size = new System.Drawing.Size(187, 31);
            this.placeComboBox9.TabIndex = 1;
            this.placeComboBox9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.placeComboBox9_KeyUp);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Silver;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(13, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(101, 30);
            this.Label1.TabIndex = 85;
            this.Label1.Text = "Place";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 87;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adding_groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(375, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.placeComboBox9);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameTextBox1);
            this.MaximizeBox = false;
            this.Name = "adding_groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding Groups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ComboBox placeComboBox9;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
    }
}