using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;
using Spire.Xls;
using MySql.Data.MySqlClient;
using ActivityReportSystem.Function;
using ActivityReportSystem.Database;
using ActivityReportSystem.Global;

namespace ActivityReportSystem.Forms
{
    public partial class frmLogin : Form
    {
        private clsFunctions dbFunction;
        private clsDatabase Db;

        public frmLogin()
        {
            InitializeComponent();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void CheckUserDetails(string v_Username, string v_Password)
        {
  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckUserDetails(txtUsername.Text, txtPassword.Text);

            if (sAppData.DataParam.strLogUsername != txtUsername.Text.Trim())
            {
                clsFunctions.setMessageBox("Incorrect Username", "Login", clsFunctions.IconType.iStop);

            }
            else if (sAppData.DataParam.strLogPassword != txtPassword.Text.Trim())
            {
                clsFunctions.setMessageBox("Incorrect Password", "Login", clsFunctions.IconType.iStop);
            }

        }
    }


}
