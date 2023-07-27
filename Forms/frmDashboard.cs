using System;
using AppAction;
using System.Drawing;
using System.Windows.Forms;
using ActivityReportSystem.Function;
using ActivityReportSystem.Database;
using ActivityReportSystem.Global;
using ActivityReportSystem.AppActivity.Model;

namespace ActivityReportSystem.Forms
{

    public partial class frmDashboard : Form
    {
        cAppConfig SysSettings;

        cSourceCtrl   Src   = new cSourceCtrl();
        cTerminalCtrl Trmnl = new cTerminalCtrl();
        cFunctions    Func  = new cFunctions();


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
            SysSettings = new cAppConfig();
            InitializeComponent();
            Tm_FadeIn.Start();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            InitializeDisplay();
            tpc_MenuPage.Width = 1250;
            cmb_Model_Template.Items.Clear();
            cmb_Model_Template.DataSource = AppData.Templates;
        }

        // PROCESS DISPLAY
        public void InitializeDisplay()
        {
            Src.GetUpdates();
            Src.GetValues();

            Clear(Ctrl.Objects);

            Trmnl.GetDetails(dgv_Sum_ComReq);
            Trmnl.GetDetails(dgv_Sum_PenReq);
            Trmnl.GetDetails(dgv_Model_List);

            InitValues();
        }

        private void InitValues()
        {
            try
            {
                // OVERVIEW

                // INSTALLATION
                cFunctions.Charts.SetChartValue(chrt_Bdo_Display, 0, AppData.Installation.ToUpper(),  AppData.Template.iTotal_penIns);
                // REPROGRAMMING
                cFunctions.Charts.SetChartValue(chrt_Bdo_Display, 0, AppData.Reprogramming.ToUpper(), AppData.Template.iTotal_penReprog);
                // SERVICING
                cFunctions.Charts.SetChartValue(chrt_Bdo_Display, 0, AppData.Servicing.ToUpper(),     AppData.Template.iTotal_penServ);
                // REPAIR
                cFunctions.Charts.SetChartValue(chrt_Bdo_Display, 0, AppData.Repair.ToUpper(),        AppData.Template.iTotal_penRep);

                // PIE CHART
                cFunctions.Charts.SetChartValue(chrt_Bdo_Summary, 0, "", AppData.Template.iTotal_Com);
                cFunctions.Charts.SetChartValue(chrt_Bdo_Summary, 0, "", AppData.Template.iTotal_Pen);

                chrt_Bdo_Summary.Series[0].Points[0].Color = Color.FromArgb(41, 115, 185);
                chrt_Bdo_Summary.Series[0].Points[1].Color = Color.FromArgb(230, 40, 35);

                // BOX LABELS - SUMMARY VALUES
                lb_ComSum.Text = AppData.Template.iTotal_Com.ToString("n0");
                lb_PenSum.Text = AppData.Template.iTotal_Pen.ToString("n0");           

                lb_InsTotal.Text    = AppData.Template.iTotal_comIns.ToString("n0");
                lb_RepTotal.Text    = AppData.Template.iTotal_comReprog.ToString("n0");
                lb_ServTotal.Text   = AppData.Template.iTotal_comServ.ToString("n0");
                lb_RepairTotal.Text = AppData.Template.iTotal_comRep.ToString("n0");

                lb_C1.Text = Math.Round(AppData.Template.PInstall, 2).ToString() + "%";
                lb_C2.Text = Math.Round(AppData.Template.PReprog,  2).ToString() + "%";
                lb_C3.Text = Math.Round(AppData.Template.PServ,    2).ToString() + "%";
                lb_C4.Text = Math.Round(AppData.Template.PRepair,  2).ToString() + "%";

                //string.Format("{0:#,###0}", repTOTAL.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Activity Report System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Clear(Ctrl Obj)
        {
            switch (Obj)
            {
                case Ctrl.Inputs:

                    cmb_Model_Template.Text = string.Empty;
                    dtp_Model_From.Value    = DateTime.Now;
                    dtp_Model_To.Value      = DateTime.Now;

                    cmb_Model.Text = string.Empty;
                    lb_Total_Deployed.Text  = "0";
                    lb_Total_Stocks.Text    = "0";
                    cFunctions.Grid.ClearGridRows(dgv_Model_Status_List);

                    break;

                case Ctrl.Model :

                    cmb_Model.Text = string.Empty;
                    lb_Total_Deployed.Text  = "0";
                    lb_Total_Stocks.Text    = "0";
                    cFunctions.Grid.ClearGridRows(dgv_Model_List);

                    break;

                case Ctrl.Search:

                    dgv_Model_Status_List.ClearSelection();
                    cmb_Model_Template.Text = string.Empty;
                    dtp_Model_From.Value    = DateTime.Now;
                    dtp_Model_To.Value      = DateTime.Now;
                    cFunctions.Grid.ClearGridRows(dgv_Model_Status_List);

                    break;

                case Ctrl.Charts:

                    cFunctions.Charts.ClearCharts(chrt_Bdo_Display, 0);
                    cFunctions.Charts.ClearCharts(chrt_Bdo_Summary, 0);

                    break;

                case Ctrl.Objects:

                    cFunctions.Charts.ClearCharts(chrt_Bdo_Display, 0);
                    cFunctions.Charts.ClearCharts(chrt_Bdo_Summary, 0);

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
            cFunctions.Effects.LocationHighlight(sender, pnHover);
            Clear(Ctrl.Inputs);
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
            using (frmViewBreakdown breakdown = new frmViewBreakdown())
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
            cFunctions.Effects.LocationHighlight(sender, pnHover);
            Clear(Ctrl.Inputs);
            tpc_MenuPage.SelectedTab = tbp_Detailed;
        }

        private void btn_Model_Clear_Click(object sender, EventArgs e)
        {
            Clear(Ctrl.Search);
        }

        private void btn_Model_Search_Click(object sender, EventArgs e)
        {
            if (cmb_Model_Template.Text == "")
            {
                MessageBox.Show("Please Select Template", "Date Search",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmb_Model_Template.Text == "Reprogramming")
            {
                MessageBox.Show("No Available Data to Display", "Date Search",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get Details
            Trmnl.Template  = cmb_Model_Template.Text.ToString();
            Trmnl.DateFrom  = dtp_Model_From;
            Trmnl.DateTo    = dtp_Model_To;

            Trmnl.GetHistory(dgv_Model_Status_List);

            //Db.SearchTerminalHistory(dgv_Model_Status_List, cmb_Model_Template, dtp_Model_From, dtp_Model_To);

            dgv_Model_Status_List.ClearSelection();        
        }

    // ------------------------------------------------------------------

        private void Tsm_Import_Click(object sender, EventArgs e)
        {
            // dbFunc.LocationHighlight(sender, pnHover);
            // TpcDashMain.SelectedTab = tbpMenuPage2;
            AppData.DataParam.MenuControls = Tsm_Import.Text;
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
            frmShadow ShadowBG = new frmShadow();
            using (frmViewDetails installation = new frmViewDetails())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);

                installation.Owner = ShadowBG;
                installation.HeaderName = "Installation";
                installation.TableName = "tblinstallation";
                installation.ShowDialog();

                ShadowBG.Dispose();
            }
        }

        private void lk_View_Reprogram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppData.TemplateName = AppData.Reprogramming;

            frmShadow ShadowBG = new frmShadow();
            using (frmViewDetails reprogram = new frmViewDetails())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);

                reprogram.Owner = ShadowBG;
                reprogram.HeaderName = "Reprogramming";
                reprogram.TableName = "tblreprogramming";
                reprogram.ShowDialog();

                ShadowBG.Dispose();
            }
        }

        private void lk_View_Service_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppData.TemplateName = AppData.Servicing;

            frmShadow ShadowBG = new frmShadow();
            using (frmViewDetails servicing = new frmViewDetails())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);

