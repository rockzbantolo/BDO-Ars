using System;
using System.Windows.Forms;
using ActivityReportSystem.Function;
using ActivityReportSystem.AppActivity.Controller;

namespace ActivityReportSystem.Forms
{
    public partial class frmSumDetails : Form
    {
        private cFunctions Func  = new cFunctions();
        private cSource    Src   = new cSource();
        private cTerminal  Trmnl = new cTerminal();


        public string TableName { get; set; }
        public string HeaderName { get; set; }


        public frmSumDetails()
        {
            InitializeComponent();
            cFunctions.Effects.setDoubleBuffer(dgv_Details, true);
            cFunctions.Effects.setDoubleBuffer(dgv_Duplicate, true);
            Tm_FadeIn.Start();
        }

        private void frmSumDetails_Load(object sender, EventArgs e)
        {
            lb_Activity.Text = HeaderName;

            Cursor.Current = Cursors.WaitCursor;

            if(TableName == "tblinstallation" || TableName == "tblreprogramming")
            {
                dgv_Details.Columns[1].Visible = false;
                dgv_Duplicate.Columns[1].Visible = false;
            }

            // Get Details
            Src.SearchValue = TableName;
            Src.GetDetails(dgv_Details);

            // Set Controls
            lb_Com.Text  = Src.Completed;
            lb_Pen.Text  = Src.Pending;
            lb_Can.Text  = Src.Cancelled;
            lb_Wait.Text = Src.Waiting;

            // Get Duplicate
            Trmnl.SearchValue = TableName;
            Trmnl.GetDetails(dgv_Duplicate);

            Cursor.Current = Cursors.Default;
        }

        private void frmSumDetails_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Tm_FadeOut.Start();
                    break;
            }
        }

        private void pnCompleted_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pnCompleted, 0, 0, 3, 3);
        }

        private void pnCancel_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pnCancel, 0, 0, 3, 3);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Tm_FadeOut.Start();
        }

        private void dgv_Details_Leave(object sender, EventArgs e)
        {
            dgv_Details.ClearSelection();
        }

        private void dgv_Duplicate_Leave(object sender, EventArgs e)
        {
            dgv_Duplicate.ClearSelection();
        }

        private void Tm_FadeIn_Tick(object sender, EventArgs e)
        {
            cFunctions.Effects.FadeIn(this, Tm_FadeIn);
        }

        private void Tm_FadeOut_Tick(object sender, EventArgs e)
        {
            cFunctions.Effects.FadeOut(this, Tm_FadeOut);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Set Controls.
            lb_Com.Text = Src.Completed;
            lb_Pen.Text = Src.Pending;
            lb_Can.Text = Src.Cancelled;
            lb_Wait.Text = Src.Waiting;
            Src.SearchValue = TableName + cFunctions.Pipe + Tx_Search.Text;

            // Get Details
            Src.GetDetails(dgv_Details);

            // Get Duplicate
            Trmnl.SearchValue = TableName;
            Trmnl.GetDetails(dgv_Duplicate);

            // Get Table Details
            //Db.ViewSourceDetails(dgv_Details, lb_Com, lb_Pen, lb_Can, lb_Wait, TableName + " | " + Tx_Search.Text);

            // Get Duplicate Request
            //Db.ViewTerminalDetails(dgv_Duplicate, TableName);

            Cursor.Current = Cursors.Default;
        }

        private void Tx_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Btn_Search.PerformClick(); // Trigger the search button
            }
        }
    }
}
