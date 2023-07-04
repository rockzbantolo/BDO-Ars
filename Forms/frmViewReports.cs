using ActivityReportSystem.AppActivity.Model;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityReportSystem.Forms
{
    public partial class frmViewReports : Form
    {
        public int ReportID { get; set; }
        public string ReportHeader {get; set;}
        public string ReportPath { get; set; }
        public string ReportFullPath { get; set; }
        public string SpName { get; set; }

        cSpModel Sp = new cSpModel();

        public frmViewReports()
        {
            InitializeComponent();
        }

        private void frmViewReports_Load(object sender, EventArgs e)
        {
            switch(ReportID)
            {
                case 1:
                    TerminalReport();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;
            }
        }

        private string GetReportPath()
        {
            bool isDevelopment = false;

            return isDevelopment ? Path.GetDirectoryName(Application.ExecutablePath) : "C:\\CASTLESTECH_ARS\\REPORTS\\";
        }

        private void SetReceiptReportHeader(ReportClass rptViewer)
        {
            TextObject obj1;
            TextObject obj2;
            TextObject obj3;
            TextObject obj4;
            TextObject obj5;

            // Set Header1
            if (rptViewer.ReportDefinition.ReportObjects["txtHeader1"] != null)
            {
                obj1 = (TextObject)rptViewer.ReportDefinition.ReportObjects["txtHeader1"];
                obj1.Text = ReportHeader;
            }

            // Set Header2
            if (rptViewer.ReportDefinition.ReportObjects["txtHeader2"] != null)
            {
                obj2 = (TextObject)rptViewer.ReportDefinition.ReportObjects["txtHeader2"];
                obj2.Text = ReportHeader;
            }

            // Set Header3
            if (rptViewer.ReportDefinition.ReportObjects["txtHeader3"] != null)
            {
                obj3 = (TextObject)rptViewer.ReportDefinition.ReportObjects["txtHeader3"];
                obj3.Text = ReportHeader;
            }

            // Set Header4
            if (rptViewer.ReportDefinition.ReportObjects["txtHeader4"] != null)
            {
                obj4 = (TextObject)rptViewer.ReportDefinition.ReportObjects["txtHeader4"];
                obj4.Text = ReportHeader;
            }

            // Set Header5
            if (rptViewer.ReportDefinition.ReportObjects["txtHeader5"] != null)
            {
                obj5 = (TextObject)rptViewer.ReportDefinition.ReportObjects["txtHeader5"];
                obj5.Text = ReportHeader;
            }

        }

        private void SetReceiptUser(ReportClass rptViewer)
        {
            // Set report User
            TextObject obj;

            // Set User Full Name                
            if (rptViewer.ReportDefinition.ReportObjects["txtUserFullName"] != null)
            {
                obj = (TextObject)rptViewer.ReportDefinition.ReportObjects["txtUserFullName"];
                obj.Text = "Printed By: "; //User Name
            }
        }

        private void SetReceiptImportCount(ReportClass rptViewer)
        {
            // Set report User
            TextObject obj;

            // Set Success Count                
            if (rptViewer.ReportDefinition.ReportObjects["txtSuccessCount"] != null)
            {
                obj = (TextObject)rptViewer.ReportDefinition.ReportObjects["txtSuccessCount"];
                //obj.Text = clsSearch.ClassSuccessCount.ToString();
            }

            // Set Failed Count                
            if (rptViewer.ReportDefinition.ReportObjects["txtFailedCount"] != null)
            {
                obj = (TextObject)rptViewer.ReportDefinition.ReportObjects["txtFailedCount"];
                //obj.Text = clsSearch.ClassFailedCount.ToString();
            }


        }



        private void TerminalReport()
        {
            ReportPath = GetReportPath();
            ReportFullPath = Path.Combine(ReportPath, "rptImportSIM.rpt");

            Debug.WriteLine("Report Full Path: " + ReportFullPath);

            if (!File.Exists(ReportFullPath))
            {
                MessageBox.Show("Report Path [" + ReportFullPath + "]" + "\n\n" + "File not found!");
                return;
            }

            try
            {
                DataSet dsReport = Sp.GetReportWithSp(ReportHeader, SpName);

                // Report Name .rpt
                //rptImportSIM rptViewer = new rptImportSIM();

                // Load Report
                //rptViewer.Load(ReportFullPath);
                //rptViewer.SetDataSource(dsReport.Tables[0]);

                //SetReceiptReportHeader(rptViewer);
                //SetReceiptUser(rptViewer);
                //SetReceiptImportCount(rptViewer);

                //myViewer.ReportSource = rptViewer;
                myViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None; // hide toggle tree view

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "[" + ReportFullPath + "]", "Report could not be created",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
