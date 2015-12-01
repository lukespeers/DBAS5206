using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCH
{
    public partial class frmReportDisplay : Form
    {
        public frmReportDisplay()
        {
            InitializeComponent();
        }

        // Data Set object
        //private DBASDataSet hospitalInfoDataSet;
        // Table Adapter Objects
        //private DBASDataSetTableAdapters.invoicesTableAdapter invoiceTableAdapter;
        private DBASDataSetTableAdapters.patient_admissionsTableAdapter aAdmissionsTableAdapter;
        private DBASDataSetTableAdapters.patientsTableAdapter aPatientTableAdapter;
        private DBASDataSetTableAdapters.physiciansTableAdapter aPhysiciansTableAdapter;
        private DBASDataSet aDataSet;

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            // Report object for use at run time
            PatientPhysicianReport aPatientPhysicianReport = new PatientPhysicianReport();
            // RoomUtilizationReport aRoomUtilizationReport;
            try
            {
                aDataSet = new DBASDataSet();
                aPatientTableAdapter = new DBASDataSetTableAdapters.patientsTableAdapter();
                aPhysiciansTableAdapter = new DBASDataSetTableAdapters.physiciansTableAdapter();
                aAdmissionsTableAdapter = new DBASDataSetTableAdapters.patient_admissionsTableAdapter();

                aPatientTableAdapter.Fill(aDataSet.patients);
                aPhysiciansTableAdapter.Fill(aDataSet.physicians);
                aAdmissionsTableAdapter.Fill(aDataSet.patient_admissions);

                // Set up viewer to show report object
                rptPatientPhysicianViewer.ReportSource = aPatientPhysicianReport;
            }
            catch (Exception dataException)
            {
                MessageBox.Show(dataException.Message);
            }

            rptPatientPhysicianViewer.RefreshReport();
        }
    }
}
