﻿namespace ReportGenerator._000
{
    partial class frmPrebuiltReports
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRoomUtilizationReport = new System.Windows.Forms.Button();
            this.btnPatientPhysicianReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(121, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRoomUtilizationReport
            // 
            this.btnRoomUtilizationReport.Location = new System.Drawing.Point(121, 52);
            this.btnRoomUtilizationReport.Name = "btnRoomUtilizationReport";
            this.btnRoomUtilizationReport.Size = new System.Drawing.Size(139, 42);
            this.btnRoomUtilizationReport.TabIndex = 3;
            this.btnRoomUtilizationReport.Text = "&Room Utilization Report";
            this.btnRoomUtilizationReport.UseVisualStyleBackColor = true;
            this.btnRoomUtilizationReport.Click += new System.EventHandler(this.btnRoomUtilizationReport_Click);
            // 
            // btnPatientPhysicianReport
            // 
            this.btnPatientPhysicianReport.Location = new System.Drawing.Point(121, 133);
            this.btnPatientPhysicianReport.Name = "btnPatientPhysicianReport";
            this.btnPatientPhysicianReport.Size = new System.Drawing.Size(139, 42);
            this.btnPatientPhysicianReport.TabIndex = 4;
            this.btnPatientPhysicianReport.Text = "&Patient - Physicial Report";
            this.btnPatientPhysicianReport.UseVisualStyleBackColor = true;
            this.btnPatientPhysicianReport.Click += new System.EventHandler(this.btnPatientPhysicianReport_Click);
            // 
            // frmPrebuiltReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReportGenerator._000.Properties.Resources.MVCH_FormBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 341);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRoomUtilizationReport);
            this.Controls.Add(this.btnPatientPhysicianReport);
            this.DoubleBuffered = true;
            this.Name = "frmPrebuiltReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pre-Built Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRoomUtilizationReport;
        private System.Windows.Forms.Button btnPatientPhysicianReport;
    }
}