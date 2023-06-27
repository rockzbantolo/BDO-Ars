using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using ActivityReportSystem.Function;
using ActivityReportSystem.Database;
using ActivityReportSystem.Global;
using System.Collections.Generic;
using System.Reflection;
using ActivityReportSystem.AppActivity.View;

namespace ActivityReportSystem.Forms
{
    public partial class frmSumDetails : Form
    {
        private cFunctions Func = new cFunctions();      
        private cAppViews Db = new cAppViews();

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

            // Get Source Details
            Db.ViewSourceDetails(dgv_Details, lb_Com, lb_Pen, lb_Can, lb_Wait, TableName);

            // Get Duplicate Details
            Db.ViewTerminalDetails(dgv_Duplicate, TableName);

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

        // DISPLAY SUMMARY
        public void getDuplicateValue()
        {
            int inNoDates = 0;
            int Age;

            if (dgv_Details.Rows.Count > 0)
            {
                for (int i = 0; i < dgv_Details.Rows.Count; i++)
                {
                    string SerialVal    = dgv_Details.Rows[i].Cells[5].Value.ToString();
                    string DupSerial    = dgv_Details.Rows[i].Cells[5].Value.ToString();
                    string StatusVal    = dgv_Details.Rows[i].Cells[7].Value.ToString();
                    string DateVal      = dgv_Details.Rows[i].Cells[10].Value.ToString();
                    string Dependency   = dgv_Details.Rows[i].Cells[9].Value.ToString();
                    DataGridViewRow row = dgv_Details.Rows[i];

                    if (DateVal == "-" && StatusVal != "CANCELLED")
                    {
                        inNoDates += 1;
                    }

                    int.TryParse(dgv_Details.Rows[i].Cells[11].Value.ToString(), out Age);

                    if (Age >= 17)
                    {
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }

                    if (StatusVal == "CANCELLED" && SerialVal == DupSerial && ( Dependency.Contains("Duplicate") || Dependency.Contains("DUPLICATE")))
                    {
                            dgv_Duplicate.Rows.Add(
                            dgv_Details.Rows[i].Cells[0].Value.ToString(),
                            dgv_Details.Rows[i].Cells[1].Value.ToString(),
                            dgv_Details.Rows[i].Cells[2].Value.ToString(),
                            dgv_Details.Rows[i].Cells[3].Value.ToString(),
                            dgv_Details.Rows[i].Cells[4].Value.ToString(),
                            dgv_Details.Rows[i].Cells[5].Value.ToString(),
                            dgv_Details.Rows[i].Cells[6].Value.ToString(),
                            dgv_Details.Rows[i].Cells[7].Value.ToString(),
                            dgv_Details.Rows[i].Cells[8].Value.ToString(),
                            dgv_Details.Rows[i].Cells[9].Value.ToString(),
                            dgv_Details.Rows[i].Cells[10].Value.ToString(),
                            dgv_Details.Rows[i].Cells[11].Value.ToString());
                    }

                }

                if (inNoDates <= 0)
                {
                    inNoDates = 0;
                }
            }

            if (lb_Activity.Text == sAppData.Installation || lb_Activity.Text == sAppData.Reprogramming)
            {
                dgv_Details.Columns[1].Visible = false;
                dgv_Duplicate.Columns[1].Visible = false;
            }

            dgv_Duplicate.ClearSelection();
            lb_Wait.Text = inNoDates.ToString("n0");
  
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

            // Get Table Details
            Db.ViewSourceDetails(dgv_Details, lb_Com, lb_Pen, lb_Can, lb_Wait, TableName + " | " + Tx_Search.Text);

            // Get Duplicate Request
            Db.ViewTerminalDetails(dgv_Duplicate, TableName);

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
