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
    public partial class frmPatientPhysicians : Form
    {
        public frmPatientPhysicians()
        {
            InitializeComponent();
        }
        // Data Set object
        //private DBASDataSet hospitalInfoDataSet;
        // Table Adapter Objects
        //private DBASDataSetTableAdapters.invoicesTableAdapter invoiceTableAdapter;
        private MVCHDataSet aDataSet;
        private MVCHDataSetTableAdapters.patient_admissionsTableAdapter anAdmissionsTableAdapter;
        private MVCHDataSetTableAdapters.patientsTableAdapter aPatientTableAdapter;
        private MVCHDataSetTableAdapters.physiciansTableAdapter aPhysiciansTableAdapter;        

        private void frmPatientPhysicians_Load(object sender, EventArgs e)
        {
            // Report object for use at run time
            PatientPhysicianReport aPatientPhysicianReport;
            aPatientPhysicianReport = new PatientPhysicianReport();
            // RoomUtilizationReport aRoomUtilizationReport;
            //try
            //{

            aDataSet = new MVCHDataSet();
            aPhysiciansTableAdapter = new MVCHDataSetTableAdapters.physiciansTableAdapter();
            anAdmissionsTableAdapter = new MVCHDataSetTableAdapters.patient_admissionsTableAdapter();
            aPatientTableAdapter = new MVCHDataSetTableAdapters.patientsTableAdapter();

            aPatientTableAdapter.Fill(aDataSet.patients);
            aPhysiciansTableAdapter.Fill(aDataSet.physicians);
            anAdmissionsTableAdapter.Fill(aDataSet.patient_admissions);

            // Set up viewer to show report object
            aPatientPhysicianReport.SetDataSource(aDataSet);

            rptPatientPhysicianViewer.ReportSource = aPatientPhysicianReport;
            rptPatientPhysicianViewer.Refresh();

            // }
            // catch (Exception dataException)
            // {
            //   MessageBox.Show(dataException.Message);
            // }
        }
    }
}
