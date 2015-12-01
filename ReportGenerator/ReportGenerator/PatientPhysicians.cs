using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportGenerator
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
        private DBASDataSet aDataSet;
        private DBASDataSetTableAdapters.patient_admissionsTableAdapter anAdmissionsTableAdapter;
        private DBASDataSetTableAdapters.patientsTableAdapter aPatientTableAdapter;
        private DBASDataSetTableAdapters.physiciansTableAdapter aPhysiciansTableAdapter;        

        private void frmPatientPhysicians_Load(object sender, EventArgs e)
        {
            // Report object for use at run time
            PatientPhysicianReport aPatientPhysicianReport = new PatientPhysicianReport();
            // RoomUtilizationReport aRoomUtilizationReport;
            try
            {
                aDataSet = new DBASDataSet();
                aPatientTableAdapter = new DBASDataSetTableAdapters.patientsTableAdapter();
                aPhysiciansTableAdapter = new DBASDataSetTableAdapters.physiciansTableAdapter();
                anAdmissionsTableAdapter = new DBASDataSetTableAdapters.patient_admissionsTableAdapter();

                aPatientTableAdapter.Fill(aDataSet.patients);
                aPhysiciansTableAdapter.Fill(aDataSet.physicians);
                anAdmissionsTableAdapter.Fill(aDataSet.patient_admissions);

                // Set up viewer to show report object
                rptPatientPhysicianViewer.ReportSource = aPatientPhysicianReport;
            }
            catch (Exception dataException)
            {
                MessageBox.Show(dataException.Message);
            }
        }
    }
}
