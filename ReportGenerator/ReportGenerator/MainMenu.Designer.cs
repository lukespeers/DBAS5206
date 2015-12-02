namespace ReportGenerator
{
    partial class MainMenu
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
            this.btnPrebuiltReports = new System.Windows.Forms.Button();
            this.btnCustomReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrebuiltReports
            // 
            this.btnPrebuiltReports.Location = new System.Drawing.Point(76, 102);
            this.btnPrebuiltReports.Name = "btnPrebuiltReports";
            this.btnPrebuiltReports.Size = new System.Drawing.Size(139, 42);
            this.btnPrebuiltReports.TabIndex = 1;
            this.btnPrebuiltReports.Text = "&Pre-built Reports";
            this.btnPrebuiltReports.UseVisualStyleBackColor = true;
            this.btnPrebuiltReports.Click += new System.EventHandler(this.btnPrebuiltReports_Click);
            // 
            // btnCustomReports
            // 
            this.btnCustomReports.Location = new System.Drawing.Point(76, 24);
            this.btnCustomReports.Name = "btnCustomReports";
            this.btnCustomReports.Size = new System.Drawing.Size(139, 42);
            this.btnCustomReports.TabIndex = 0;
            this.btnCustomReports.Text = "&Custom Reports";
            this.btnCustomReports.UseVisualStyleBackColor = true;
            this.btnCustomReports.Click += new System.EventHandler(this.btnCustomReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(76, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReportGenerator.Properties.Resources.MVCH_FormBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(296, 270);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomReports);
            this.Controls.Add(this.btnPrebuiltReports);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrebuiltReports;
        private System.Windows.Forms.Button btnCustomReports;
        private System.Windows.Forms.Button btnExit;
    }
}

