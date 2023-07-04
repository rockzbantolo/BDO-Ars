using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using ActivityReportSystem.Forms;
using System.IO;
using AppAction;
using ActivityReportSystem.AppActivity.Model;

namespace ActivityReportSystem
{
    public partial class frmMImport : Form
    {

        private cFunctions cFunc  = new cFunctions();
        private cSourceCtrl Src = new cSourceCtrl();

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

            Src.ImportDetails(sAppData.Installation);
            Src.ImportDetails(sAppData.Reprogramming);
            Src.ImportDetails(sAppData.Servicing);
            Src.ImportDetails(sAppData.Repair);
            Src.ImportDetails(sAppData.Inventory);

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
            Src.SearchValue = sAppData.Installation;
            Src.ImportProcess(tx_Imp_InstallationFile);

            //Db.ProcessFile(tx_Imp_InstallationFile, sAppData.Installation);
        }

        private void btn_Imp_OpenReprog_Click(object sender, EventArgs e)
        {
            Src.SearchValue = sAppData.Reprogramming;
            Src.ImportProcess(tx_Imp_ReprogFile);

            //Db.ProcessFile(tx_Imp_ReprogFile, sAppData.Reprogramming);
        }

        private void btn_Imp_OpenServicing_Click(object sender, EventArgs e)
        {
            Src.SearchValue = sAppData.Servicing;
            Src.ImportProcess(tx_Imp_ServicingFile);

            //Db.ProcessFile(tx_Imp_ServicingFile, sAppData.Servicing);
        }

        private void btn_Imp_OpenRepair_Click(object sender, EventArgs e)
        {
            Src.SearchValue = sAppData.Repair;
            Src.ImportProcess(tx_Imp_RepairFile);

            //Db.ProcessFile(tx_Imp_RepairFile, sAppData.Repair);
        }

        private void btn_Imp_OpenInvent_Click(object sender, EventArgs e)
        {
            Src.SearchValue = sAppData.Inventory;
            Src.ImportProcess(tx_Imp_Inventory);

            //Db.ProcessFile(tx_Imp_Inventory, sAppData.Inventory);
        }


        // REFRESH DASHBOARD
        public void Refresh_Dashboard()
        {
            Debug.WriteLine(" ---- Refresh Dashboard -----");
            frmDashboard mainForm = Application.OpenForms.OfType<frmDashboard>().FirstOrDefault();
            mainForm?.InitializeDisplay();
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



