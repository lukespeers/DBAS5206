using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportGenerator._000
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnCustomReports_Click(object sender, EventArgs e)
        {
           // frmCustomReports customReports = new frmCustomReports();
           // customReports.Show();
        }

        private void btnPrebuiltReports_Click(object sender, EventArgs e)
        {
            frmPrebuiltReports prebuiltReports = new frmPrebuiltReports();
            prebuiltReports.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
