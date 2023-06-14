using ActivityReportSystem.AppActivity.View;
using ActivityReportSystem.Database;
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
    public partial class Frm_Testing : Form
    {
        clsAppViews Db = new clsAppViews();

        public Frm_Testing()
        {
            InitializeComponent();
            clsAppConfig SystemSettings = new clsAppConfig();
            Db.UpdateDashboard();
        }

        private void Frm_Testing_Load(object sender, EventArgs e)
        {
            Db.LoadDashboardDetails(Dgv_Testing, string.Empty);
        }
    }
}
