using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityReportSystem.Database
{
    class clsSQLModels
    {
        clsDatabase Db    = new clsDatabase();
        clsFunctions Func = new clsFunctions();

        public clsSQLModels()
        {
            bool fConnected = Db.ClientConnection();
        }


        #region MySQL Data Models

        public void InitializeUpdates()
        {
            CollectionUpdate("Update", "Dashboard", "");
            ViewCountDetails("Count", "cTotals", "");
        }

        public void setCollectionInsert(string Template, DataGridView Obj)
        {
            //Stopwatch Sw = new Stopwatch();
            //Sw.Start();
            //int BatchNo = 0;

            StringBuilder CellValue = new StringBuilder();
            StringBuilder TempQuery = new StringBuilder();
            StringBuilder Query = new StringBuilder();
            var cultureInfo = new CultureInfo("en-US");

            clsAppData.DataParam.outMessage = string.Empty;
            string RowQuery = string.Empty;
            string TempValue = string.Empty;
            bool isDateTime = false;
            DateTime TempDate;

            int Remainder = 0,
                iDataSize = 0,
                BatchSize = 150;


            if (Obj.RowCount > 0)
            {

                for (int g = 0; g < Obj.Rows.Count; g++)
                {
                    iDataSize += 1;
                }

                Remainder = iDataSize % BatchSize;

                if (MessageBox.Show("Do you want to Delete Existing " + Template + " Database?" + "\nWarning this will permanently delete the data", "Database",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    CollectionDelete("Delete", Template, string.Empty, string.Empty); //  Delete Existing Data
                }


                for (int i = 0; i < Obj.RowCount; i++)
                {
                    TempQuery.Append('(');

                    for (int x = 0; x < Obj.ColumnCount; x++)
                    {

                        CellValue.Clear();

                        CellValue.Append(Obj.Rows[i].Cells[x].Value.ToString().Trim());
                        CellValue.Append(CellValue.Length > 0 ? string.Empty : "-");

                        // Remove Special Characters
                        CellValue.Replace("ñ", "n");
                        CellValue.Replace("Ñ", "N");
                        CellValue.Replace(" ", string.Empty);
                        CellValue.Replace(",", string.Empty);
                        CellValue.Replace("'", string.Empty);
                        CellValue.Replace("#NAME?", string.Empty);
                        CellValue.Replace("#VALUE!", string.Empty);

                        // Check Cell for Date Formats
                        isDateTime = DateTime.TryParse(CellValue.ToString(), out TempDate);

                        if (!isDateTime) TempValue = CellValue.ToString();
                        else TempValue = TempDate.ToString(clsFunctions.sDateTimeFormat);

                        TempQuery.Append(string.Concat("'", TempValue, "',"));

                    }

                    TempQuery.Length = TempQuery.Length - 1; // Remove Last
                    TempQuery.Append(')');

                    RowQuery = TempQuery.ToString();
                    TempQuery.Clear();

                    if (Query.Length > 0) Query.Append(string.Concat(", ", Environment.NewLine, RowQuery));
                    else Query.Append(RowQuery);


                    if ((i % BatchSize) == 0 && i >= 0)
                    {

                        // Insert to Database
                        CollectionInsert("Insert", Template, Query.ToString());

                        RowQuery = string.Empty;
                        TempQuery.Clear();
                        Query.Clear();

                    }

                    if (iDataSize <= Remainder)
                    {
                        if (Query.ToString() != string.Empty)
                        {

                            // Insert to Database
                            CollectionInsert("Insert", Template, Query.ToString());

                            RowQuery = string.Empty;
                            TempQuery.Clear();
                            Query.Clear();

                        }
                    }

                    iDataSize--;
                }

                CellValue = null;
                TempQuery = null;
                Query = null;
                Obj = null;

                // Check For Error Message
                if (clsAppData.DataParam.outMessage.Length > 0)
                {
                    MessageBox.Show(clsAppData.DataParam.outMessage + "\n" + Template + " Column Count Doesn't Match Database Column",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Sw.Stop();
                    //Debug.WriteLine($"Time Lapse : {Sw.ElapsedMilliseconds}ms");

                    MessageBox.Show(Template + " Import Successfull", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public void setGridDetails(DataGridView Obj, string Value)
        {
            switch (Obj.Name)
            {
                case "dgv_Sum_ComReq":
                    ViewCollectionDetails(Obj, "View", "ComRequest", Value);
                    break;

                case "dgv_Sum_PenReq":
                    ViewCollectionDetails(Obj, "View", "PenRequest", Value);
                    break;

                case "dgv_BdPendings":
                    ViewCollectionDetails(Obj, "View", "BDPending", Value);
                    break;

                case "dgv_Bdp_Rep":
                    ViewCollectionDetails(Obj, "View", "BDPenRepair", Value);
                    break;

                case "dgv_Model_List":
                    ViewCollectionDetails(Obj, "View", "TerminalStatus", Value);
                    break;
            }
        }

        public void setDetailedStatus(DataGridView Obj, Label Com, Label Pen, Label Can)
        {

            switch (clsAppData.DataParam.TempName)
            {
                case clsFunctions.sInstall:

                    ViewCollectionDetails(Obj, "View", clsFunctions.sInstall, "");

                    Com.Text = clsAppData.Template.inSum_Ttl_comIns.ToString("n0");
                    Pen.Text = clsAppData.Template.inSum_Ttl_penIns.ToString("n0");
                    Can.Text = clsAppData.Template.inSum_Ttl_canIns.ToString("n0");

                    Obj.ClearSelection();

                    break;

                case clsFunctions.sReprog:

                    ViewCollectionDetails(Obj, "View", clsFunctions.sReprog, "");

                    Com.Text = clsAppData.Template.inSum_Ttl_comReprog.ToString("n0");
                    Pen.Text = clsAppData.Template.inSum_Ttl_penReprog.ToString("n0");
                    Can.Text = clsAppData.Template.inSum_Ttl_canReprog.ToString("n0");

                    Obj.ClearSelection();

                    break;

                case clsFunctions.sServ:

                    ViewCollectionDetails(Obj, "View", clsFunctions.sServ, "");

                    Com.Text = clsAppData.Template.inSum_Ttl_comServ.ToString("n0");
                    Pen.Text = clsAppData.Template.inSum_Ttl_penServ.ToString("n0");
                    Can.Text = clsAppData.Template.inSum_Ttl_canServ.ToString("n0");

                    Obj.ClearSelection();

                    break;

                case clsFunctions.sRepair:

                    ViewCollectionDetails(Obj, "View", clsFunctions.sRepair, "");

                    Com.Text = clsAppData.Template.inSum_Ttl_comRep.ToString("n0");
                    Pen.Text = clsAppData.Template.inSum_Ttl_penRep.ToString("n0");
                    Can.Text = clsAppData.Template.inSum_Ttl_canRep.ToString("n0");

                    Obj.ClearSelection();

                    break;
            }
        }

        public void setSearchDate(DataGridView Obj, ComboBox Template, DateTimePicker DateFrom, DateTimePicker DateTo)
        {
            Template.BeginUpdate();

            switch (Template.Text)
            {
                case clsFunctions.sInstall:
                    ViewSearchDate(Obj, "tblinstallation", DateFrom.Value.ToString(clsFunctions.sDateFormat) + "|" + DateTo.Value.ToString(clsFunctions.sDateFormat));
                    break;

                case clsFunctions.sReprog:
                    ViewSearchDate(Obj, "tblreprogramming", DateFrom.Value.ToString(clsFunctions.sDateFormat) + "|" + DateTo.Value.ToString(clsFunctions.sDateFormat));
                    break;

                case clsFunctions.sServ:
                    ViewSearchDate(Obj, "tblservicing", DateFrom.Value.ToString(clsFunctions.sDateFormat) + "|" + DateTo.Value.ToString(clsFunctions.sDateFormat));
                    break;

                case clsFunctions.sRepair:
                    ViewSearchDate(Obj, "tblrepair", DateFrom.Value.ToString(clsFunctions.sDateFormat) + "|" + DateTo.Value.ToString(clsFunctions.sDateFormat));
                    break;
            }

            Template.EndUpdate();
        }

        #endregion


        #region MySQL Data Commands

        private void CollectionDelete(string StatementType, string SearchBy, string SearchValue, string MaintenanceType)
        {
            StringBuilder Sb = new StringBuilder();

            //Debug.WriteLine("pStatementType=" + dbFunction.AddBracketStartEnd(pStatementType));
            //Debug.WriteLine("pMaintenanceType=" + dbFunction.AddBracketStartEnd(pMaintenanceType));
            //Debug.WriteLine("p_SearchBy =" + dbFunction.AddBracketStartEnd(pSearchBy));

            string pStoredProcedureName = "spCollectionDelete";

            Sb.Append(string.Concat("CALL ", pStoredProcedureName, "(\"", StatementType, "\"", ",\"" + SearchBy + "\"", ",\"", SearchValue, "\"", ",", MaintenanceType, ");"));
            Debug.WriteLine(Sb);


            if (Db.Connect())
            {
                Debug.WriteLine("--- Start " + SearchBy + " DeleteCollectionMaster\n");

                try
                {

                    using (Db.Command = new MySqlCommand(pStoredProcedureName, Db.Conn))
                    {

                        Db.Command.CommandType = CommandType.StoredProcedure;

                        // Parameter                    
                        Db.Command.Parameters.Add(new MySqlParameter("@p_StatementType", StatementType));
                        Db.Command.Parameters.Add(new MySqlParameter("@p_SearchBy", SearchBy));
                        Db.Command.Parameters.Add(new MySqlParameter("@p_SearchValue", SearchValue));
                        Db.Command.Parameters.Add(new MySqlParameter("@p_MaintenanceType", MaintenanceType));

                        Db.Reader = Db.Command.ExecuteReader(); // execute the command
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Collection Delete" + SearchBy, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
                finally
                {

                    if (Db.Conn != null)
                    {

                        Db.Disconnect();
                        Db.Reader.Dispose();
                    }
                }
            }
        }

        private void CollectionInsert(string StatementType, string MaintenanceType, string SQL)
        {
            StringBuilder Sb = new StringBuilder();

            //Debug.WriteLine("pStatementType="+ dbFunction.AddBracketStartEnd(pStatementType));
            //Debug.WriteLine("pMaintenanceType=" + dbFunction.AddBracketStartEnd(pMaintenanceType));
            //Debug.WriteLine("pSQL=" + dbFunction.AddBracketStartEnd(pSQL));

            string pStoredProcedureName = "spCollectionInsert";

            Sb.Append(string.Concat("CALL ", pStoredProcedureName, "(\"", StatementType, "\"", ",\"", MaintenanceType, "\"", ",\"", SQL, "\n"));
            Debug.WriteLine(Sb);

            if (Db.Connect())
            {

                try
                {

                    using (Db.Command = new MySqlCommand(pStoredProcedureName, Db.Conn))
                    {

                        Db.Command.CommandType = CommandType.StoredProcedure;

                        // Parameter                    
                        Db.Command.Parameters.Add(new MySqlParameter("@p_StatementType", StatementType));
                        Db.Command.Parameters.Add(new MySqlParameter("@p_MaintenanceType", MaintenanceType));
                        Db.Command.Parameters.Add(new MySqlParameter("@p_SQL", SQL));

                        // Output
                        Db.Command.Parameters.Add(new MySqlParameter("@p_outErrorMessage", MySqlDbType.VarChar));
                        Db.Command.Parameters["@p_outErrorMessage"].Direction = ParameterDirection.Output;

                        Db.Command.Parameters.Add(new MySqlParameter("@p_outLastInsertID", MySqlDbType.VarChar, 12));
                        Db.Command.Parameters["@p_outLastInsertID"].Direction = ParameterDirection.Output;


                        Db.Reader = Db.Command.ExecuteReader(); // Execute Command

                        // Hold to Variable
                        clsAppData.DataParam.outMessage = Db.Command.Parameters["@p_outErrorMessage"].Value.ToString().Trim();
                        clsAppData.DataParam.outLastInserted = Db.Command.Parameters["@p_outLastInsertID"].Value.ToString().Trim();

                        //Debug.WriteLine("outMessage=" + cFunc.AddBracketStartEnd(cGvar.outMessage));
                        //Debug.WriteLine("outLastInserted=" + cFunc.AddBracketStartEnd(cGvar.outLastInserted));
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Collection Insert : " + MaintenanceType, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
                finally
                {

                    if (Db.Conn != null)
                    {

                        Db.Disconnect();
                        Db.Reader.Dispose();
                    }
                }

            }

        }

        private void CollectionUpdate(string StatementType, string SearchBy, string SearchVal)
        {
            string sStoredProcedure = "spCollectionUpdate";

            try
            {

                Debug.WriteLine("--- Initialize Update " + SearchBy);

                using (Db.Command = new MySqlCommand(sStoredProcedure, Db.Conn))
                {

                    Db.Command.CommandType = CommandType.StoredProcedure;

                    // Parameter
                    Db.Command.Parameters.Add(new MySqlParameter("@p_StatementType", StatementType));
                    Db.Command.Parameters.Add(new MySqlParameter("@p_SearchBy", SearchBy));
                    Db.Command.Parameters.Add(new MySqlParameter("@p_SearchVal", SearchVal));

                    // Execute Command
                    Db.Connect();
                    Db.Command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {

                MySQLErrorHandlerMessage(ex, "Collection Update", sStoredProcedure, StatementType, "", "", "", "", "");
                throw ex;
            }
            finally
            {

                if (Db.Conn != null)
                {

                    Db.Disconnect();
                }
            }
        }

        private void ViewCollectionDetails(DataGridView Obj, string StatementType, string SearchBy, string SearchVal) {

            string sStoredProcedure = "spCollectionDetails";
            Obj.Rows.Clear();

            if (Db.Connect()) {

                Debug.WriteLine("--- Get " + SearchBy + " Request");

                try {

                    using (Db.Command = new MySqlCommand(sStoredProcedure, Db.Conn)) {

                        Db.Command.CommandType = CommandType.StoredProcedure;

                        // Parameters
                        Db.Command.Parameters.Add(new MySqlParameter("@StatementType", StatementType));
                        Db.Command.Parameters.Add(new MySqlParameter("@SearchBy", SearchBy));
                        Db.Command.Parameters.Add(new MySqlParameter("@SearchVal", SearchVal));

                        // Execute Command
                        using (Db.Reader = Db.Command.ExecuteReader()) {

                            // Read Record    
                            while (Db.Reader.Read()) {

                                switch (SearchBy) {

                                    case "ComRequest":
                                        Obj.Rows.Add(
                                        Db.Reader["Template"].ToString().Trim(),
                                        Db.Reader["TDelivered"].ToString().Trim(),
                                        Db.Reader["TResolved"].ToString().Trim(),
                                        Db.Reader["Total"].ToString().Trim());
                                        break;

                                    case "PenRequest":
                                        Obj.Rows.Add(
                                        Db.Reader["Template"].ToString().Trim(),
                                        Db.Reader["Day7"].ToString().Trim(),
                                        Db.Reader["Day730"].ToString().Trim(),
                                        Db.Reader["Day30"].ToString().Trim(),
                                        Db.Reader["Total"].ToString().Trim());
                                        break;

                                    case "BDPending":
                                        Obj.Rows.Add(
                                        Db.Reader["Template"].ToString().Trim(),
                                        Db.Reader["Day7"].ToString().Trim(),
                                        Db.Reader["Day730"].ToString().Trim(),
                                        Db.Reader["Day30"].ToString().Trim(),
                                        Db.Reader["Total"].ToString().Trim());
                                        break;

                                    case "BDPenRepair":
                                        Obj.Rows.Add(
                                        Db.Reader["Template"].ToString().Trim(),
                                        Db.Reader["Day7"].ToString().Trim(),
                                        Db.Reader["Day730"].ToString().Trim(),
                                        Db.Reader["Day30"].ToString().Trim(),
                                        Db.Reader["Total"].ToString().Trim());
                                        break;

                                    case "TerminalStatus":
                                        Obj.Rows.Add(
                                        Db.Reader["Terminal_Model"].ToString().Trim(),
                                        Db.Reader["Template"].ToString().Trim(),
                                        Db.Reader["Completed"].ToString().Trim(),
                                        Db.Reader["Pending"].ToString().Trim(),
                                        Db.Reader["Cancelled"].ToString().Trim());
                                        break;

                                    case clsFunctions.sInstall:
                                        Obj.Rows.Add(
                                        Db.Reader["ID"].ToString().Trim(),
                                        Db.Reader["ID"].ToString().Trim(),
                                        Db.Reader["Terminal_Model"].ToString().Trim(),
                                        Db.Reader["Merchant_ID"].ToString().Trim(),
                                        Db.Reader["Terminal_ID"].ToString().Trim(),
                                        Db.Reader["Serial_No"].ToString().Trim(),
                                        Db.Reader["Merchant_Name"].ToString().Trim(),
                                        Db.Reader["Status"].ToString().Trim(),
                                        Db.Reader["Status_Remarks"].ToString().Trim(),
                                        Db.Reader["Dependency_for_Pending"].ToString().Trim(),
                                        Db.Reader["Date_Received"].ToString().Trim(),
                                        Db.Reader["Terminal_Age"].ToString().Trim());
                                        break;

                                    case clsFunctions.sReprog:
                                        Obj.Rows.Add(
                                        Db.Reader["ID"].ToString().Trim(),
                                        Db.Reader["ID"].ToString().Trim(),
                                        Db.Reader["Terminal_Model"].ToString().Trim(),
                                        Db.Reader["Merchant_ID"].ToString().Trim(),
                                        Db.Reader["Terminal_ID"].ToString().Trim(),
                                        Db.Reader["Serial_No"].ToString().Trim(),
                                        Db.Reader["Merchant_Name"].ToString().Trim(),
                                        Db.Reader["Status"].ToString().Trim(),
                                        Db.Reader["Status_Remarks"].ToString().Trim(),
                                        Db.Reader["Dependency_for_Pending"].ToString().Trim(),
                                        Db.Reader["Date_Received"].ToString().Trim(),
                                        Db.Reader["Terminal_Age"].ToString().Trim());
                                        break;

                                    case clsFunctions.sServ:
                                        Obj.Rows.Add(
                                        Db.Reader["ID"].ToString().Trim(),
                                        Db.Reader["Case_Referral"].ToString().Trim(),
                                        Db.Reader["Terminal_Model"].ToString().Trim(),
                                        Db.Reader["Merchant_ID"].ToString().Trim(),
                                        Db.Reader["Terminal_ID"].ToString().Trim(),
                                        Db.Reader["Serial_No"].ToString().Trim(),
                                        Db.Reader["Merchant_Name"].ToString().Trim(),
                                        Db.Reader["Status"].ToString().Trim(),
                                        Db.Reader["Status_Remarks"].ToString().Trim(),
                                        Db.Reader["Dependency_for_Pending"].ToString().Trim(),
                                        Db.Reader["Date_Received"].ToString().Trim(),
                                        Db.Reader["Terminal_Age"].ToString().Trim());
                                        break;

                                    case clsFunctions.sRepair:
                                        Obj.Rows.Add(
                                        Db.Reader["ID"].ToString().Trim(),
                                        Db.Reader["Terminal_Model"].ToString().Trim(),
                                        Db.Reader["Case_Referral"].ToString().Trim(),
                                        Db.Reader["Merchant_ID"].ToString().Trim(),
                                        Db.Reader["Terminal_ID"].ToString().Trim(),
                                        Db.Reader["Serial_No"].ToString().Trim(),
                                        Db.Reader["Merchant_Name"].ToString().Trim(),
                                        Db.Reader["Status"].ToString().Trim(),
                                        Db.Reader["Status_Remarks"].ToString().Trim(),
                                        Db.Reader["Dependency_for_Pending"].ToString().Trim(),
                                        Db.Reader["Date_Received"].ToString().Trim(),
                                        Db.Reader["Terminal_Age"].ToString().Trim());
                                        break;

                                }
                            }

                            Obj.ClearSelection();
                            Obj = null;
                        }
                    }
                }
                catch (MySqlException ex) {

                    MySQLErrorHandlerMessage(ex, "Grid Collection Details", sStoredProcedure, StatementType, SearchBy, "", "", "", "");
                    throw ex;

                } finally {

                    if (Db.Conn != null) {

                        Db.Disconnect();
                        Db.Reader.Dispose();
                    }
                }
            }

        }

        private void ViewCountDetails(string StatementType, string SearchBy, string SearchVal)
        {
            string sStoredProcedure = "spCollectionDetails";

            if (Db.Connect())
            {

                Debug.WriteLine("--- Initialize Values : " + SearchBy + ", " + SearchVal);

                try
                {

                    using (Db.Command = new MySqlCommand(sStoredProcedure, Db.Conn))
                    {
                        Db.Command.CommandType = CommandType.StoredProcedure;

                        // PARAMETERS
                        Db.Command.Parameters.Add(new MySqlParameter("@StatementType", StatementType));
                        Db.Command.Parameters.Add(new MySqlParameter("@SearchBy", SearchBy));
                        Db.Command.Parameters.Add(new MySqlParameter("@SearchVal", SearchVal));

                        // EXECUTE COMMAND
                        using (Db.Reader = Db.Command.ExecuteReader())
                        {

                            // READ RECORD     
                            while (Db.Reader.Read())
                            {

                                switch (SearchBy)
                                {

                                    case "cTotals":

                                        //Total Data
                                        clsAppData.Template.InstallVolume   = int.Parse(Db.Reader["TotalIns"].ToString().Trim());
                                        clsAppData.Template.ReprogVolume    = int.Parse(Db.Reader["TotalReprog"].ToString().Trim());
                                        clsAppData.Template.ServVolume      = int.Parse(Db.Reader["TotalServ"].ToString().Trim());
                                        clsAppData.Template.RepairVolume    = int.Parse(Db.Reader["TotalRep"].ToString().Trim());

                                        //Terminal Inventory
                                        clsAppData.Template.inMp200_Ttl_Stock   = int.Parse(Db.Reader["Total_MP200"].ToString().Trim());
                                        clsAppData.Template.inS1E_Ttl_Stock     = int.Parse(Db.Reader["Total_S1E"].ToString().Trim());

                                   // MP200

                                        // INSTALLATION
                                        clsAppData.Template.inMp200_Ttl_comIns = int.Parse(Db.Reader["MPComIns"].ToString().Trim());
                                        clsAppData.Template.inMp200_Ttl_penIns = int.Parse(Db.Reader["MPPenIns"].ToString().Trim());
                                        clsAppData.Template.inMp200_Ttl_canIns = int.Parse(Db.Reader["MPCanIns"].ToString().Trim());

                                        // REPROGRAMMING
                                        clsAppData.Template.inMp200_Ttl_comReprog = int.Parse(Db.Reader["MPComReprog"].ToString().Trim());
                                        clsAppData.Template.inMp200_Ttl_penReprog = int.Parse(Db.Reader["MPPenReprog"].ToString().Trim());
                                        clsAppData.Template.inMp200_Ttl_canReprog = int.Parse(Db.Reader["MPCanReprog"].ToString().Trim());

                                        // SERVICING
                                        clsAppData.Template.inMp200_Ttl_comServ = int.Parse(Db.Reader["MPComServ"].ToString().Trim());
                                        clsAppData.Template.inMp200_Ttl_penServ = int.Parse(Db.Reader["MPPenServ"].ToString().Trim());
                                        clsAppData.Template.inMp200_Ttl_canServ = int.Parse(Db.Reader["MPCanServ"].ToString().Trim());

                                        // REPAIR
                                        clsAppData.Template.inMp200_Ttl_comRepair = int.Parse(Db.Reader["MPComRep"].ToString().Trim());
                                        clsAppData.Template.inMp200_Ttl_penRepair = int.Parse(Db.Reader["MPPenRep"].ToString().Trim());
                                        clsAppData.Template.inMp200_Ttl_canRepair = int.Parse(Db.Reader["MPCanRep"].ToString().Trim());

                                   // S1E Mini

                                        // INSTALLATION
                                        clsAppData.Template.inS1E_Ttl_comIns = int.Parse(Db.Reader["S1EComIns"].ToString().Trim());
                                        clsAppData.Template.inS1E_Ttl_penIns = int.Parse(Db.Reader["S1EPenIns"].ToString().Trim());
                                        clsAppData.Template.inS1E_Ttl_canIns = int.Parse(Db.Reader["S1ECanIns"].ToString().Trim());

                                        // REPROGRAMMING
                                        clsAppData.Template.inS1E_Ttl_comReprog = int.Parse(Db.Reader["S1EComReprog"].ToString().Trim());
                                        clsAppData.Template.inS1E_Ttl_penReprog = int.Parse(Db.Reader["S1EPenReprog"].ToString().Trim());
                                        clsAppData.Template.inS1E_Ttl_canReprog = int.Parse(Db.Reader["S1ECanReprog"].ToString().Trim());

                                        // SERVICING
                                        clsAppData.Template.inS1E_Ttl_comServ = int.Parse(Db.Reader["S1EComServ"].ToString().Trim());
                                        clsAppData.Template.inS1E_Ttl_penServ = int.Parse(Db.Reader["S1EPenServ"].ToString().Trim());
                                        clsAppData.Template.inS1E_Ttl_penServ = int.Parse(Db.Reader["S1ECanServ"].ToString().Trim());

                                        // REPAIR
                                        clsAppData.Template.inS1E_Ttl_comRepair = int.Parse(Db.Reader["S1EComRep"].ToString().Trim());
                                        clsAppData.Template.inS1E_Ttl_penRepair = int.Parse(Db.Reader["S1EPenRep"].ToString().Trim());
                                        clsAppData.Template.inS1E_Ttl_penRepair = int.Parse(Db.Reader["S1ECanRep"].ToString().Trim());

                                        break;
                                }

                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {

                    MySQLErrorHandlerMessage(ex, "Count Details", sStoredProcedure, StatementType, SearchBy, SearchVal, "", "", "");
                    throw ex;
                }
                finally
                {

                    if (Db.Conn != null)
                    {

                        Db.Disconnect();
                        Db.Reader.Dispose();
                    }
                }
            }

        }

        private void ViewSearchDate(DataGridView Obj, string Tablename, string SearchValue)
        {

            string sStoredProcedure = "spFuncSearchDate";
            Debug.WriteLine("--- Get Total " + Tablename);

            Obj.Rows.Clear();

            if (Db.Connect())
            {

                try {

                    using (Db.Command = new MySqlCommand(sStoredProcedure, Db.Conn)) {

                        Db.Command.CommandType = CommandType.StoredProcedure;

                        // Parameters
                        Db.Command.Parameters.Add(new MySqlParameter("@p_Tablename", Tablename));
                        Db.Command.Parameters.Add(new MySqlParameter("@p_SearchValue", SearchValue));

                        // Execute Command
                        using (Db.Reader = Db.Command.ExecuteReader()) {

                            // Read Record   
                            while (Db.Reader.Read()) {

                                Obj.Rows.Add(
                                  Db.Reader["Terminal_Model"].ToString().Trim(),
                                  Db.Reader["Status"].ToString().Trim(),
                                  Db.Reader["Total"].ToString().Trim()
                                );
                            }

                            Obj.ClearSelection();
                            Obj = null;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MySQLErrorHandlerMessage(ex, "Search Date", sStoredProcedure, Tablename, SearchValue, "", "", "", "");
                    throw ex;
                }

                finally
                {
                    if (Db.Conn != null)
                    {
                        Db.Disconnect();
                        Db.Reader.Dispose();
                    }
                }


            }

        }

        #endregion



        // MESSAGES

        private DataSet GetReportWithStoredProcedure(int ReportID, string StatementType, string SearchBy, string SearchValue, string StoreProcedureName)
        {
            DataSet rtnDs = new DataSet();

            Debug.WriteLine("--GetReportWithStoredProcedure--");
            Debug.WriteLine("ReportID=" + ReportID);
            Debug.WriteLine("StatementType=" + StatementType);
            Debug.WriteLine("SearchBy=" + SearchBy);
            Debug.WriteLine("SearchValue=" + SearchValue);
            Debug.WriteLine("StoreProcedureName=" + StoreProcedureName);
            Debug.WriteLine("--GetReportWithStoredProcedure--");
            Debug.WriteLine("--Stored Procedure(Report) --");

            string spString = "CALL " + StoreProcedureName + "(" + "\"" + StatementType + "\"" + "," + "\"" + SearchBy + "\"" + "," + "\"" + SearchValue + "\"" + ")" + ";";
            Debug.WriteLine(spString);

            Func.getRequestTime("GetReportWithStoredProcedure->Start");

            if (Db.Connect())
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(StoreProcedureName, Db.Conn);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@p_StatementType", MySqlDbType.VarChar).Value = StatementType;
                    adapter.SelectCommand.Parameters.Add("@p_SearchBy", MySqlDbType.VarChar).Value = SearchBy;
                    adapter.SelectCommand.Parameters.Add("@p_SearchValue", MySqlDbType.VarChar).Value = SearchValue;
                    adapter.SelectCommand.CommandTimeout = int.Parse(clsAppData.DataParam.sTimeOut); // Setting command timeout to 1800 second  (30mins)

                    adapter.Fill(rtnDs);
                }
                catch (MySqlException ex)
                {
                    MySQLErrorHandlerMessage(ex, "GetReportWithStoredProcedure", StoreProcedureName, StatementType, "", SearchBy, SearchValue, "", "");
                    throw ex;
                }
            }
            else
            {
                Db.Disconnect();
            }

            Func.getResponseTime("GetReportWithStoredProcedure->End");

            Db.Disconnect();

            return rtnDs;
        }

        private void MySQLErrorHandlerMessage(MySqlException ex, string FunctionName, string StoredProcedure, string StatementType, string TableName, string SearchBy, string SearchValue, string SQL, string ErrorMessage)
        {
            string sTemp = string.Empty;
            string sLog = string.Empty;
            string sTempErrorMessage = string.Empty;

            // For MessageBox
            sTemp = "**Function Name: " + FunctionName + Environment.NewLine +
                    "**Stored Procedure: " + StoredProcedure + Environment.NewLine +
                    "**Parameter: \n" +
                    "  -Statement Type: " + "   " + StatementType + Environment.NewLine +
                    "  -Table Name/Type: " + "   " + TableName + Environment.NewLine +
                    "  -Search By: " + "   " + SearchBy + Environment.NewLine +
                    "  -Search Value: " + "   " + SearchValue + Environment.NewLine + Environment.NewLine +
                    "**Query: \n" +
                    "  -SQL: " + "   " + SQL + Environment.NewLine + Environment.NewLine;

            if (ex != null)
                sTempErrorMessage = "Error Description: " + Environment.NewLine + "   " + ex.Message;
            else
                sTempErrorMessage = "Error Description: " + Environment.NewLine + "   " + ErrorMessage;

            sTemp = sTemp + sTempErrorMessage;

            // For Dump
            sLog = "Error: " + " | " +
                    "Function Name: " + FunctionName + " | " +
                    "Stored Procedure: " + StoredProcedure + " | " +
                    "Statement Type: " + StatementType + " | " +
                    "Table Name / Type: " + TableName + "|" +
                    "Search By: " + SearchBy + " | " +
                    "Search Value: " + SearchValue + " | " +
                    "SQL: " + SQL + " | ";

            if (ex != null)
                sTempErrorMessage = "Error Description: " + ex.Message;
            else
                sTempErrorMessage = "Error Description: " + ErrorMessage;

            sLog = sLog + sTempErrorMessage;

            // Display Error Message
            if (ex != null)
            {
                switch (ex.Number)
                {
                    case 0:

                        MessageBox.Show("Connection to server failed.", "Contact Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    case 1045:

                        MessageBox.Show("Invalid username/password", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    default:

                        MessageBox.Show(sTemp, "Error Handler - " + FunctionName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                }
            }
            else
            {

                MessageBox.Show(sTemp, "Error Handler - " + FunctionName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

    }
}
