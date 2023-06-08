using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using ActivityReportSystem.Function;
using ActivityReportSystem.Database;
using ActivityReportSystem.Global;
using ActivityReportSystem.Forms;

namespace ActivityReportSystem
{
    public partial class frmMImport : Form
    {

        private clsFunctions cFunc  = new clsFunctions();
        private clsSQLModels Sql = new clsSQLModels();

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

    // FUNCTION BUTTONS 

        private void btnImpSave_Click(object sender, EventArgs e)
        {
            // Check All Textboxes if Empty
            foreach (TextBox tx in pn_Imp_BxTemplate.Controls.OfType<TextBox>())
            {
                if (!string.IsNullOrEmpty(tx.Text.ToString()))
                {
                    if (!cFunc.SavingConfirm(false, "Upload Process")) return;

                    Cursor.Current = Cursors.WaitCursor;

                    // Process Data and Save
                    Debug.WriteLine("--- Saving Data ");

                    Sql.setCollectionInsert(clsFunctions.sInstall,    dgv_Imp_Installation);
                    Sql.setCollectionInsert(clsFunctions.sReprog,     dgv_Imp_Reprogramming);
                    Sql.setCollectionInsert(clsFunctions.sServ,       dgv_Imp_Servicing);
                    Sql.setCollectionInsert(clsFunctions.sRepair,     dgv_Imp_Repair);
                    Sql.setCollectionInsert(clsFunctions.sInventory,  dgv_Imp_Inventory);

                    ClearObj();

                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnImpClear_Click(object sender, EventArgs e)
        {
             tx_Imp_InstallationFile.Text
                = tx_Imp_ReprogFile.Text
                = tx_Imp_ServicingFile.Text
                = tx_Imp_RepairFile.Text
                = tx_Imp_Inventory.Text = string.Empty;

            cFunc.ClearDataGrid(dgv_Imp_Installation);
            cFunc.ClearDataGrid(dgv_Imp_Reprogramming);
            cFunc.ClearDataGrid(dgv_Imp_Servicing);
            cFunc.ClearDataGrid(dgv_Imp_Repair);
            cFunc.ClearDataGrid(dgv_Imp_Inventory);

            rtb_Imp_Selected.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Tm_FadeOut.Start();
        }

    // LINE NUMBER

        private void grdImpInstallation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunc.addGridLineNo(sender, e, this.Font); // ADD LINE #
        }

        private void grdImpReprogramming_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunc.addGridLineNo(sender, e, this.Font); // ADD LINE #
        }

        private void grdImpServicing_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunc.addGridLineNo(sender, e, this.Font); // ADD LINE #
        }

        private void grdImpRepair_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunc.addGridLineNo(sender, e, this.Font);// ADD LINE #
        }

