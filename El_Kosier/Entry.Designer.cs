namespace El_Kosier
{
    partial class Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.studentDataButton4 = new System.Windows.Forms.Button();
            this.paymentButton6 = new System.Windows.Forms.Button();
            this.attendanceButton5 = new System.Windows.Forms.Button();
            this.examsButton7 = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.placesButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.addNewSourceCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // studentDataButton4
            // 
            this.studentDataButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.studentDataButton4, "studentDataButton4");
            this.studentDataButton4.ForeColor = System.Drawing.Color.Green;
            this.studentDataButton4.Name = "studentDataButton4";
            this.studentDataButton4.UseVisualStyleBackColor = false;
            this.studentDataButton4.Click += new System.EventHandler(this.button1_Click);
            // 
            // paymentButton6
            // 
            this.paymentButton6.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.paymentButton6, "paymentButton6");
            this.paymentButton6.ForeColor = System.Drawing.Color.Maroon;
            this.paymentButton6.Name = "paymentButton6";
            this.paymentButton6.UseVisualStyleBackColor = false;
            this.paymentButton6.Click += new System.EventHandler(this.button2_Click);
            // 
            // attendanceButton5
            // 
            this.attendanceButton5.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.attendanceButton5, "attendanceButton5");
            this.attendanceButton5.ForeColor = System.Drawing.Color.Blue;
            this.attendanceButton5.Name = "attendanceButton5";
            this.attendanceButton5.UseVisualStyleBackColor = false;
            this.attendanceButton5.Click += new System.EventHandler(this.button3_Click);
            // 
            // examsButton7
            // 
            this.examsButton7.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.examsButton7, "examsButton7");
            this.examsButton7.ForeColor = System.Drawing.Color.Indigo;
            this.examsButton7.Name = "examsButton7";
            this.examsButton7.UseVisualStyleBackColor = false;
            this.examsButton7.Click += new System.EventHandler(this.button4_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.returnButton, "returnButton");
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Name = "returnButton";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // placesButton
            // 
            this.placesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.placesButton, "placesButton");
            this.placesButton.ForeColor = System.Drawing.Color.Black;
            this.placesButton.Name = "placesButton";
            this.placesButton.UseVisualStyleBackColor = false;
            this.placesButton.Click += new System.EventHandler(this.placesButton_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.groupsButton, "groupsButton");
            this.groupsButton.ForeColor = System.Drawing.Color.Crimson;
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.UseVisualStyleBackColor = false;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // addNewSourceCheckBox
            // 
            resources.ApplyResources(this.addNewSourceCheckBox, "addNewSourceCheckBox");
            this.addNewSourceCheckBox.Name = "addNewSourceCheckBox";
            this.addNewSourceCheckBox.UseVisualStyleBackColor = true;
            this.addNewSourceCheckBox.CheckedChanged += new System.EventHandler(this.addNewSourceCheckBox_CheckedChanged);
            // 
            // Entry
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.addNewSourceCheckBox);
            this.Controls.Add(this.groupsButton);
            this.Controls.Add(this.placesButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.examsButton7);
            this.Controls.Add(this.attendanceButton5);
            this.Controls.Add(this.paymentButton6);
            this.Controls.Add(this.studentDataButton4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Entry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentDataButton4;
        private System.Windows.Forms.Button paymentButton6;
        private System.Windows.Forms.Button attendanceButton5;
        private System.Windows.Forms.Button examsButton7;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button placesButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.CheckBox addNewSourceCheckBox;
    }
}