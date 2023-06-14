using ActivityReportSystem.AppActivity.Model;
using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityReportSystem.AppActivity.Controller
{
    class clsAppController
    {
        MySQLStoredProcedure Sp = new MySQLStoredProcedure();

        public DataTable ExecuteQuery(string StatementType, string StatementBy, string SearchValue, string MaintenanceType, string Sql, Action Action)
        {

         #region Debug Details

            Debug.WriteLine(clsFunctions.LineSeperator);
            Debug.WriteLine("EXECUTE QUERY");
            Debug.WriteLine(clsFunctions.LineSeperator);
            Debug.WriteLine("Statement Type: " + StatementType);
            Debug.WriteLine("Statement By: "   + StatementBy);

            if (!string.IsNullOrEmpty(SearchValue))
                Debug.WriteLine("SearchValue: " + SearchValue);

            if (!string.IsNullOrEmpty(MaintenanceType))
                Debug.WriteLine("Maintenance Type: " + MaintenanceType);

            if (!string.IsNullOrEmpty(Sql))
                Debug.WriteLine("SQL: " + Sql);

            Debug.WriteLine(clsFunctions.LineSeperator);

         #endregion

            DataTable resultTable = new DataTable();

            switch (Action)
            {
                case Action.View:
                    resultTable = Sp.CollectionDetails(StatementType, StatementBy, SearchValue);
                    break;

                case Action.Update:
                    Sp.CollectionUpdate(StatementType, StatementBy, SearchValue, Sql);
                    break;

                case Action.Insert:
                    Sp.CollectionInsert(StatementType, StatementBy, SearchValue, Sql);
                    break;

                case Action.Delete:
                    Sp.CollectionDelete(StatementType, StatementBy, SearchValue);
                    break;

            }

            return resultTable;
        }

        public enum Action
        {
            View,
            Update,
            Insert,
            Delete
        }

    }


    public class MySQLStoredProcedure
    {
        private MySqlConnection Conn;
        private MySqlCommand Cmd;
        private MySqlDataReader Reader;

        public DataTable CollectionDetails(string StatementType, string StatementBy, string SearchValue)
        {
            DataTable dataTable = new DataTable();

            using (Conn = new MySqlConnection(sAppData.DataParam.ConnString))
            {
                Conn.Open();

                Debug.WriteLine(string.Concat("CALL spCollectionDetails ", "(\"", StatementType, "\"", ",\"", StatementBy, "\"", ",\"", SearchValue, "\"", ")"));
                Debug.WriteLine(clsFunctions.LineSeperator + "\n");

                using (Cmd = new MySqlCommand("spCollectionDetails", Conn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                    Cmd.Parameters.AddWithValue("@SearchBy", StatementBy);
                    Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);

                    try
                    {
                        using (Reader = Cmd.ExecuteReader())
                        {
                            dataTable.Load(Reader);
                        }

                        return dataTable;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error Executing Stored Procedure: " + ex.Message);
                    }
                }
            }

            return dataTable; // Return an empty DataTable in case of an error
        }

        public void CollectionUpdate(string StatementType, string StatementBy, string SearchValue, string Sql)
        {
            using (Conn = new MySqlConnection(sAppData.DataParam.ConnString))
            {
                Conn.Open();

                Debug.WriteLine(string.Concat("CALL spCollectionUpdate ", "(\"", StatementType, "\"", ",\"", StatementBy, "\"", ",\"", SearchValue, "\"", ")"));
                Debug.WriteLine(clsFunctions.LineSeperator + "\n");

                using (Cmd = new MySqlCommand("spCollectionUpdate", Conn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                    Cmd.Parameters.AddWithValue("@SearchBy", StatementBy);
                    Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);
                    Cmd.Parameters.AddWithValue("@pSql", Sql);

                    try
                    {
                        Cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error Executing Stored Procedure: " + ex.Message);
                    }

                }
            }
        }

        public void CollectionInsert(string StatementType, string StatementBy, string SearchValue, string Sql)
        {
            using (Conn = new MySqlConnection(sAppData.DataParam.ConnString))
            {

                Conn.Open();

                Debug.WriteLine(string.Concat("CALL spCollectionInsert ", "(\"", StatementType, "\"", ",\"", StatementBy, "\"", ",\"", SearchValue, "\"", ")"));
                Debug.WriteLine(clsFunctions.LineSeperator + "\n");

                using (Cmd = new MySqlCommand("spCollectionInsert", Conn))
                {

                    Cmd.CommandType = CommandType.StoredProcedure;

                    Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                    Cmd.Parameters.AddWithValue("@StatementBy", StatementBy);
                    Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);
                    Cmd.Parameters.AddWithValue("@pSQL", Sql);

                    Cmd.Parameters.Add("@outLastInsertID", MySqlDbType.VarChar, 255).Direction = ParameterDirection.Output;
                    Cmd.Parameters.Add("@outErrorMessage", MySqlDbType.VarChar, 255).Direction = ParameterDirection.Output;

                    try
                    {

                        Cmd.ExecuteNonQuery();

                        // Retrieve the value of the output parameter
                        sAppData.DataParam.outLastInserted = Cmd.Parameters["@outLastInsertID"].Value.ToString().Trim();
                        sAppData.DataParam.outMessage = Cmd.Parameters["@outErrorMessage"].Value.ToString().Trim();

                    }
                    catch (Exception ex)
                    {

                        Debug.WriteLine("Error Executing Stored Procedure: " + ex.Message);
                    }
                }

                Debug.WriteLine("Last Inserted ID : " + sAppData.DataParam.outLastInserted);
            }
        }

        public void CollectionDelete(string StatementType, string StatementBy, string SearchValue)
        {
            using (Conn = new MySqlConnection(sAppData.DataParam.ConnString))
            {
                Conn.Open();

                Debug.WriteLine(string.Concat("CALL spCollectionUpdate ", "(\"", StatementType, "\"", ",\"", StatementBy, "\"", ",\"", SearchValue, "\"", ")"));
                Debug.WriteLine(clsFunctions.LineSeperator + "\n");

                using (Cmd = new MySqlCommand("spCollectionUpdate", Conn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                    Cmd.Parameters.AddWithValue("@SearchBy", StatementBy);
                    Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);

                    try
                    {
                        Cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error Executing Stored Procedure: " + ex.Message);
                    }

                }
            }

        }

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

            string spString = "CALL " + StoreProcedureName + "('" + StatementType + "','" + SearchBy + "','" + SearchValue + "');";
            Debug.WriteLine(spString);

            clsFunctions.getRequestTime("GetReportWithStoredProcedure->Start");

            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(StoreProcedureName, Conn))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@p_StatementType", MySqlDbType.VarChar).Value = StatementType;
                    adapter.SelectCommand.Parameters.Add("@p_SearchBy", MySqlDbType.VarChar).Value = SearchBy;
                    adapter.SelectCommand.Parameters.Add("@p_SearchValue", MySqlDbType.VarChar).Value = SearchValue;
                    adapter.SelectCommand.CommandTimeout = int.Parse(sAppData.DataParam.sTimeOut); // Setting command timeout to 1800 seconds (30 minutes)

                    adapter.Fill(rtnDs);
                }
            }
            catch (MySqlException ex)
            {
                MySQLErrorHandlerMessage(ex, "GetReportWithStoredProcedure", StoreProcedureName, StatementType, "", SearchBy, SearchValue, "", "");
                throw;
            }

            clsFunctions.getResponseTime("GetReportWithStoredProcedure->End");

            return rtnDs;
        }

        private void MySQLErrorHandlerMessage(MySqlException ex, string FunctionName, string StoredProcedure, string StatementType, string TableName, string SearchBy, string SearchValue, string SQL, string ErrorMessage)
        {
            string errorDescription = ex != null ? ex.Message : ErrorMessage;

            string message = $"**Function Name: {FunctionName}\n" +
                             $"**Stored Procedure: {StoredProcedure}\n" +
                             $"**Parameter:\n" +
                             $"  - Statement Type: {StatementType}\n" +
                             $"  - Table Name/Type: {TableName}\n" +
                             $"  - Search By: {SearchBy}\n" +
                             $"  - Search Value: {SearchValue}\n\n" +
                             $"**Query:\n" +
                             $"  - SQL: {SQL}\n\n" +
                             $"Error Description:\n{errorDescription}";

            string log = $"Error: | " +
                         $"Function Name: {FunctionName} | " +
                         $"Stored Procedure: {StoredProcedure} | " +
                         $"Statement Type: {StatementType} | " +
                         $"Table Name / Type: {TableName} |" +
                         $"Search By: {SearchBy} | " +
                         $"Search Value: {SearchValue} | " +
                         $"SQL: {SQL} | " +
                         $"Error Description: {errorDescription}";

            if (ex != null)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to the server failed.", "Contact Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password.", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                    default:
                        MessageBox.Show(message, $"Error Handler - {FunctionName}", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        break;
                }
            }
            else
            {
                MessageBox.Show(message, $"Error Handler - {FunctionName}", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /* Old Source
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
        }*/


    }

}