                servicing.Owner = ShadowBG;
                servicing.HeaderName = "Servicing";
                servicing.TableName = "tblservicing";
                servicing.ShowDialog();

                ShadowBG.Dispose();
            }
        }

        private void lk_View_Repair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppData.TemplateName = AppData.Repair;

            frmShadow ShadowBG = new frmShadow();
            using (frmViewDetails repair = new frmViewDetails())
            {
                ShadowBG.Location = this.Location;
                ShadowBG.Size = this.Size;
                ShadowBG.Show(this);

                repair.Owner = ShadowBG;
                repair.HeaderName = "Repair";
                repair.TableName = "tblrepair";
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
            Trmnl.SearchValue = cmb_Model.Text.ToString();
            Trmnl.GetDetails(dgv_Model_List);

            // Get Inventory Count
            Src.SearchValue = cmb_Model.Text.ToString();
            Src.GetInventory();

            // Get Values
            Src.GetValues();

            // Display Value
            lb_Total_Deployed.Text  = Src.TotalDeployed.ToString();
            lb_Total_Stocks.Text    = Src.TotalStocks.ToString();
        }

    #region Effects

    // FADE IN & OUT

        private void Tm_FadeIn_Tick(object sender, EventArgs e)
        {
            cFunctions.Effects.FadeIn(this, Tm_FadeIn);
        }

        private void Tm_FadeOut_Tick(object sender, EventArgs e)
        {
            cFunctions.Effects.FadeOut(this, Tm_FadeOut);
        }


    // PANEL CARD SHADOW

        private void pn_Menu_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Menu, 0, 0, 0, 2);
        }

        private void pn_Card_Install_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Card_Install, 0, 0, 3, 3);
        }

        private void pn_Card_Reprogram_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Card_Reprogram, 0, 0, 3, 3);
        }

        private void pn_Card_Servicing_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Card_Serv, 0, 0, 3, 3);
        }

        private void pn_Card_Repair_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Card_Repair, 0, 0, 3, 3);
        }

        private void pn_Bdo_Sum_Body_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Bdo_Sum_Body, 0, 0, 3, 3);
        }

        private void pn_MP200_Body_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_MP200_Body, 0, 0, 3, 3);
        }

        private void pn_Lookup_Body_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_Lookup_Body, 0, 0, 3, 3);
        }

        private void pn_PenSum_Body_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_PenSum_Body, 0, 0, 3, 3);
        }

        private void pn_MenuHeader_Paint_1(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_MenuHeader, 0, 0, 0, 2);
        }

    #endregion

    }

}