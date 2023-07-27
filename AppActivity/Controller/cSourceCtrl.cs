using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using AppAction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityReportSystem.AppActivity.Model
{
    class cSourceCtrl
    {
        cSpModel Sp = new cSpModel();

        // Return Results
        public string Completed { get; set; }
        public string Pending { get; set; }
        public string Cancelled { get; set; }
        public string Waiting { get; set; }

        public int TotalStocks { get; set; }
        public int TotalDeployed { get; set; }
        public string SearchValue { get; set; }

        // Paths
        private string csvPath { get; set; }
        private string insPath { get; set; }
        private string reprogPath { get; set; }
        private string servPath { get; set; }
        private string repPath { get; set; }
        private string inventPath { get; set; }


        public void GetDetails(DataGridView obj)
        {
            DataTable Result = new DataTable();

            Sp.StatementType = "View";
            Sp.SearchBy = "Source" + cFunctions.Pipe + "Info";
            Sp.SearchValue = SearchValue;

            Result = Sp.ExecuteQuery(Perform.View);

            switch (SearchValue)
            {
                case string s when s.Contains("tblinstallation"):
                    Completed = AppData.Template.iTotal_comIns.ToString("n0");
                    Pending   = AppData.Template.iTotal_penIns.ToString("n0");
                    Cancelled = AppData.Template.iTotal_canIns.ToString("n0");
                    Waiting   = AppData.Template.iTotal_waitIns.ToString("n0");
                    break;

                case string s when s.Contains("tblreprogramming"):
                    Completed = AppData.Template.iTotal_comReprog.ToString("n0");
                    Pending   = AppData.Template.iTotal_penReprog.ToString("n0");
                    Cancelled = AppData.Template.iTotal_canReprog.ToString("n0");
                    Waiting   = AppData.Template.iTotal_waitReprog.ToString("n0");
                    break;

                case string s when s.Contains("tblservicing"):
                    Completed = AppData.Template.iTotal_comServ.ToString("n0");
                    Pending   = AppData.Template.iTotal_penServ.ToString("n0");
                    Cancelled = AppData.Template.iTotal_canServ.ToString("n0");
                    Waiting   = AppData.Template.iTotal_waitServ.ToString("n0");
                    break;

                case string s when s.Contains("tblrepair"):
                    Completed = AppData.Template.iTotal_comRep.ToString("n0");
                    Pending   = AppData.Template.iTotal_penRep.ToString("n0");
                    Cancelled = AppData.Template.iTotal_canRep.ToString("n0");
                    Waiting   = AppData.Template.iTotal_waitRep.ToString("n0");
                    break;

                default:
                    Debug.WriteLine("Result: No Value Found!\n");
                    break;
            }


            if (Result.Rows.Count > 0)
            {
                obj.Rows.Clear();

                string colName = SearchValue.Contains("tblinstallation") ||
                                 SearchValue.Contains("tblreprogramming") ? "ID" : "Case_Referral";

                foreach (DataRow row in Result.Rows)
                {
                    obj.Rows.Add
                    (
                        row["ID"].ToString().Trim(),
                        row[colName].ToString().Trim(),
                        row["Terminal_Model"].ToString().Trim(),
                        row["Merchant_ID"].ToString().Trim(),
                        row["Terminal_ID"].ToString().Trim(),
                        row["Serial_No"].ToString().Trim(),
                        row["Merchant_Name"].ToString().Trim(),
                        row["Status"].ToString().Trim(),
                        row["Status_Remarks"].ToString().Trim(),
                        row["Dependency_for_Pending"].ToString().Trim(),
                        row["Date_Received"].ToString().Trim(),
                        row["Terminal_Age"].ToString().Trim()
                    );
                }

                obj.ClearSelection();
            }
            else
            {
                Debug.WriteLine("Result : No Record Found!\n");
            }
        }

        public void GetUpdates()
        {
            // Update Dashboard
            Sp.StatementType = "Update";
            Sp.SearchBy = "Dashboard";
            Sp.ExecuteQuery(Perform.Update);
        }

        public void GetValues()
        {
            DataTable Result = new DataTable();

            Sp.StatementType  = "View";
            Sp.SearchBy       = "Terminal" + cFunctions.Pipe + "Status Summary";
            Sp.SearchValue    = SearchValue;

            Result = Sp.ExecuteQuery(Perform.View);

            if (Result.Rows.Count > 0 && Result.Rows.Count >= 4)
            {
                // COMPLETED SUMMARY
                AppData.Template.iTotal_comIns     = int.Parse(Result.Rows[0]["Completed"].ToString().Trim());
                AppData.Template.iTotal_comReprog  = int.Parse(Result.Rows[1]["Completed"].ToString().Trim());
                AppData.Template.iTotal_comServ    = int.Parse(Result.Rows[2]["Completed"].ToString().Trim());
                AppData.Template.iTotal_comRep     = int.Parse(Result.Rows[3]["Completed"].ToString().Trim());

                // PENDING SUMMARY
                AppData.Template.iTotal_penIns     = int.Parse(Result.Rows[0]["Pending"].ToString().Trim());
                AppData.Template.iTotal_penReprog  = int.Parse(Result.Rows[1]["Pending"].ToString().Trim());
                AppData.Template.iTotal_penServ    = int.Parse(Result.Rows[2]["Pending"].ToString().Trim());
                AppData.Template.iTotal_penRep     = int.Parse(Result.Rows[3]["Pending"].ToString().Trim());

                // CANCELLED SUMMARY
                AppData.Template.iTotal_canIns     = int.Parse(Result.Rows[0]["Cancelled"].ToString().Trim());
                AppData.Template.iTotal_canReprog  = int.Parse(Result.Rows[1]["Cancelled"].ToString().Trim());
                AppData.Template.iTotal_canServ    = int.Parse(Result.Rows[2]["Cancelled"].ToString().Trim());
                AppData.Template.iTotal_canRep     = int.Parse(Result.Rows[3]["Cancelled"].ToString().Trim());

                // WAITING SUMMARY
                AppData.Template.iTotal_waitIns    = int.Parse(Result.Rows[0]["Waiting"].ToString().Trim());
                AppData.Template.iTotal_waitReprog = int.Parse(Result.Rows[1]["Waiting"].ToString().Trim());
                AppData.Template.iTotal_waitServ   = int.Parse(Result.Rows[2]["Waiting"].ToString().Trim());
                AppData.Template.iTotal_waitRep    = int.Parse(Result.Rows[3]["Waiting"].ToString().Trim());

                // TOTAL SUMMARY
                AppData.Template.iTotal_Com = AppData.Template.iTotal_comIns + AppData.Template.iTotal_comReprog + AppData.Template.iTotal_comServ + AppData.Template.iTotal_comRep;
                AppData.Template.iTotal_Pen = AppData.Template.iTotal_penIns + AppData.Template.iTotal_penReprog + AppData.Template.iTotal_penServ + AppData.Template.iTotal_penRep;
                AppData.Template.iTotal_Can = AppData.Template.iTotal_canIns + AppData.Template.iTotal_canReprog + AppData.Template.iTotal_canServ + AppData.Template.iTotal_canRep;
                AppData.Template.iTotal_Wait = AppData.Template.iTotal_waitIns + AppData.Template.iTotal_waitReprog + AppData.Template.iTotal_waitServ + AppData.Template.iTotal_waitRep;

                // Data Volume
                AppData.Template.InstallSize = int.Parse(Result.Rows[0]["Total"].ToString().Trim());
                AppData.Template.ReprogSize = int.Parse(Result.Rows[1]["Total"].ToString().Trim());
                AppData.Template.ServSize = int.Parse(Result.Rows[2]["Total"].ToString().Trim());
                AppData.Template.RepairSize = int.Parse(Result.Rows[3]["Total"].ToString().Trim());

            }
            else
            {
                Debug.WriteLine("Get Values : No Record Found!\n");
            }

            TotalDeployed = AppData.Template.iTotal_comIns;

            if (SearchValue == string.Empty)
            {
                TotalStocks = 0;
            }
            else
            {
                TotalStocks = Math.Abs(AppData.Template.iTotal_comIns - AppData.Template.iTotal_Invent);
            }



            if (AppData.Template.InstallSize > 0)
            {
                AppData.Template.PInstall = cFunctions.GetPercent(AppData.Template.iTotal_comIns, AppData.Template.InstallSize);
            }

            if (AppData.Template.ReprogSize > 0)
            {
                AppData.Template.PReprog = cFunctions.GetPercent(AppData.Template.iTotal_comReprog, AppData.Template.ReprogSize);
            }

            if (AppData.Template.ServSize > 0)
            {
                AppData.Template.PServ = cFunctions.GetPercent(AppData.Template.iTotal_comServ, AppData.Template.ServSize);
            }

            if (AppData.Template.RepairSize > 0)
            {
                AppData.Template.PRepair = cFunctions.GetPercent(AppData.Template.iTotal_comRep, AppData.Template.RepairSize);
            }

        }

        public void GetInventory()
        {
            DataTable Result = new DataTable();

            Sp.StatementType = "View";
            Sp.SearchBy      = "Source" + cFunctions.Pipe + "Inventory";
            Sp.SearchValue   = SearchValue;

            Result = Sp.ExecuteQuery(Perform.View);

            if (Result.Rows.Count > 0)
            {
                // COMPLETED SUMMARY
                AppData.Template.iTotal_Invent = int.Parse(Result.Rows[0]["TotalInvent"].ToString().Trim());
            }
            else
            {
                Debug.WriteLine("Get Inventory : No Record Found!");
            }
        }

        public void SaveDetails(DataGridView DgView)
        {
            var queryBuilder = new StringBuilder();
            var queryValues = new StringBuilder();
            var cultureInfo = new CultureInfo("en-US");

            string TempValue = string.Empty;
            int rowCount = DgView.Rows.Count;

            // Batch Size Value for Insertion
            int batchSize = 150;

            if (rowCount > 0)
            {
                if (MessageBox.Show("Do you want to Delete Existing " + SearchValue + " Database?" + "\nWarning this will permanently delete the data", "Database",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Set Parameters
                    Sp.StatementType = "Delete";
                    Sp.SearchBy = SearchValue;

                    // Execute Query
                    Sp.ExecuteQuery(Perform.Remove); // Delete Existing Data
                }

                for (int rowIndex = 0; rowIndex < rowCount; rowIndex++) // Total Index
                {
                    queryBuilder.Append('(');

                    for (int columnIndex = 0; columnIndex < DgView.ColumnCount; columnIndex++) // Total Columns
                    {
                        var cellValue = DgView.Rows[rowIndex].Cells[columnIndex].Value?.ToString().Trim() ?? "";

                        // Remove Special Characters
                        cellValue = string.IsNullOrWhiteSpace(cellValue) ? "-" : cFunctions.Convert.FormatCharAndDate(cellValue);

                        queryBuilder.Append($"'{ cellValue }',");
                    }

                    queryBuilder.Length = queryBuilder.Length - 1; // Remove Last Comma,
                    queryBuilder.Append(')'); // Wrap the Value

                    // Preserve Rows Value.
                    TempValue = queryBuilder.ToString();

                    // Clear to Create New.
                    queryBuilder.Clear();

                    queryValues.Append(queryValues.Length > 0 ? $", {Environment.NewLine}{TempValue}" : TempValue);

                    if ((rowIndex + 1) % batchSize == 0 || rowIndex == rowCount - 1)
                    {
                        // Set Parameters
                        Sp.StatementType = "Insert";
                        Sp.SearchBy = SearchValue;
                        Sp.Sql = queryValues.ToString();

                        // Execute Query
                        Sp.ExecuteQuery(Perform.Add);

                        queryValues.Clear(); // Clear for Next Batch of Value
                    }
                }

                MessageBox.Show(SearchValue + " Import Successful", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DgView = null;
        }

        public void ImportDetails(string SourceName)
        {
            switch (SourceName)
            {
                case AppData.Installation:
                    csvPath = insPath;
                    break;

                case AppData.Reprogramming:
                    csvPath = reprogPath;
                    break;

                case AppData.Servicing:
                    csvPath = servPath;
                    break;

                case AppData.Repair:
                    csvPath = repPath;
                    break;

                case AppData.Inventory:
                    csvPath = inventPath;
                    break;
            }

            if (csvPath != null)
            {
                if (MessageBox.Show("Do you want to Delete Existing " + SourceName + " Database?" +
                    "\nWarning this will permanently delete the data", "Database",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Set Parameters for removal
                    Sp.StatementType = "Delete";
                    Sp.SearchBy = SourceName;
                    Sp.ExecuteQuery(Perform.Remove); // Truncate Existing Data

                }

                // Set Parameters for import
                Sp.StatementType = "Import";
                Sp.SearchBy = SourceName;
                Sp.Sql = csvPath;
                Sp.ExecuteQuery(Perform.Import); // Save Files
            }
        }

        public void ImportProcess(TextBox TxbPath)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Excel Files|*.xls;*.xlsx";
                    ofd.Title = "Select file to import " + SearchValue;

                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    TxbPath.Text = ofd.FileName;

                    if (!TxbPath.Text.Contains(SearchValue))
                    {
                        MessageBox.Show("File Not a valid " + SearchValue + " File", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxbPath.Clear();
                        return;
                    }

                    Cursor.Current = Cursors.WaitCursor;

                    try
                    {
                        string excelFilePath = ofd.FileName;
                        string csvFolderPath = AppData.FilePath.Csv;
                        string csvFileName = Path.GetFileNameWithoutExtension(excelFilePath) + "_" + DateTime.Now.ToString("MMddyy") + ".csv";

                        //clsFunctions.SetDataBind(Obj, Tbx);
                        //clsFunctions.SetGridAlterBackColor(Obj);
                        //clsFunctions.GetGridHeaderList(Obj);

                        switch (SearchValue)
                        {
                            case AppData.Installation:
                                insPath = cFunctions.Convert.ExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));
                                Debug.WriteLine(SearchValue + " CSV File Location : " + insPath);

                                break;

                            case AppData.Reprogramming:
                                reprogPath = cFunctions.Convert.ExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));
                                Debug.WriteLine(SearchValue + " CSV File Location : " + reprogPath);
                                break;

                            case AppData.Servicing:
                                servPath = cFunctions.Convert.ExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));
                                Debug.WriteLine(SearchValue + " CSV File Location : " + servPath);
                                break;

                            case AppData.Repair:
                                repPath = cFunctions.Convert.ExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));
                                Debug.WriteLine(SearchValue + " CSV File Location : " + repPath);
                                break;

                            case AppData.Inventory:
                                inventPath = cFunctions.Convert.ExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));
                                Debug.WriteLine(SearchValue + " CSV File Location : " + inventPath);
                                break;
                        }

                        //tpcActivity.SelectedTab = Tbp;

                        MessageBox.Show("File Succefully Uploaded", "File Upload Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Activity Report System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Cursor.Current = Cursors.Default;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Open failed.");
            }
        }

    }
}
