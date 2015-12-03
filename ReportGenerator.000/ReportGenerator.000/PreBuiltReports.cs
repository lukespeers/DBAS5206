using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportGenerator._000
{
    public partial class frmPrebuiltReports : Form
    {
        public frmPrebuiltReports()
        {
            InitializeComponent();
        }

        private void btnPatientPhysicianReport_Click(object sender, EventArgs e)
        {
            frmPatientPhysicians aReport = new frmPatientPhysicians();
            aReport.Show();
        }

        private void btnRoomUtilizationReport_Click(object sender, EventArgs e)
        {
            //frmRoomUtilization aReport = new frmRoomUtilization();
            //aReport.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
