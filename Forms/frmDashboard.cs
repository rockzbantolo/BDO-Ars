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


namespace ActivityReportSystem.Forms
{

    public partial class frmDashboard : Form
    {
        private clsFunctions Func = new clsFunctions();
        private clsSQLModels SpMethod = new clsSQLModels();
        private clsDatabase Db = new clsDatabase();

    // OVERIDE TO REDUCE LAG AND FLICKERING

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

      
        public frmDashboard()
        {
            InitializeComponent();
            InitializeDisplay();
            Tm_FadeIn.Start();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            tpc_MenuPage.Width = 1250;
            cmb_Model_Template.Items.Clear();
            cmb_Model_Template.DataSource = clsFunctions.Templates;
        }


    // PROCESS DISPLAY

        public void InitializeDisplay()
        {
            Func.setDefaultValue();
            SpMethod.InitializeUpdates();
            Clear("Objects");

    // Dashboard Data

            SpMethod.setGridDetails(dgv_Sum_ComReq, string.Empty);
            SpMethod.setGridDetails(dgv_Sum_PenReq, string.Empty);
            SpMethod.setGridDetails(dgv_Model_List, string.Empty);
 
    // Summary Values

            Func.getSumValue();
            getDisplay();

        }

        private void getDisplay()
        {

            try
            {
                // OVERVIEW

                // INSTALLATION
                Func.setChartValue(chrt_Bdo_Display, 0, clsFunctions.sInstall.ToUpper(),  clsAppData.Template.inSum_Ttl_penIns);
                // REPROGRAMMING
                Func.setChartValue(chrt_Bdo_Display, 0, clsFunctions.sReprog.ToUpper(),   clsAppData.Template.inSum_Ttl_penReprog);
                // SERVICING
                Func.setChartValue(chrt_Bdo_Display, 0, clsFunctions.sServ.ToUpper(),     clsAppData.Template.inSum_Ttl_penServ);
                // REPAIR
                Func.setChartValue(chrt_Bdo_Display, 0, clsFunctions.sRepair.ToUpper(),   clsAppData.Template.inSum_Ttl_penRep);

                // PIE CHART
                Func.setChartValue(chrt_Bdo_Summary, 0, "", clsAppData.Template.inSum_Ttl_Com);
                Func.setChartValue(chrt_Bdo_Summary, 0, "", clsAppData.Template.inSum_Ttl_Pen);

                chrt_Bdo_Summary.Series[0].Points[0].Color = Color.FromArgb(41, 115, 185);
                chrt_Bdo_Summary.Series[0].Points[1].Color = Color.FromArgb(230, 40, 35);

                // BOX LABELS - SUMMARY VALUES
                lb_ComSum.Text = clsAppData.Template.inSum_Ttl_Com.ToString("n0");
                lb_PenSum.Text = clsAppData.Template.inSum_Ttl_Pen.ToString("n0");           

                lb_InsTotal.Text    = clsAppData.Template.inSum_Ttl_comIns.ToString("n0");
                lb_RepTotal.Text    = clsAppData.Template.inSum_Ttl_comReprog.ToString("n0");
                lb_ServTotal.Text   = clsAppData.Template.inSum_Ttl_comServ.ToString("n0");
                lb_RepairTotal.Text = clsAppData.Template.inSum_Ttl_comRep.ToString("n0");

                lb_C1.Text = Math.Round(clsAppData.Template.PInstall, 2).ToString() + "%";
                lb_C2.Text = Math.Round(clsAppData.Template.PReprog,  2).ToString() + "%";
                lb_C3.Text = Math.Round(clsAppData.Template.PServ,    2).ToString() + "%";
                lb_C4.Text = Math.Round(clsAppData.Template.PRepair,  2).ToString() + "%";

                //string.Format("{0:#,###0}", repTOTAL.ToString());
            }
            catch (Exception ex)
            {
                Func.setMessageBox(ex.Message, "Activity Report System", clsFunctions.IconType.iError);
            }


        }

