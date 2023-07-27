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
        private cFunctions dbFunction;

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

            if (AppData.DataParam.strLogUsername != txtUsername.Text.Trim())
            {
                //cFunctions.setMessageBox("Incorrect Username", "Login", cFunctions.IconType.iStop);

            }
            else if (AppData.DataParam.strLogPassword != txtPassword.Text.Trim())
            {
                //cFunctions.setMessageBox("Incorrect Password", "Login", cFunctions.IconType.iStop);
            }

        }
    }


}
