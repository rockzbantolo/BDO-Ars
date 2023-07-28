using System;
using System.Drawing;
using System.Windows.Forms;
using ActivityReportSystem.Function;
using ActivityReportSystem.AppActivity.Model;

namespace ActivityReportSystem.Forms
{
    public partial class frmViewBreakdown : Form
    {
        cFunctions cFunc = new cFunctions();
        cTerminalCtrl Trmnl  = new cTerminalCtrl();

        public frmViewBreakdown()
        {
            InitializeComponent();
        }

        private void frmBreakdown_Load(object sender, EventArgs e)
        {
            cFunctions.Effects.setDoubleBuffer(dgv_Status_Remarks, true);

            Tm_FadeIn.Start();
            Trmnl.GetDetails(dgv_Status_Remarks);
        }

        private void frmBreakdown_KeyDown(object sender, KeyEventArgs e)
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

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Trmnl.SearchValue = Tx_Search.Text;
            Trmnl.GetDetails(dgv_Status_Remarks);
        }
    }
}
