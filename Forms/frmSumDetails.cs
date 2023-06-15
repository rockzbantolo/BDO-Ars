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
        private clsFunctions Func = new clsFunctions();      
        private clsAppViews Db = new clsAppViews();

        public frmSumDetails()
        {
            InitializeComponent();
            Func.setDoubleBuffer(Dgv_Details, true);
            Func.setDoubleBuffer(Dgv_Duplicate, true);
            Tm_FadeIn.Start();
        }

        private void frmSumDetails_Load(object sender, EventArgs e)
        {
            lb_Activity.Text = sAppData.TemplateName;

            Cursor.Current = Cursors.WaitCursor;

            if (sAppData.TemplateName == clsFunctions.sInstall || sAppData.TemplateName == clsFunctions.sReprog)
            {
                Db.LoadTemplateDetails(Dgv_Details, lb_Com, lb_Pen, lb_Can, string.Empty);
            }
            else
            {
                Db.LoadTemplateDetails(Dgv_Details, lb_Com, lb_Pen, lb_Can, string.Empty);
            }

            getDuplicateValue();
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
            Func.BorderShadow(e, pnCompleted, 0, 0, 3, 3);
        }

        private void pnCancel_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pnCancel, 0, 0, 3, 3);
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

            if (Dgv_Details.Rows.Count > 0)
            {
                for (int i = 0; i < Dgv_Details.Rows.Count; i++)
                {
                    string SerialVal    = Dgv_Details.Rows[i].Cells[5].Value.ToString();
                    string DupSerial    = Dgv_Details.Rows[i].Cells[5].Value.ToString();
                    string StatusVal    = Dgv_Details.Rows[i].Cells[7].Value.ToString();
                    string DateVal      = Dgv_Details.Rows[i].Cells[10].Value.ToString();
                    string Dependency   = Dgv_Details.Rows[i].Cells[9].Value.ToString();
                    DataGridViewRow row = Dgv_Details.Rows[i];

                    if (DateVal == "-" && StatusVal != "CANCELLED")
                    {
                        inNoDates += 1;
                    }

                    int.TryParse(Dgv_Details.Rows[i].Cells[11].Value.ToString(), out Age);

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
                            Dgv_Duplicate.Rows.Add(
                            Dgv_Details.Rows[i].Cells[0].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[1].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[2].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[3].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[4].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[5].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[6].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[7].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[8].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[9].Value.ToString(),
                            Dgv_Details.Rows[i].Cells[10].Value.ToString());
                    }

                }

                if (inNoDates <= 0)
                {
                    inNoDates = 0;
                }
            }

            if (lb_Activity.Text == clsFunctions.sInstall || lb_Activity.Text == clsFunctions.sReprog)
            {
                Dgv_Details.Columns[1].Visible = false;
                Dgv_Duplicate.Columns[1].Visible = false;
            }

            Dgv_Duplicate.ClearSelection();
            lb_Wait.Text = inNoDates.ToString("n0");
  
        }

        private void dgv_Details_Leave(object sender, EventArgs e)
        {
            Dgv_Details.ClearSelection();
        }

        private void dgv_Duplicate_Leave(object sender, EventArgs e)
        {
            Dgv_Duplicate.ClearSelection();
        }

        private void Tm_FadeIn_Tick(object sender, EventArgs e)
        {
            Func.FadeIn(this, Tm_FadeIn);
        }

        private void Tm_FadeOut_Tick(object sender, EventArgs e)
        {
            Func.FadeOut(this, Tm_FadeOut);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (sAppData.TemplateName == clsFunctions.sInstall || sAppData.TemplateName == clsFunctions.sReprog)
            {
                Db.LoadTemplateDetails(Dgv_Details, lb_Com, lb_Pen, lb_Can, Tx_Search.Text.Trim());
            }
            else
            {
                Db.LoadTemplateDetails(Dgv_Details, lb_Com, lb_Pen, lb_Can, Tx_Search.Text.Trim());
            }

            getDuplicateValue();
            Cursor.Current = Cursors.Default;
        }

        private void Tx_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the "ding" sound
                Btn_Search.PerformClick(); // Trigger the search button
            }
        }
    }
}
