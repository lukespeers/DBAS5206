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
        private MVCHDBASDataSet aDataSet;
        private MVCHDBASDataSetTableAdapters.patient_admissionsTableAdapter anAdmissionsTableAdapter;
        private MVCHDBASDataSetTableAdapters.patientsTableAdapter aPatientTableAdapter;
        private MVCHDBASDataSetTableAdapters.physiciansTableAdapter aPhysiciansTableAdapter;
        private MVCHDBASDataSetTableAdapters.location_typesTableAdapter aLocationTypesTableAdapter;
        private MVCHDBASDataSetTableAdapters.locationsTableAdapter aLocationTableAdapter;

        private void frmPatientPhysicians_Load(object sender, EventArgs e)
        {
            // Report object for use at run time
            PatientPhysicianReport aPatientPhysicianReport;
            aPatientPhysicianReport = new PatientPhysicianReport();
            // RoomUtilizationReport aRoomUtilizationReport;
            //try
            //{

            aDataSet = new MVCHDBASDataSet();
            aPhysiciansTableAdapter = new MVCHDBASDataSetTableAdapters.physiciansTableAdapter();
            anAdmissionsTableAdapter = new MVCHDBASDataSetTableAdapters.patient_admissionsTableAdapter();
            aPatientTableAdapter = new MVCHDBASDataSetTableAdapters.patientsTableAdapter();
            aLocationTableAdapter = new MVCHDBASDataSetTableAdapters.locationsTableAdapter();
            aLocationTypesTableAdapter = new MVCHDBASDataSetTableAdapters.location_typesTableAdapter();

            aPatientTableAdapter.Fill(aDataSet.patients);
            aPhysiciansTableAdapter.Fill(aDataSet.physicians);
            anAdmissionsTableAdapter.Fill(aDataSet.patient_admissions);
            aLocationTableAdapter.Fill(aDataSet.locations);
            aLocationTypesTableAdapter.Fill(aDataSet.location_types);

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