        private void Clear(string Obj)
        {
            switch (Obj)
            {
                case "Inputs" :

                    cmb_Model_Template.Text = string.Empty;
                    dtp_Model_From.Value    = DateTime.Now;
                    dtp_Model_To.Value      = DateTime.Now;

                    cmb_Model.Text = string.Empty;
                    lb_Total_Deployed.Text  = "0";
                    lb_Total_Stocks.Text    = "0";
                    Func.ClearGridRows(dgv_Model_Status_List);
                    Func.ClearGridRows(dgv_Model_List);

                    break;

                case "Model" :

                    cmb_Model.Text = string.Empty;
                    lb_Total_Deployed.Text  = "0";
                    lb_Total_Stocks.Text    = "0";
                    Func.ClearGridRows(dgv_Model_List);

                    break;

                case "Date Search":

                    dgv_Model_Status_List.ClearSelection();
                    cmb_Model_Template.Text = string.Empty;
                    dtp_Model_From.Value    = DateTime.Now;
                    dtp_Model_To.Value      = DateTime.Now;
                    Func.ClearGridRows(dgv_Model_Status_List);

                    break;

                case "Charts":

                    Func.ClearCharts(chrt_Bdo_Display, 0);
                    Func.ClearCharts(chrt_Bdo_Summary, 0);

                    break;

                case "Objects":

                    Func.ClearCharts(chrt_Bdo_Display, 0);
                    Func.ClearCharts(chrt_Bdo_Summary, 0);

                    cmb_Model_Template.Text = string.Empty;
                    dtp_Model_From.Value    = DateTime.Now;
                    dtp_Model_To.Value      = DateTime.Now;

                    cmb_Model.Text          = string.Empty;
                    lb_Total_Deployed.Text  = "0";
                    lb_Total_Stocks.Text    = "0";

                    break;
            }

        }

       
    // TAB EVENTS 

        private void frmSummary_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:

                    if (MessageBox.Show("Do you want to quit the application?", "Exit Application",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tm_FadeOut.Start();
                    }

                    break;
            }
        }

        private void tpc_MenuPage1_Dash_KeyDown(object sender, KeyEventArgs e)
        {
            // DISABLED ARROW KEYS
            string tempstring = e.KeyValue.ToString();
            if (tempstring == "37" || tempstring == "38" || tempstring == "39" || tempstring == "40")
            {
                e.Handled = true;
            }
        }

