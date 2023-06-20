using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ActivityReportSystem.Function;
using ActivityReportSystem.Database;
using ActivityReportSystem.Global;
using System.Drawing;
using System.Text;
using ActivityReportSystem.AppActivity.View;

namespace ActivityReportSystem.Forms
{
    public partial class frmBreakdown : Form
    {
        private cFunctions cFunc = new cFunctions();
        clsAppViews Db = new clsAppViews();

        public frmBreakdown()
        {
            InitializeComponent();
        }

        private void frmBreakdown_Load(object sender, EventArgs e)
        {
            Db.LoadDashboardDetails(dgv_BdPendings, string.Empty);
            Db.LoadDashboardDetails(dgv_Bdp_Rep, string.Empty);

            ListItemsBackColor(dgv_BdPendings);
            ListItemsBackColor(dgv_Bdp_Rep);
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

        private void dgv_BdPendings_Leave(object sender, EventArgs e)
        {
            dgv_BdPendings.ClearSelection();
        }

        private void dgv_Bdp_Rep_Leave(object sender, EventArgs e)
        {
            dgv_Bdp_Rep.ClearSelection();
        }

        private void Tm_FadeIn_Tick(object sender, EventArgs e)
        {
            cFunctions.Effects.FadeIn(this, Tm_FadeIn);
        }

        private void Tm_FadeOut_Tick(object sender, EventArgs e)
        {
            cFunctions.Effects.FadeOut(this, Tm_FadeOut);
        }


        /*
        private void lvwBDPendings_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender != lvwBDPendings) return;

            if (e.Control && e.KeyCode == Keys.C)
                CopySelectedValuesToClipboard(lvwBDPendings);
        }

        private void CopySelectedValuesToClipboard(ListView LvItems)
        {
            var builder = new StringBuilder();

            foreach (ListViewItem item in LvItems.SelectedItems)

                builder.AppendLine(
                      item.SubItems[1].Text + "     "
                    + item.SubItems[2].Text + "     "
                    + item.SubItems[3].Text + "     "
                    + item.SubItems[4].Text + "     "
                    + item.SubItems[5].Text);

            Clipboard.SetText(builder.ToString());
        }

        public void ListItemsBackColor(DataGridView Grid)
        {

            foreach (DataGridViewRow gridRows in Grid.Rows)
            {
                var item = gridRows.Cells[0].Value.ToString().Trim();

                switch (item)
                {
                    case "1. INSTALLATION":
                        gridRows.Cells[0].Style.BackColor = Color.SteelBlue;
                        gridRows.Cells[0].Style.ForeColor = Color.White;
                        break;

                    case "2. REPROGRAMMING":
                        item.BackColor = Color.SteelBlue;
                        item.ForeColor = Color.White;
                        break;

                    case "3. SERVICING":
                        item.BackColor = Color.SteelBlue;
                        item.ForeColor = Color.White;
                        break;

                    case "STEP 1. CALL-OUT & SHIPMENT FROM MERCHANT":
                        item.BackColor = Color.SteelBlue;
                        item.ForeColor = Color.White;
                        break;

                    case "STEP 2. DIAGNOSIS & JOB ORDER c/o CITAS":
                        item.BackColor = Color.SteelBlue;
                        item.ForeColor = Color.White;
                        break;

                    case "STEP 3. AWAITING MERCHANT PAYMENT":
                        item.BackColor = Color.SteelBlue;
                        item.ForeColor = Color.White;
                        break;

                    case "STEP 4. ONGOING REPAIR c/o CITAS":
                        item.BackColor = Color.SteelBlue;
                        item.ForeColor = Color.White;
                        break;

                    case "STEP 5. DONE REPAIR - RELEASED TO COURIER":
                        item.BackColor = Color.SteelBlue;
                        item.ForeColor = Color.White;
                        break;

                }
            }
        }
        

       private void Load_Dashboard_Details(string StatementType, string SearchBy, string SearchPart)
        {
            // int inLineNo = 0;
            string sStoredProcedure = "spViewDashboardDetails";

            if (dbConn.Open_Connection())
            {
                try
                {
                    dbConn.command = new MySqlCommand(sStoredProcedure, dbConn.conn);
                    dbConn.command.CommandType = CommandType.StoredProcedure;

                    // PARAMETERS
                    dbConn.command.Parameters.Add(new MySqlParameter("@p_StatementType", StatementType));
                    dbConn.command.Parameters.Add(new MySqlParameter("@p_SearchBy", SearchBy));
                    dbConn.command.Parameters.Add(new MySqlParameter("@p_SearchPart", SearchPart));

                    // EXECUTE COMMAND
                    dbConn.reader = dbConn.command.ExecuteReader();

                    // READ RECORD     
                    while (dbConn.reader.Read())
                    {
                        // inLineNo++;
                        // ListViewItem item = new ListViewItem(inLineNo.ToString());
                        ListViewItem item = new ListViewItem();

                        switch (SearchPart)
                        {

                            case "BdPendings":
                                item.SubItems.Add(dbConn.reader["Template"].ToString().Trim());
                                item.SubItems.Add(dbConn.reader["7Days"].ToString().Trim());
                                item.SubItems.Add(dbConn.reader["7_30Days"].ToString().Trim());
                                item.SubItems.Add(dbConn.reader["30Days"].ToString().Trim());
                                item.SubItems.Add(dbConn.reader["Total"].ToString().Trim());
                                lvwBDPendings.Items.Add(item);
                                break;

                            case "BdpRepair":
                                item.SubItems.Add(dbConn.reader["Template"].ToString().Trim());
                                item.SubItems.Add(dbConn.reader["7Days"].ToString().Trim());
                                item.SubItems.Add(dbConn.reader["7_30Days"].ToString().Trim());
                                item.SubItems.Add(dbConn.reader["30Days"].ToString().Trim());
                                item.SubItems.Add(dbConn.reader["Total"].ToString().Trim());
                                lvwBDP_Rep.Items.Add(item);
                                break;

                        }
                        //  Debug.WriteLine("Line#" + inLineNo + "," + dbConnect.reader[""]);     
                    }

                }
                catch (MySqlException ex)
                {
                    dbConn.MySQLErrorHandlerMessage(ex, "Load Dashboard Details", sStoredProcedure, StatementType, "", "", "", "", "");
                    throw ex;
                }
                finally
                {
                    if (dbConn.conn != null)
                    {
                        dbConn.Close_Connection();
                        dbConn.reader.Close();
                    }
                }
            }

        } */

    }
}
