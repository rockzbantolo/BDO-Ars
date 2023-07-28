using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using ActivityReportSystem.Report;
using ActivityReportSystem.Function;
using ActivityReportSystem.Global;

namespace ActivityReportSystem.Forms
{
    public partial class frmReportViewer : Form
    {
        private cFunctions cFunc = new cFunctions();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            ActivityReport();
            Tm_FadeIn.Start();
            Cursor.Current = Cursors.Default;

        }

        private void ActivityReport()
        {
            string ReportPath = "";
            string reportFullPath = "";

            ReportPath = AppData.FilePath.Report;
            reportFullPath = Path.Combine(ReportPath, "rptDashboard.rpt");
            Debug.WriteLine("reportFullPath=" + reportFullPath);

            if (!File.Exists(reportFullPath))
            {
                MessageBox.Show("Report Path [" + reportFullPath + "]" + "\n\n" + "File not found!");
                return;
            }

            try
            {
                //DataSet dsReport = dbConnect.GetReportWithStoredProcedure(clsSearch.ClassReportID, clsSearch.ClassStatementType, clsSearch.ClassSearchBy, clsSearch.ClassSearchValue, clsSearch.ClassStoredProcedureName);
                rptDashboard rptViewer = new rptDashboard();
                rptViewer.Load(reportFullPath);

                myViewer.ReportSource = rptViewer;
                myViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None; // hide toggle tree view
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "[" + reportFullPath + "]", "Report could not be created",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReportViewer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Tm_FadeOut.Start();
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Tm_FadeOut.Start();
        }

        private void Tm_FadeIn_Tick(object sender, EventArgs e)
        {
            cFunctions.Effects.FadeIn(this, Tm_FadeIn);
        }

        private void Tm_FadeOut_Tick(object sender, EventArgs e)
        {
            cFunctions.Effects.FadeOut(this, Tm_FadeOut);
        }
    }
}
