using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using ActivityReportSystem.Function;
using ActivityReportSystem.Database;
using ActivityReportSystem.Global;
using ActivityReportSystem.Forms;
using ActivityReportSystem.AppActivity.View;
using System.IO;
using AppAction;

namespace ActivityReportSystem
{
    public partial class frmMImport : Form
    {

        private cFunctions cFunc  = new cFunctions();
        private cAppViews Db = new cAppViews();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return cp;
            }
        }

        public frmMImport()
        {
            InitializeComponent();
            lb_Imp_Selected.Text = string.Empty;
            Tm_FadeIn.Start();
        }

        private void frmMImport_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Tm_FadeOut.Start();
                    break;
            }
        }

        private void tpcMenu_KeyDown(object sender, KeyEventArgs e)
        {
            // DISABLED ARROW KEYS
            string tempstring = e.KeyValue.ToString();
            if (tempstring == "37" || tempstring == "38" || tempstring == "39" || tempstring == "40")
            {
                e.Handled = true;
            }
        }

        // BUTTONS 
        private void btnImpSave_Click(object sender, EventArgs e)
        {
            // Check All Textboxes if Empty
            bool anyTextboxNotEmpty = pn_Imp_BxTemplate.Controls.OfType<TextBox>().Any(tx => !string.IsNullOrEmpty(tx.Text));

            if (!anyTextboxNotEmpty) return;

            if (!cFunctions.SavingConfirm(false, "Upload Process")) return;

            Cursor.Current = Cursors.WaitCursor;

            Db.SaveCsvFile(sAppData.Installation);
            Db.SaveCsvFile(sAppData.Reprogramming);
            Db.SaveCsvFile(sAppData.Servicing);
            Db.SaveCsvFile(sAppData.Repair);

            Cursor.Current = Cursors.Default;

            MessageBox.Show("Files Successfully Imported", "Import Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearObj();
        }

        private void btnImpClear_Click(object sender, EventArgs e)
        {
             tx_Imp_InstallationFile.Text
             = tx_Imp_ReprogFile.Text
             = tx_Imp_ServicingFile.Text
             = tx_Imp_RepairFile.Text
             = tx_Imp_Inventory.Text = string.Empty;

            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Installation);
            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Reprogramming);
            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Servicing);
            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Repair);
            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Inventory);
            //rtb_Imp_Selected.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Tm_FadeOut.Start();
        }

        // LINE NUMBER
        private void grdImpInstallation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunctions.Grid.AddGridLineNo(sender, e, this.Font); // ADD LINE #
        }

        private void grdImpReprogramming_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunctions.Grid.AddGridLineNo(sender, e, this.Font); // ADD LINE #
        }

        private void grdImpServicing_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunctions.Grid.AddGridLineNo(sender, e, this.Font); // ADD LINE #
        }

        private void grdImpRepair_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunctions.Grid.AddGridLineNo(sender, e, this.Font);// ADD LINE #
        }

        private void dgv_Imp_Inventory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunctions.Grid.AddGridLineNo(sender, e, this.Font); // ADD LINE #
        }

        // BORDER SHADOW
        private void pn_Imp_BxTemplate_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Imp_BxTemplate, 0, 0, 3, 3);
        }

        private void pn_Imp_BxPreview_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Imp_BxPreview, 0, 0, 3, 3);
        }

        private void pn_Imp_BxDataClick_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Imp_BxDataClick, 0, 0, 3, 3);
        }

        #region Doublick Event Dgv
        // VIEW SELECTED
        private void dgv_Imp_Installation_DoubleClick(object sender, EventArgs e)
        {
            // GET DATAGRID DATA
            string SelectedRow = cFunctions.Grid.getGridSelectedRow(dgv_Imp_Installation, 0);
            viewSelectedRow(SelectedRow);
        }

        private void dgv_Imp_Reprogramming_DoubleClick(object sender, EventArgs e)
        {
            string SelectedRow = cFunctions.Grid.getGridSelectedRow(dgv_Imp_Reprogramming, 0);
            viewSelectedRow(SelectedRow);
        }

        private void dgv_Imp_Servicing_DoubleClick(object sender, EventArgs e)
        {
            string SelectedRow = cFunctions.Grid.getGridSelectedRow(dgv_Imp_Servicing, 0);
            viewSelectedRow(SelectedRow);
        }

        private void dgv_Imp_Repair_DoubleClick(object sender, EventArgs e)
        {
            string SelectedRow = cFunctions.Grid.getGridSelectedRow(dgv_Imp_Repair, 0);
            viewSelectedRow(SelectedRow);
        }

        private void dgv_Imp_Inventory_DoubleClick(object sender, EventArgs e)
        {
            string SelectedRow = cFunctions.Grid.getGridSelectedRow(dgv_Imp_Inventory, 0);
            viewSelectedRow(SelectedRow);
        }

        private void viewSelectedRow(string SelectedRow)
        {
            lb_Imp_Selected.Text = tpcActivity.SelectedTab.Text;
            rtb_Imp_Selected.Text = SelectedRow;
        }
        #endregion

        // OPEN FILE DIALOG BUTTONS
        private void btn_Imp_OpenInstallation_Click(object sender, EventArgs e)
        {
            Db.ProcessFile(tx_Imp_InstallationFile, sAppData.Installation);
        }

        private void btn_Imp_OpenReprog_Click(object sender, EventArgs e)
        {
            Db.ProcessFile(tx_Imp_ReprogFile, sAppData.Reprogramming);
        }

        private void btn_Imp_OpenServicing_Click(object sender, EventArgs e)
        {
            Db.ProcessFile(tx_Imp_ServicingFile, sAppData.Servicing);
        }

        private void btn_Imp_OpenRepair_Click(object sender, EventArgs e)
        {
            Db.ProcessFile(tx_Imp_RepairFile, sAppData.Repair);
        }

        private void btn_Imp_OpenInvent_Click(object sender, EventArgs e)
        {
            Db.ProcessFile(tx_Imp_Inventory, sAppData.Inventory);
        }

        // REFRESH DASHBOARD
        public void Refresh_Dashboard()
        {
            Debug.WriteLine(" ---- Refresh Dashboard -----");
            frmDashboard Dashboard = new frmDashboard();
        }

        // CLEAR OBJ
        public void ClearObj()
        {
            tx_Imp_InstallationFile.Text
            = tx_Imp_ReprogFile.Text
            = tx_Imp_ServicingFile.Text
            = tx_Imp_RepairFile.Text
            = tx_Imp_Inventory.Text = string.Empty;

            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Installation);
            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Reprogramming);
            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Servicing);
            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Repair);
            //cFunctions.Grid.ClearDataGrid(dgv_Imp_Inventory);
            //rtb_Imp_Selected.Clear();

            Refresh_Dashboard();
        }

        // EFFECTS
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



