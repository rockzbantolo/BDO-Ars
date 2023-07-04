using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using MySqlConnector;
using System.Data;
using System.Diagnostics;
using AppAction;
using System.Windows.Forms;
using System;

namespace ActivityReportSystem.AppActivity.Model
{
    class cSpModel
    {
        private MySqlConnection Conn;
        private MySqlCommand Cmd;
        private MySqlDataReader Reader;

        public string StatementType { get; set; }
        public string SearchBy { get; set; }
        public string SearchValue { get; set; } = "";
        public string Sql { get; set; } = "";


        public DataTable ExecuteQuery(Perform Action)
        {
            #region Debug Details

            Debug.WriteLine(cFunctions.Format.LineSeperator);
            Debug.WriteLine("EXECUTE QUERY");
            Debug.WriteLine(cFunctions.Format.LineSeperator);
            Debug.WriteLine("Statement Type: " + StatementType);
            Debug.WriteLine("Statement By: "   + SearchBy);

            if (!string.IsNullOrEmpty(SearchValue))
                Debug.WriteLine("SearchValue: " + SearchValue);

            if (!string.IsNullOrEmpty(Sql))
                Debug.WriteLine("SQL: \n" + Sql);

            Debug.WriteLine(cFunctions.Format.LineSeperator);

            #endregion

            switch (Action)
            {
                case Perform.View:
                    return CollectionDetails();

                case Perform.Update:
                    CollectionUpdate();
                    break;

                case Perform.Add:
                    CollectionInsert();
                    break;

                case Perform.Import:
                    CollectionImport();
                    break;

                case Perform.Remove:
                    CollectionDelete();
                    break;
            }

            return null;
        }

        private DataTable CollectionDetails()
        {
            DataTable dataTable = new DataTable();

            using (Conn = new MySqlConnection(sAppData.ConnectionString))

            using (Cmd = new MySqlCommand("spCollectionDetails", Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters
                Cmd.Parameters.AddWithValue("@p_StatementType", StatementType);
                Cmd.Parameters.AddWithValue("@p_SearchBy", SearchBy);
                Cmd.Parameters.AddWithValue("@p_SearchValue", SearchValue);

                try
                {
                    Conn.Open();
                    using (Reader = Cmd.ExecuteReader())
                    {
                        dataTable.Load(Reader);
                        Debug.WriteLine($"SUCCESS - CALL spCollectionDetails (\"{StatementType}\", \"{SearchBy}\", \"{SearchValue}\")");
                        Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"FAILED - CALL spCollectionDetails (\"{StatementType}\", \"{SearchBy}\", \"{SearchValue}\")");
                    Debug.WriteLine("Error Executing Details Procedure: " + ex.Message);
                    Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");
                }
            }

            return dataTable;
        }

        private void CollectionUpdate()
        {
            using (Conn = new MySqlConnection(sAppData.ConnectionString))

            using (Cmd = new MySqlCommand("spCollectionUpdate", Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                Cmd.Parameters.AddWithValue("@SearchBy", SearchBy);
                Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);
                Cmd.Parameters.AddWithValue("@pSql", Sql);

                try
                {
                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                    Debug.WriteLine($"SUCCESS - CALL spCollectionUpdate (\"{StatementType}\", \"{SearchBy}\", \"{SearchValue}\")");
                    Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"FAILED - CALL spCollectionUpdate (\"{StatementType}\", \"{SearchBy}\", \"{SearchValue}\")");
                    Debug.WriteLine("Error Executing Update Procedure: " + ex.Message);
                    Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");

                }
            }
        }