        private void tpc_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            // DISABLED ARROW KEYS
            string tempstring = e.KeyValue.ToString();
            if (tempstring == "37" || tempstring == "38" || tempstring == "39" || tempstring == "40")
            {
                e.Handled = true;
            }
        }

    // BUTTONS

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the Application?", "Application Exit",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Tm_FadeOut.Start();
            }
        }

    // ------------------------------------------------------------------

        private void btn_Overview_Click(object sender, EventArgs e)
        {
            Func.LocationHighlight(sender, pnHover);
            Clear("Inputs");
            tpc_MenuPage.SelectedTab = tbp_Summary;
        }

        private void btn_ReportView_Click(object sender, EventArgs e)
        {
            frmShadow ShadowBG = new frmShadow();
            using (frmReportViewer report = new frmReportViewer())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);
                report.Owner = ShadowBG;
                report.ShowDialog();
                ShadowBG.Dispose();
            }
        }

        private void btn_Breakdown_Click(object sender, EventArgs e)
        {
            frmShadow ShadowBG = new frmShadow();
            using (frmBreakdown breakdown = new frmBreakdown())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);
                breakdown.Owner = ShadowBG;
                breakdown.ShowDialog();
                ShadowBG.Dispose();
            }

        }

    // ------------------------------------------------------------------

        private void btn_Model_Click(object sender, EventArgs e)
        {
            Func.LocationHighlight(sender, pnHover);
            Clear("Inputs");
            tpc_MenuPage.SelectedTab = tbp_Detailed;
        }

        private void btn_Model_Clear_Click(object sender, EventArgs e)
        {
            Clear("Date Search");
        }

        private void btn_Model_Search_Click(object sender, EventArgs e)
        {
            if (cmb_Model_Template.Text == "")
            {
                Func.setMessageBox("Please Select Template", "Date Search", clsFunctions.IconType.iInformation);
            }
            else if (cmb_Model_Template.Text == "Reprogramming")
            {
                Func.setMessageBox("No Available Data to Display","Date Search", clsFunctions.IconType.iInformation);
            }
            else
            {
                Func.ClearGridRows(dgv_Model_Status_List);
                SpMethod.setSearchDate(dgv_Model_Status_List, cmb_Model_Template, dtp_Model_From, dtp_Model_To);
                dgv_Model_Status_List.ClearSelection();
            }
        }

    // ------------------------------------------------------------------

        private void Tsm_Import_Click(object sender, EventArgs e)
        {
            // dbFunc.LocationHighlight(sender, pnHover);
            // TpcDashMain.SelectedTab = tbpMenuPage2;
            clsAppData.DataParam.MenuControls = Tsm_Import.Text;
            frmShadow ShadowBG = new frmShadow();

            using (frmMImport imports = new frmMImport())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);

                imports.Owner = ShadowBG;
                imports.ShowDialog();

                ShadowBG.Dispose();
            }
        }

    // CARD LINK

        private void lk_View_Installation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsAppData.DataParam.TempName = clsFunctions.sInstall;

            frmShadow ShadowBG = new frmShadow();
            using (frmSumDetails installation = new frmSumDetails())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);

                installation.Owner = ShadowBG;
                installation.ShowDialog();

                ShadowBG.Dispose();
            }
        }

        private void lk_View_Reprogram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsAppData.DataParam.TempName = clsFunctions.sReprog;

            frmShadow ShadowBG = new frmShadow();
            using (frmSumDetails reprogram = new frmSumDetails())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);

                reprogram.Owner = ShadowBG;
                reprogram.ShowDialog();

                ShadowBG.Dispose();
            }
        }

        private void lk_View_Service_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsAppData.DataParam.TempName = clsFunctions.sServ;

            frmShadow ShadowBG = new frmShadow();
            using (frmSumDetails servicing = new frmSumDetails())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);

                servicing.Owner = ShadowBG;
                servicing.ShowDialog();

                ShadowBG.Dispose();
            }
        }

        private void lk_View_Repair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsAppData.DataParam.TempName = clsFunctions.sRepair;

            frmShadow ShadowBG = new frmShadow();
            using (frmSumDetails repair = new frmSumDetails())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);

                repair.Owner = ShadowBG;
                repair.ShowDialog();

                ShadowBG.Dispose();
            }
        }

    // EVENTS

        private void dgv_Model_List_Leave(object sender, EventArgs e)
        {
            dgv_Model_List.ClearSelection();
        }

        private void dgv_Sum_ComReq_Leave(object sender, EventArgs e)
        {
            dgv_Sum_ComReq.ClearSelection();
        }

        private void dgv_Sum_PenReq_Leave(object sender, EventArgs e)
        {
            dgv_Sum_PenReq.ClearSelection();
        }

        private void dgv_Model_Status_List_Leave(object sender, EventArgs e)
        {
            dgv_Model_Status_List.ClearSelection();
        }

        private void cmb_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Model.Text.ToString() != string.Empty) {

                //Db.setCountDetails(cmb_Model.Text.ToString().Trim());
                SpMethod.setGridDetails(dgv_Model_List, cmb_Model.Text.ToString().Trim());
            }

            switch (cmb_Model.SelectedIndex) {

                case 0:
                    Clear("Model");
                    break;

                case 1:
                    SpMethod.setGridDetails(dgv_Model_List, string.Empty);
                    lb_Total_Deployed.Text  = clsAppData.Template.inSum_Ttl_comIns.ToString("n0");
                    lb_Total_Stocks.Text    = clsAppData.Template.Total_Stocks.ToString("n0");

                    break;

                case 2:
                    lb_Total_Deployed.Text  = clsAppData.Template.inMp200_Ttl_comIns.ToString("n0");
                    lb_Total_Stocks.Text    = clsAppData.Template.inMp200_Ttl_Stock.ToString("n0");

                    break;

                case 3:
                    lb_Total_Deployed.Text  = clsAppData.Template.inS1E_Ttl_comIns.ToString("n0");
                    lb_Total_Stocks.Text    = clsAppData.Template.inS1E_Ttl_Stock.ToString("n0");
                    break;
            }
        }

    #region Effects

    // FADE IN & OUT

        private void Tm_FadeIn_Tick(object sender, EventArgs e)
        {
            Func.FadeIn(this, Tm_FadeIn);
        }

        private void Tm_FadeOut_Tick(object sender, EventArgs e)
        {
            Func.FadeOut(this, Tm_FadeOut);
        }


    // PANEL CARD SHADOW

        private void pn_Menu_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_Menu, 0, 0, 0, 2);
        }

        private void pn_Card_Install_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_Card_Install, 0, 0, 3, 3);
        }

        private void pn_Card_Reprogram_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_Card_Reprogram, 0, 0, 3, 3);
        }

        private void pn_Card_Servicing_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_Card_Serv, 0, 0, 3, 3);
        }

        private void pn_Card_Repair_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_Card_Repair, 0, 0, 3, 3);
        }

        private void pn_Bdo_Sum_Body_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_Bdo_Sum_Body, 0, 0, 3, 3);
        }

        private void pn_MP200_Body_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_MP200_Body, 0, 0, 3, 3);
        }

        private void pn_Lookup_Body_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_Lookup_Body, 0, 0, 3, 3);
        }

        private void pn_PenSum_Body_Paint(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_PenSum_Body, 0, 0, 3, 3);
        }

        private void pn_MenuHeader_Paint_1(object sender, PaintEventArgs e)
        {
            Func.BorderShadow(e, pn_MenuHeader, 0, 0, 0, 2);
        }

    #endregion

    }

}