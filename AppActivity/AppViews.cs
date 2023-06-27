using ActivityReportSystem.AppActivity.Controller;
using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppAction;

namespace ActivityReportSystem.AppActivity.View
{
    class cAppViews
    {

        cSpController Ctrl = new cSpController();
        cFunctions cFunc = new cFunctions();

        private string csvPath { get; set; }
        private string insPath { get; set; }
        private string reprogPath { get; set; }
        private string servPath { get; set; }
        private string repPath { get; set; }

        // Overview UI
        public void ViewTerminalDetails(DataGridView obj, string SearchValue)
        {
            DataTable Result = new DataTable();

            obj.Rows.Clear();

            switch (obj.Name)
            {
                // Completed Request
                case "dgv_Sum_ComReq":

                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy = "Terminal" + " | " + "Completed";
                    Ctrl.SearchValue = SearchValue;

                    Result = Ctrl.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["Source"].ToString().Trim(),
                                row["Delivered"].ToString().Trim(),
                                row["Resolved"].ToString().Trim(),
                                row["Total"].ToString().Trim()
                            );

                        }

                    }
                    else
                    {
                        Debug.WriteLine("No Record Found!");
                    }


                    break;

                // Pending Request
                case "dgv_Sum_PenReq":

                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy = "Terminal" + " | " + "Pending";
                    Ctrl.SearchValue = SearchValue;

