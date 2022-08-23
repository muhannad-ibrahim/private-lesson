namespace El_Kosier
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.entryButton1 = new System.Windows.Forms.Button();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton3 = new System.Windows.Forms.Button();
            this.deleteAllButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryButton1
            // 
            this.entryButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.entryButton1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.entryButton1, "entryButton1");
            this.entryButton1.ForeColor = System.Drawing.Color.ForestGreen;
            this.entryButton1.Name = "entryButton1";
            this.entryButton1.UseVisualStyleBackColor = false;
            this.entryButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton2
            // 
            this.searchButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.searchButton2, "searchButton2");
            this.searchButton2.ForeColor = System.Drawing.Color.Blue;
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.UseVisualStyleBackColor = false;
            this.searchButton2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Name = "label1";
            this.label1.UseWaitCursor = true;
            // 
            // exitButton3
            // 
            this.exitButton3.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.exitButton3, "exitButton3");
            this.exitButton3.ForeColor = System.Drawing.Color.White;
            this.exitButton3.Name = "exitButton3";
            this.exitButton3.UseVisualStyleBackColor = false;
            this.exitButton3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // deleteAllButton4
            // 
            this.deleteAllButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.deleteAllButton4, "deleteAllButton4");
            this.deleteAllButton4.ForeColor = System.Drawing.Color.Red;
            this.deleteAllButton4.Name = "deleteAllButton4";
            this.deleteAllButton4.UseVisualStyleBackColor = false;
            this.deleteAllButton4.Click += new System.EventHandler(this.deleteAllButton4_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Kosier.Properties.Resources._5166950;
            this.Controls.Add(this.deleteAllButton4);
            this.Controls.Add(this.exitButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton2);
            this.Controls.Add(this.entryButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton2;
        private System.Windows.Forms.Button entryButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton3;
        private System.Windows.Forms.Button deleteAllButton4;
    }
}

