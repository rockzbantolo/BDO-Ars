using ActivityReportSystem.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityReportSystem.Forms
{
    public partial class frmMain : Form
    {
        private bool isMaximized = false;
        private FormWindowState originalState;

        public frmMain()
        {
            InitializeComponent();
        }

        private void pn_MenuHeader_Paint(object sender, PaintEventArgs e)
        {
            cFunctions.Effects.BorderShadow(e, pn_MenuHeader, 0, 0, 0, 2);
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                originalState = this.WindowState;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = originalState;
            }

            isMaximized = !isMaximized;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
      
        }
    }
}