                    Result = Ctrl.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["Source"].ToString().Trim(),
                                row["7Days"].ToString().Trim(),
                                row["7-30Days"].ToString().Trim(),
                                row["30Days"].ToString().Trim(),
                                row["Total"].ToString().Trim()
                            );
                        }

                    }
                    else
                    {
                        Debug.WriteLine("No Record Found!");
                    }

                    break;

                // Terminal Status
                case "dgv_Model_List":

                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy = "Terminal" + " | " + "Status";
                    Ctrl.SearchValue = SearchValue;

                    Result = Ctrl.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["Terminal_Model"].ToString().Trim(),
                                row["Source"].ToString().Trim(),
                                row["Completed"].ToString().Trim(),
                                row["Pending"].ToString().Trim(),
                                row["Cancelled"].ToString().Trim()
                            );
                        }

                    }
                    else
                    {
                        Debug.WriteLine("No Record Found!");
                    }

                    break;


                // Terminal Status Remarks
                case "dgv_Status_Remarks":

                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy = "Terminal" + " | " + "Status Remarks";
                    Ctrl.SearchValue = SearchValue;

                    Result = Ctrl.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["Terminal_Model"].ToString().Trim(),
                                row["Source"].ToString().Trim(),
                                row["Status_Remarks"].ToString().Trim(),
                                row["Status"].ToString().Trim(),
                                row["7Days"].ToString().Trim(),
                                row["7-30Days"].ToString().Trim(),
                                row["30Days"].ToString().Trim(),
                                row["Total"].ToString().Trim()
                            );
                        }

                    }
                    else
                    {
                        Debug.WriteLine("No Record Found!");
                    }

                    break;

                // Terminal Status Remarks
                case "dgv_Duplicate":

                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy = "Terminal" + " | " + "Duplicate Request";
                    Ctrl.SearchValue = SearchValue;

                    Result = Ctrl.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["ID"].ToString().Trim(),
                                row["Terminal_Model"].ToString().Trim(),
                                row["Case_Referral"].ToString().Trim(),
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

                    }
                    else
                    {
                        Debug.WriteLine("Result : No Record Found!\n");
                    }

                    break;

            }

            obj.ClearSelection();
        }

        // View Details UI
        public void ViewSourceDetails(DataGridView obj, Label Completed, Label Pending, Label Cancelled, Label Waiting, string SearchValue)
        {
            DataTable Result = new DataTable();

            Ctrl.StatementType = "View";
            Ctrl.SearchBy = "Source" + " | " + "Info";
            Ctrl.SearchValue = SearchValue;

            Result = Ctrl.ExecuteQuery(Perform.View);

            switch (SearchValue)
            {
                case string s when s.Contains("tblinstallation"):
                    Completed.Text = sAppData.Template.iTotal_comIns.ToString("n0");
                    Pending.Text = sAppData.Template.iTotal_penIns.ToString("n0");
                    Cancelled.Text = sAppData.Template.iTotal_canIns.ToString("n0");
                    Waiting.Text = sAppData.Template.iTotal_waitIns.ToString("n0");
                    break;

                case string s when s.Contains("tblreprogramming"):
                    Completed.Text = sAppData.Template.iTotal_comReprog.ToString("n0");
                    Pending.Text = sAppData.Template.iTotal_penReprog.ToString("n0");
                    Cancelled.Text = sAppData.Template.iTotal_canReprog.ToString("n0");
                    Waiting.Text = sAppData.Template.iTotal_waitReprog.ToString("n0");
                    break;

                case string s when s.Contains("tblservicing"):
                    Completed.Text = sAppData.Template.iTotal_comServ.ToString("n0");
                    Pending.Text = sAppData.Template.iTotal_penServ.ToString("n0");
                    Cancelled.Text = sAppData.Template.iTotal_canServ.ToString("n0");
                    Waiting.Text = sAppData.Template.iTotal_waitServ.ToString("n0");
                    break;

                case string s when s.Contains("tblrepair"):
                    Completed.Text = sAppData.Template.iTotal_comRep.ToString("n0");
                    Pending.Text = sAppData.Template.iTotal_penRep.ToString("n0");
                    Cancelled.Text = sAppData.Template.iTotal_canRep.ToString("n0");
                    Waiting.Text = sAppData.Template.iTotal_waitRep.ToString("n0");
                    break;

                default:
                    Debug.WriteLine("Result: No Value Fount!");
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

        // Dashboard UI
        public void SearchTerminalHistory(DataGridView obj, ComboBox Template, DateTimePicker DtFrom, DateTimePicker DtTo)
        {
            DataTable Result = new DataTable();

            switch (Template.Text)
            {
                case sAppData.Installation:

                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy      = "Terminal" + " | " + "History";
                    Ctrl.SearchValue   = "tblinstallation" + " | " + 
                                                DtFrom.Value.ToString(cFunctions.Format.Date) + "|" +
                                                DtTo.Value.ToString(cFunctions.Format.Date);

                    Result = Ctrl.ExecuteQuery(Perform.View);

                    break;

                case sAppData.Reprogramming:
                    /*
                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy      = "Terminal" + " | " + "History";
                    Ctrl.SearchValue   = "tblreprogramming" + "|" + 
                                                DtFrom.Value.ToString(cFunctions.Format.Date) + "|" +
                                                DtTo.Value.ToString(cFunctions.Format.Date);

                    Result = Ctrl.ExecuteQuery(Perform.View);
                    */
                    break;

                case sAppData.Servicing:

                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy      = "Terminal" + " | " + "History";
                    Ctrl.SearchValue   = "tblservicing" + " | " +
                                                DtFrom.Value.ToString(cFunctions.Format.Date) + "|" +
                                                DtTo.Value.ToString(cFunctions.Format.Date);

                    Result = Ctrl.ExecuteQuery(Perform.View);

                    break;

                case sAppData.Repair:

                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy      = "Terminal" + " | " + "History";
                    Ctrl.SearchValue   = "tblrepair" + " | " +
                                                DtFrom.Value.ToString(cFunctions.Format.Date) + "|" +
                                                DtTo.Value.ToString(cFunctions.Format.Date);

                    Result = Ctrl.ExecuteQuery(Perform.View);

                    break;

                default:
                    break;

            }

            if (Result.Rows.Count > 0)
            {
                obj.Rows.Clear();

                foreach (DataRow row in Result.Rows)
                {
                    obj.Rows.Add
                    (
                        row["Terminal_Model"].ToString().Trim(),
                        row["Status"].ToString().Trim(),
                        row["Total"].ToString().Trim()
                    );
                }

                obj.ClearSelection();
            }
            else
            {
                Debug.WriteLine("No Record Found!");
            }
        }

        // Process XLS to CSV
        public void ProcessFile(TextBox Tbx, string Template)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Excel Files|*.xls;*.xlsx";
                    ofd.Title  = "Select file to import " + Template;

                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    Tbx.Text = ofd.FileName;

                    if (!Tbx.Text.Contains(Template))
                    {
                        MessageBox.Show("File Not a valid " + Template + " File", "Error Message",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Tbx.Clear();
                        return;
                    }

                    Cursor.Current = Cursors.WaitCursor;

                    try
                    {
                        string excelFilePath = ofd.FileName;
                        string csvFolderPath = sAppData.FilePath.Csv;
                        string csvFileName = Path.GetFileNameWithoutExtension(excelFilePath) + "_" + DateTime.Now.ToString("MMddyy") + ".csv";

                        //clsFunctions.SetDataBind(Obj, Tbx);
                        //clsFunctions.SetGridAlterBackColor(Obj);
                        //clsFunctions.GetGridHeaderList(Obj);

                        switch(Template)
                        {
                            case sAppData.Installation:
                                insPath = cFunctions.Convert.ExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));
                                Debug.WriteLine(Template + " CSV File Location : " + insPath);

                                break;

                            case sAppData.Reprogramming:
                                reprogPath = cFunctions.Convert.ExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));
                                Debug.WriteLine(Template + " CSV File Location : " + reprogPath);
                                break;

                            case sAppData.Servicing:
                                servPath = cFunctions.Convert.ExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));
                                Debug.WriteLine(Template + " CSV File Location : " + servPath);
                                break;

                            case sAppData.Repair:
                                repPath = cFunctions.Convert.ExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));
                                Debug.WriteLine(Template + " CSV File Location : " + repPath);
                                break;
                        }

                        //tpcActivity.SelectedTab = Tbp;

                        MessageBox.Show("File Succefully Uploaded", "File Upload Result",MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // Save CSV
        public void SaveCsvFile(string Template)
        {
            switch (Template)
            {
                case sAppData.Installation:
                    csvPath = insPath;
                    break;

                case sAppData.Reprogramming:
                    csvPath = reprogPath;
                    break;

                case sAppData.Servicing:
                    csvPath = servPath;
                    break;

                case sAppData.Repair:
                    csvPath = repPath;
                    break;
            }

            if (csvPath != null)
            {
                if (MessageBox.Show("Do you want to Delete Existing " + Template + " Database?" +
                    "\nWarning this will permanently delete the data", "Database",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Set Parameters for removal
                    Ctrl.StatementType = "Delete";
                    Ctrl.SearchBy      = Template;
                    Ctrl.ExecuteQuery(Perform.Remove); // Truncate Existing Data

                }

                // Set Parameters for import
                Ctrl.StatementType = "Import";
                Ctrl.SearchBy      = Template;
                Ctrl.Sql           = csvPath;
                Ctrl.ExecuteQuery(Perform.Import); // Save Files
            }     
        }

        // Save using Gridview
        public void SaveGridFile(string Template, DataGridView Obj)
        {
            var queryBuilder = new StringBuilder();
            var queryValues  = new StringBuilder();
            var cultureInfo  = new CultureInfo("en-US");

            string TempValue = string.Empty;
            int rowCount     = Obj.Rows.Count;

            // Batch Size Value for Insertion
            int batchSize = 150;

            if (rowCount > 0)
            {
                if (MessageBox.Show("Do you want to Delete Existing " + Template + " Database?" + "\nWarning this will permanently delete the data", "Database",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Set Parameters
                    Ctrl.StatementType = "Delete";
                    Ctrl.SearchBy      = Template;

                    // Execute Query
                    Ctrl.ExecuteQuery(Perform.Remove); // Delete Existing Data
                }

                for (int rowIndex = 0; rowIndex < rowCount; rowIndex++) // Total Index
                {
                    queryBuilder.Append('(');

                    for (int columnIndex = 0; columnIndex < Obj.ColumnCount; columnIndex++) // Total Columns
                    {
                        var cellValue = Obj.Rows[rowIndex].Cells[columnIndex].Value?.ToString().Trim() ?? "";

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
                        Ctrl.StatementType = "Insert";
                        Ctrl.SearchBy      = Template;
                        Ctrl.Sql           = queryValues.ToString();

                        // Execute Query
                        Ctrl.ExecuteQuery(Perform.Add);

                        queryValues.Clear(); // Clear for Next Batch of Value
                    }
                }

                MessageBox.Show(Template + " Import Successful", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Obj = null;
        }

        // Updates
        public void UpdateDashboard()
        {
            // Update Dashboard
            Ctrl.StatementType = "Update";
            Ctrl.SearchBy      = "Dashboard";
            Ctrl.ExecuteQuery(Perform.Update);
        }


        public void LoadValues()
        {
            DataTable Result = new DataTable();

            Ctrl.StatementType = "View";
            Ctrl.SearchBy      = "Terminal " + " | "+ "Status Summary";
            Result             = Ctrl.ExecuteQuery(Perform.View);

            if (Result.Rows.Count > 0 && Result.Rows.Count >= 4)
            {
                // COMPLETED SUMMARY
                sAppData.Template.iTotal_comIns = int.Parse(Result.Rows[0]["Completed"].ToString().Trim());
                sAppData.Template.iTotal_comReprog = int.Parse(Result.Rows[1]["Completed"].ToString().Trim());
                sAppData.Template.iTotal_comServ = int.Parse(Result.Rows[2]["Completed"].ToString().Trim());
                sAppData.Template.iTotal_comRep = int.Parse(Result.Rows[3]["Completed"].ToString().Trim());

                // PENDING SUMMARY
                sAppData.Template.iTotal_penIns = int.Parse(Result.Rows[0]["Pending"].ToString().Trim());
                sAppData.Template.iTotal_penReprog = int.Parse(Result.Rows[1]["Pending"].ToString().Trim());
                sAppData.Template.iTotal_penServ = int.Parse(Result.Rows[2]["Pending"].ToString().Trim());
                sAppData.Template.iTotal_penRep = int.Parse(Result.Rows[3]["Pending"].ToString().Trim());

                // CANCELLED SUMMARY
                sAppData.Template.iTotal_canIns = int.Parse(Result.Rows[0]["Cancelled"].ToString().Trim());
                sAppData.Template.iTotal_canReprog = int.Parse(Result.Rows[1]["Cancelled"].ToString().Trim());
                sAppData.Template.iTotal_canServ = int.Parse(Result.Rows[2]["Cancelled"].ToString().Trim());
                sAppData.Template.iTotal_canRep = int.Parse(Result.Rows[3]["Cancelled"].ToString().Trim());

                // WAITING SUMMARY
                sAppData.Template.iTotal_waitIns = int.Parse(Result.Rows[0]["Waiting"].ToString().Trim());
                sAppData.Template.iTotal_waitReprog = int.Parse(Result.Rows[1]["Waiting"].ToString().Trim());
                sAppData.Template.iTotal_waitServ = int.Parse(Result.Rows[2]["Waiting"].ToString().Trim());
                sAppData.Template.iTotal_waitRep = int.Parse(Result.Rows[3]["Waiting"].ToString().Trim());

                // Total Inventory Stocks 
                // sAppData.Template.Total_Stocks  = int.Parse(row["Total_MP200"].ToString().Trim()) + int.Parse(row["Total_S1E"].ToString().Trim());

                // TOTAL SUMMARY
                sAppData.Template.iTotal_Com = sAppData.Template.iTotal_comIns + sAppData.Template.iTotal_comReprog + sAppData.Template.iTotal_comServ + sAppData.Template.iTotal_comRep;
                sAppData.Template.iTotal_Pen = sAppData.Template.iTotal_penIns + sAppData.Template.iTotal_penReprog + sAppData.Template.iTotal_penServ + sAppData.Template.iTotal_penRep;
                sAppData.Template.iTotal_Can = sAppData.Template.iTotal_canIns + sAppData.Template.iTotal_canReprog + sAppData.Template.iTotal_canServ + sAppData.Template.iTotal_canRep;
                sAppData.Template.iTotal_Wait = sAppData.Template.iTotal_waitIns + sAppData.Template.iTotal_waitReprog + sAppData.Template.iTotal_waitServ + sAppData.Template.iTotal_waitRep;

                // Data Volume
                sAppData.Template.InstallSize = int.Parse(Result.Rows[0]["Total"].ToString().Trim());
                sAppData.Template.ReprogSize = int.Parse(Result.Rows[1]["Total"].ToString().Trim());
                sAppData.Template.ServSize = int.Parse(Result.Rows[2]["Total"].ToString().Trim());
                sAppData.Template.RepairSize = int.Parse(Result.Rows[3]["Total"].ToString().Trim());

            }

            if (sAppData.Template.InstallSize > 0)
            {
                sAppData.Template.PInstall = cFunctions.GetPercent(sAppData.Template.iTotal_comIns, sAppData.Template.InstallSize);
            }

            if (sAppData.Template.ReprogSize > 0)
            {
                sAppData.Template.PReprog = cFunctions.GetPercent(sAppData.Template.iTotal_comReprog, sAppData.Template.ReprogSize);
            }

            if (sAppData.Template.ServSize > 0)
            {
                sAppData.Template.PServ = cFunctions.GetPercent(sAppData.Template.iTotal_comServ, sAppData.Template.ServSize);
            }

            if (sAppData.Template.RepairSize > 0)
            {
                sAppData.Template.PRepair = cFunctions.GetPercent(sAppData.Template.iTotal_comRep, sAppData.Template.RepairSize);
            }

            else
            {
                Debug.WriteLine("LoadValues No Record Found!\n");
            }
        }

    }
}