        private void CollectionInsert()
        {
            using (Conn = new MySqlConnection(sAppData.ConnectionString))

            using (Cmd = new MySqlCommand("spCollectionInsert", Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                Cmd.Parameters.AddWithValue("@SearchBy", SearchBy);
                Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);
                Cmd.Parameters.AddWithValue("@pSQL", Sql);

                var outLastInsertIDParam = Cmd.Parameters.Add("@outLastInsertID", MySqlDbType.VarChar, 255);
                outLastInsertIDParam.Direction = ParameterDirection.Output;

                var outErrorMessageParam = Cmd.Parameters.Add("@outErrorMessage", MySqlDbType.VarChar, 255);
                outErrorMessageParam.Direction = ParameterDirection.Output;

                try
                {
                    Conn.Open();
                    Cmd.ExecuteNonQuery();

                    Debug.WriteLine($"SUCCESS - CALL spCollectionInsert (\"{StatementType}\", \"{SearchBy}\", \"{Sql}\")");
                    Debug.WriteLine("Last Inserted ID : " + sAppData.Database.outLastInserted + "\n");
                    Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");

                    // Retrieve the value of the output parameter
                    sAppData.Database.outLastInserted = Convert.ToInt32(outLastInsertIDParam.Value);
                    sAppData.Database.outMessage      = outErrorMessageParam.Value.ToString().Trim();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"FAILED - CALL spCollectionInsert (\"{StatementType}\", \"{SearchBy}\", \"{Sql}\")");
                    Debug.WriteLine("Error Executing Insert Procedure: " + ex.Message);
                    Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");
                }
            }
        }

