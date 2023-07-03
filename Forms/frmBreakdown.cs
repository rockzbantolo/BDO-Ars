using System;
using System.Drawing;
using System.Windows.Forms;
using ActivityReportSystem.Function;
using ActivityReportSystem.AppActivity.Controller;

namespace ActivityReportSystem.Forms
{
    public partial class frmBreakdown : Form
    {
        cFunctions cFunc = new cFunctions();
        cTerminal Trmnl  = new cTerminal();

        public frmBreakdown()
        {
            InitializeComponent();
        }

        private void frmBreakdown_Load(object sender, EventArgs e)
        {
            Trmnl.GetDetails(dgv_Status_Remarks);
            Tm_FadeIn.Start();
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

        public void ListItemsBackColor(DataGridView Grid)
        {
            int rowCount = Grid.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                switch (Grid.Rows[i].Cells[0].Value.ToString())
                {
                    case "1. INSTALLATION":
                        Grid.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                        Grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        break;

                    case "2. REPROGRAMMING":
                        Grid.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                        Grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        break;

                    case "3. SERVICING":
                        Grid.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                        Grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        break;

                    case "STEP 1. CALL-OUT & SHIPMENT FROM MERCHANT":
                        Grid.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                        Grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        break;

                    case "STEP 2. DIAGNOSIS & JOB ORDER c/o CITAS":
                        Grid.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                        Grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        break;

                    case "STEP 3. AWAITING MERCHANT PAYMENT":
                        Grid.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                        Grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        break;

                    case "STEP 4. ONGOING REPAIR c/o CITAS":
                        Grid.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                        Grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        break;

                    case "STEP 5. DONE REPAIR - RELEASED TO COURIER":
                        Grid.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                        Grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        break;
                }
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