        private void dgv_Imp_Inventory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            cFunc.addGridLineNo(sender, e, this.Font); // ADD LINE #
        }

    // BORDER SHADOW

        private void pn_Imp_BxTemplate_Paint(object sender, PaintEventArgs e)
        {
            cFunc.BorderShadow(e, pn_Imp_BxTemplate, 0, 0, 3, 3);
        }

        private void pn_Imp_BxPreview_Paint(object sender, PaintEventArgs e)
        {
            cFunc.BorderShadow(e, pn_Imp_BxPreview, 0, 0, 3, 3);
        }

        private void pn_Imp_BxDataClick_Paint(object sender, PaintEventArgs e)
        {
            cFunc.BorderShadow(e, pn_Imp_BxDataClick, 0, 0, 3, 3);
        }

    // VIEW SELECTED

        private void dgv_Imp_Installation_DoubleClick(object sender, EventArgs e)
        {
            // GET DATAGRID DATA
            string SelectedRow = cFunc.getGridSelectedRow(dgv_Imp_Installation, 0);
            viewSelectedRow(SelectedRow);
        }

        private void dgv_Imp_Reprogramming_DoubleClick(object sender, EventArgs e)
        {
            string SelectedRow = cFunc.getGridSelectedRow(dgv_Imp_Reprogramming, 0);
            viewSelectedRow(SelectedRow);
        }

        private void dgv_Imp_Servicing_DoubleClick(object sender, EventArgs e)
        {
            string SelectedRow = cFunc.getGridSelectedRow(dgv_Imp_Servicing, 0);
            viewSelectedRow(SelectedRow);
        }

        private void dgv_Imp_Repair_DoubleClick(object sender, EventArgs e)
        {
            string SelectedRow = cFunc.getGridSelectedRow(dgv_Imp_Repair, 0);
            viewSelectedRow(SelectedRow);
        }

        private void dgv_Imp_Inventory_DoubleClick(object sender, EventArgs e)
        {
            string SelectedRow = cFunc.getGridSelectedRow(dgv_Imp_Inventory, 0);
            viewSelectedRow(SelectedRow);
        }

        private void viewSelectedRow(string SelectedRow)
        {
            lb_Imp_Selected.Text = tpcActivity.SelectedTab.Text;
            rtb_Imp_Selected.Text = SelectedRow;
        }

    // OPEN FILE BUTTONS

        private void btn_Imp_OpenInstallation_Click(object sender, EventArgs e)
        {
            ProcessDataFile(tx_Imp_InstallationFile, dgv_Imp_Installation, tbpInstallation, clsFunctions.sInstall);
        }

        private void btn_Imp_OpenReprog_Click(object sender, EventArgs e)
        {
            ProcessDataFile(tx_Imp_ReprogFile, dgv_Imp_Reprogramming, tbpReprogramming, clsFunctions.sReprog);
        }

        private void btn_Imp_OpenServicing_Click(object sender, EventArgs e)
        {
            ProcessDataFile(tx_Imp_ServicingFile, dgv_Imp_Servicing, tbpServicing, clsFunctions.sServ);
        }

        private void btn_Imp_OpenRepair_Click(object sender, EventArgs e)
        {
            ProcessDataFile(tx_Imp_RepairFile, dgv_Imp_Repair, tbpRepair, clsFunctions.sRepair);
        }

        private void btn_Imp_OpenInvent_Click(object sender, EventArgs e)
        {
            ProcessDataFile(tx_Imp_Inventory, dgv_Imp_Inventory, tbpInventory, clsFunctions.sInventory);
        }

    // IMPORT PROCESS
        private void ProcessDataFile(TextBox Tbx, DataGridView Obj, TabPage Tbp, string Template)
        {
            // OPEN DIALOG
            OpenFileDialog Ed = new OpenFileDialog();
            Ed.Filter = "Excel Files|*.xls;*.xlsx";
            Ed.Title = "Select file to import " + Template;

            try {

                if (Ed.ShowDialog() == DialogResult.OK) {
                    Debug.WriteLine(Ed.FileName);

                    Tbx.Text = Ed.FileName;

                    if (Tbx.Text.Contains(Template) == true) {
                        if (Tbx.TextLength > 0) {

                            Cursor.Current = Cursors.WaitCursor;

                            try {

                                cFunc.setDataBind(Obj, Tbx);
                                cFunc.setGridAlterBackColor(Obj);
                                cFunc.getGridHeaderList(Obj);
                                tpcActivity.SelectedTab = Tbp;

                            }
                            catch (Exception e) {
                                cFunc.setMessageBox(e.Message, "Activity Report System", clsFunctions.IconType.iError);
                            }

                            Cursor.Current = Cursors.Default;
                        }
                    }
                    else {
                        cFunc.setMessageBox("File Not a valid " + Template + " File", "Error Message", clsFunctions.IconType.iWarning);
                        Tbx.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Open failed.");
            }
        }

    // REFRESH DASHBOARD
        public void Refresh_Dashboard()
        {
            Debug.WriteLine("--- Refresh Dashboard");
            var Refresh = Application.OpenForms.OfType<frmDashboard>().Single();
            Refresh.InitializeDisplay();
        }

    // CLEAR OBJ
        public void ClearObj()
        {
            tx_Imp_InstallationFile.Text
            = tx_Imp_ReprogFile.Text
            = tx_Imp_ServicingFile.Text
            = tx_Imp_RepairFile.Text
            = tx_Imp_Inventory.Text = string.Empty;

            cFunc.ClearDataGrid(dgv_Imp_Installation);
            cFunc.ClearDataGrid(dgv_Imp_Reprogramming);
            cFunc.ClearDataGrid(dgv_Imp_Servicing);
            cFunc.ClearDataGrid(dgv_Imp_Repair);
            cFunc.ClearDataGrid(dgv_Imp_Inventory);
            rtb_Imp_Selected.Clear();

            Refresh_Dashboard();
        }

    // EFFECTS
        private void Tm_FadeIn_Tick(object sender, EventArgs e)
        {
            cFunc.FadeIn(this, Tm_FadeIn);
        }

        private void Tm_FadeOut_Tick(object sender, EventArgs e)
        {
            cFunc.FadeOut(this, Tm_FadeOut);
        }
    }
}



