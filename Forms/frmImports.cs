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

            Src.ImportDetails(AppData.Installation);
            Src.ImportDetails(AppData.Reprogramming);
            Src.ImportDetails(AppData.Servicing);
            Src.ImportDetails(AppData.Repair);
            Src.ImportDetails(AppData.Inventory);

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

        // BORDER SHADOW
        private void pn_Imp_BxTemplate_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Imp_BxTemplate, 0, 0, 3, 3);
        }


        // OPEN FILE DIALOG BUTTONS
        private void btn_Imp_OpenInstallation_Click(object sender, EventArgs e)
        {
            Src.SearchValue = AppData.Installation;
            Src.ImportProcess(tx_Imp_InstallationFile);

            //Db.ProcessFile(tx_Imp_InstallationFile, sAppData.Installation);
        }

        private void btn_Imp_OpenReprog_Click(object sender, EventArgs e)
        {
            Src.SearchValue = AppData.Reprogramming;
            Src.ImportProcess(tx_Imp_ReprogFile);

            //Db.ProcessFile(tx_Imp_ReprogFile, sAppData.Reprogramming);
        }

        private void btn_Imp_OpenServicing_Click(object sender, EventArgs e)
        {
            Src.SearchValue = AppData.Servicing;
            Src.ImportProcess(tx_Imp_ServicingFile);

            //Db.ProcessFile(tx_Imp_ServicingFile, sAppData.Servicing);
        }

        private void btn_Imp_OpenRepair_Click(object sender, EventArgs e)
        {
            Src.SearchValue = AppData.Repair;
            Src.ImportProcess(tx_Imp_RepairFile);

            //Db.ProcessFile(tx_Imp_RepairFile, sAppData.Repair);
        }

        private void btn_Imp_OpenInvent_Click(object sender, EventArgs e)
        {
            Src.SearchValue = AppData.Inventory;
            Src.ImportProcess(tx_Imp_Inventory);

            //Db.ProcessFile(tx_Imp_Inventory, sAppData.Inventory);
        }


        // REFRESH DASHBOARD
        public void Refresh_Dashboard()
        {
            Debug.WriteLine(" ---- Refresh Dashboard -----");
            frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
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



