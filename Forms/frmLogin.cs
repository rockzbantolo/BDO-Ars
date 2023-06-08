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
            Debug.WriteLine("---- Start Check User Info ----");

            string sStoredProcedure = "spViewAccountDetails";

            if (Db.Connect())
            {
                try
                {
                    Db.Command = new MySqlCommand(sStoredProcedure, Db.Conn);
                    Db.Command.CommandType = CommandType.StoredProcedure;

                    // PARAMETERS
                    Db.Command.Parameters.Add(new MySqlParameter("@p_Username", v_Username));
                    Db.Command.Parameters.Add(new MySqlParameter("@p_Password", v_Password));

                    // EXECUTE COMMAND
                    Db.Reader = Db.Command.ExecuteReader();

                    // READ RECORD     
                    while (Db.Reader.Read())
                    {
                        clsAppData.DataParam.strLogUserId = Db.Reader["ID"].ToString().Trim();
                        clsAppData.DataParam.strLogUsername = Db.Reader["Username"].ToString().Trim();
                        clsAppData.DataParam.strLogPassword = Db.Reader["Password"].ToString().Trim();
                        clsAppData.DataParam.strLogUserLevel = Db.Reader["User_Level"].ToString().Trim();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
                finally
                {
                    if (Db.Conn != null)
                    {
                        Db.Disconnect();
                        Db.Reader.Close();
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckUserDetails(txtUsername.Text, txtPassword.Text);

            if (clsAppData.DataParam.strLogUsername != txtUsername.Text.Trim())
            {
                dbFunction.setMessageBox("Incorrect Username", "Login", clsFunctions.IconType.iStop);

            }
            else if (clsAppData.DataParam.strLogPassword != txtPassword.Text.Trim())
            {
                dbFunction.setMessageBox("Incorrect Password", "Login", clsFunctions.IconType.iStop);
            }

        }
    }


}