        private void CollectionDelete()
        {
            using (Conn = new MySqlConnection(sAppData.ConnectionString))

            using (Cmd = new MySqlCommand("spCollectionDelete", Conn))
            {
                Cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                Cmd.Parameters.AddWithValue("@SearchBy", SearchBy);
                Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);

                try
                {
                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                    Debug.WriteLine($"SUCCESS - CALL spCollectionDelete (\"{StatementType}\", \"{SearchBy}\", \"{SearchValue}\")");
                    Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"FAILED - CALL spCollectionDelete (\"{StatementType}\", \"{SearchBy}\", \"{SearchValue}\")");
                    Debug.WriteLine("Error Executing Delete Procedure: " + ex.Message);
                    Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");
                }
            }
        }

        private void CollectionImport()
        {
            string tableName;
            string[] columnNames;

            switch (SearchBy)
            {
                case sAppData.Installation:
                    tableName = "tblinstallation";
                    columnNames = new string[]
                    { "Merchant_ID", "Terminal_ID", "Merchant_Name", "Address", "Municipality",
                        "Province", "Contact_Person", "Contact_No", "Business_Unit", "Request_Method",
                        "Requested_By", "Action_Comments", "Terminal_Status", "Airway_Bill",
                        "Terminal_Model", "Serial_No", "OS_Version", "Date_Received", "Date_Profiled",
                        "Date_Terminal_Prep", "Date_1st_Call_Out", "Date_2nd_Call_Out",
                        "Date_3rd_Call_Out", "Date_Released", "Date_Received_Merchant", "Status",
                        "Status_Remarks", "Dependency_for_Pending", "Aging_of_Pending",
                        "Aging_Bracket", "All_Card_Test", "Reason", "SLA", "Reason_Failed_SLA" };
                    break;

                case sAppData.Reprogramming:
                    tableName = "tblreprogramming";
                    columnNames = new string[]
                    { "Requested_By", "Merchant_Name", "Terminal_ID", "Merchant_ID", "Serial_No",
                        "Merchant_Rep", "Merchant_Contact_Number", "Merchant_Address",
                        "Reprogramming_Request", "New_TID", "New_MID", "Date_Received",
                        "Date_1st_Attempt", "Date_2nd_Attempt", "Date_3rd_Attempt",
                        "Date_4th_Attempt", "Date_5th_Attempt", "Date_Attended", "SMS_Advisory",
                        "Status", "Status_Remarks", "Dependency_for_Pending", "Aging_of_Pending",
                        "Aging_Bracket", "Under_Warranty", "CITAS_Remarks", "Call_Out_SLA",
                        "Reason", "Terminal_Model" };
                    break;

                case sAppData.Servicing:
                    tableName = "tblservicing";
                    columnNames = new string[]
                    { "Case_Referral", "Merchant_Name", "Terminal_ID", "Merchant_ID", "Merchant_Rep",
                        "Merchants_Contact_No", "Merchants_Address", "Reported_Problem",
                        "Terminal_Problem", "Date_Received", "Date_1st_Attempt", "Date_2nd_Attempt",
                        "Date_3rd_Attempt", "Date_4th_Attempt", "Date_5th_Attempt", "Case_Resolution",
                        "Status", "Status_Remarks", "Dependency_for_Pending", "Date_Attended",
                        "Serial_No", "Merchant_Terminal_Send", "Date_Ship_of_Unit",
                        "Date_Receipt_of_Defective_Unit", "Diagnostic_Findings", "Date_Billing_Quotation",
                        "Date_Proof_of_payment", "Date_Released", "Under_Warranty", "Status_of_Repair",
                        "Repair_Remarks", "Aging_of_Pending", "Aging_Bracket", "SLA", "Reason_Failed_SLA",
                        "Terminal_Model" };
                    break;

                case sAppData.Repair:
                    tableName = "tblrepair";
                    columnNames = new string[]
                    { "Case_Referral", "Serial_No", "Merchant_ID", "Terminal_ID", "Merchant_Name",
                        "Merchant_Unit_Ship", "Aging_Pending_Shipment", "Email_Address", "Date_Received",
                        "For_Diagnosis_Repair", "Diagnosis", "Date_Quotation_Created",
                        "Date_Quotation_Sent", "Aging_Receipt_of_Terminal", "Aging_of_Billing_Quotation",
                        "Billing_Quotation_Status", "Date_Payment_Received", "On_Going_Repair",
                        "For_Preparation", "Date_Released", "Aging_of_Repair", "Status_Remarks",
                        "Status", "Dependency_for_Pending", "Remarks", "Airway_Bill_No",
                        "1st_Callback", "2nd_Callback", "3rd_Callback", "Aging_Bracket", "Terminal_Model"};
                    break;

                case sAppData.Inventory:
                    tableName = "tblinventory";
                    columnNames = new string[]
                    { "Serial_No", "Date_Delivered_Received", "Date_Wc_Expire", "Warranty_Claim",
                        "Asset", "Part_Num", "Terminal_Model", "Box_Num",
                        "Status", "Date_Released_To_Repair", "Date_Received_From_Repair",
                        "Remarks", "Location", "Imported_To_MIS",
                        "Released_Date_To", "Received_Date_From", "Aging" };
                    break;

                default:
                    Debug.WriteLine("Invalid " + SearchBy + " import type.");
                    return;

            }

            try
            {
                using (Conn = new MySqlConnection(sAppData.ConnectionString))
                {
                    Conn.Open();

                    var loader = new MySqlBulkLoader(Conn)
                    {
                        TableName = tableName,
                        FieldTerminator = ",",
                        LineTerminator = "\n",
                        FileName = Sql,
                        Local = true,
                        NumberOfLinesToSkip = 1,        // Ignore 1 line (header)
                        FieldQuotationCharacter = '\0', // Disable field quotation
                        FieldQuotationOptional = false  // Make field quotation mandatory
                    };

                    loader.Columns.AddRange(columnNames);

                    Debug.WriteLine($"- Loaded {loader.Load()} rows into {tableName} table.");
                    Debug.WriteLine("- Data imported successfully.");
                    Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error importing data: " + ex.Message);
            }
        }

        public DataSet GetReportWithSp(string ReportHeader, string SpName)
        {
            DataSet rtnDs = new DataSet();

            Debug.WriteLine("--Get Report--");
            Debug.WriteLine("Report Header: " + ReportHeader);
            Debug.WriteLine("StatementType: " + StatementType);
            Debug.WriteLine("SearchBy: " + SearchBy);
            Debug.WriteLine("SearchValue: " + SearchValue);
            Debug.WriteLine("StoreProcedureName: " + SpName);
 
            string spString = "CALL " + SpName + "('" + StatementType + "','" + SearchBy + "','" + SearchValue + "');";
            Debug.WriteLine(spString);

            cFunctions.getRequestTime("GetReportWithStoredProcedure->Start");

            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(SpName, Conn))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@p_StatementType", MySqlDbType.VarChar).Value = StatementType;
                    adapter.SelectCommand.Parameters.Add("@p_SearchBy",      MySqlDbType.VarChar).Value = SearchBy;
                    adapter.SelectCommand.Parameters.Add("@p_SearchValue",   MySqlDbType.VarChar).Value = SearchValue;

                    adapter.SelectCommand.CommandTimeout = int.Parse(sAppData.Database.sTimeOut); // Setting command timeout to 1800 seconds (30 minutes)

                    adapter.Fill(rtnDs);
                }
            }
            catch (MySqlException ex)
            {
                MySQLErrorHandlerMessage(ex, "Get Sp Report", SpName, StatementType, "", SearchBy, SearchValue, "", "");
                throw;
            }

            cFunctions.getResponseTime("GetReportWithStoredProcedure->End");

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


    }

}
