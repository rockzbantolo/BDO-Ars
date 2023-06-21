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
    class clsAppViews
    {

        clsSpController Controller = new clsSpController();
        cFunctions cFunc = new cFunctions();

        private string csvPath { get; set; }
        private string insPath { get; set; }
        private string reprogPath { get; set; }
        private string servPath { get; set; }
        private string repPath { get; set; }
        private string colName { get; set; }

        // Overview UI
        public void LoadDashboardDetails(DataGridView obj, string SearchValue)
        {
            DataTable Result = new DataTable();

            switch(obj.Name)
            {
                // Completed Request
                case "dgv_Sum_ComReq":

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Completed Request";
                    Controller.SearchValue   = SearchValue;
                    Controller.Sql           = "";

                    Result = Controller.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["Template"].ToString().Trim(),
                                row["TDelivered"].ToString().Trim(),
                                row["TResolved"].ToString().Trim(),
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

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Pending Request";
                    Controller.SearchValue   = SearchValue;
                    Controller.Sql           = "";

                    Result = Controller.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["Template"].ToString().Trim(),
                                row["Day7"].ToString().Trim(),
                                row["Day730"].ToString().Trim(),
                                row["Day30"].ToString().Trim(),
                                row["Total"].ToString().Trim()
                            );
                        }

                    }
                    else
                    {
                        Debug.WriteLine("No Record Found!");
                    }

                    break;

                // Breakdown of Pending Request
                case "dgv_BdPendings":

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "BD of Pending";
                    Controller.SearchValue   = SearchValue;
                    Controller.Sql           = "";

                    Result = Controller.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["Template"].ToString().Trim(),
                                row["Day7"].ToString().Trim(),
                                row["Day730"].ToString().Trim(),
                                row["Day30"].ToString().Trim(),
                                row["Total"].ToString().Trim()
                            );
                        }

                    }
                    else
                    {
                        Debug.WriteLine("No Record Found!");
                    }

                    break;

                // Breakdown of Pending Repair
                case "dgv_Bdp_Rep":

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "BD of Pending Repair";
                    Controller.SearchValue   = SearchValue;
                    Controller.Sql           = "";

                    Result = Controller.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["Template"].ToString().Trim(),
                                row["Day7"].ToString().Trim(),
                                row["Day730"].ToString().Trim(),
                                row["Day30"].ToString().Trim(),
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

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Terminal Info";
                    Controller.SearchValue   = SearchValue;
                    Controller.Sql           = "";

                    Result = Controller.ExecuteQuery(Perform.View);

                    if (Result.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in Result.Rows)
                        {
                            obj.Rows.Add
                            (
                                row["Terminal_Model"].ToString().Trim(),
                                row["Template"].ToString().Trim(),
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

            }

            obj.ClearSelection();
        }

        // View Details UI
        public void LoadTemplateDetails(DataGridView obj, Label Com, Label Pen, Label Can, string SearchValue)
        {
            DataTable Result = new DataTable();

            switch (sAppData.TemplateName)
            {

                case sAppData.Installation:

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Installation";
                    Controller.SearchValue   = SearchValue;

                    Result = Controller.ExecuteQuery(Perform.View);

                    Com.Text = sAppData.Template.iTotal_comIns.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penIns.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canIns.ToString("n0");

                    colName = "ID";

                    break;

                case sAppData.Reprogramming:

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Reprogramming";
                    Controller.SearchValue   = SearchValue;

                    Result = Controller.ExecuteQuery(Perform.View);

                    Com.Text = sAppData.Template.iTotal_comReprog.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penReprog.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canReprog.ToString("n0");

                    colName = "ID";

                    break;

                case sAppData.Servicing:

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Servicing";
                    Controller.SearchValue   = SearchValue;

                    Result = Controller.ExecuteQuery(Perform.View);

                    Com.Text = sAppData.Template.iTotal_comServ.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penServ.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canServ.ToString("n0");

                    colName = "Case_Referral";

                    break;

                case sAppData.Repair:

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Repair";
                    Controller.SearchValue   = SearchValue;

                    Result = Controller.ExecuteQuery(Perform.View);

                    Com.Text = sAppData.Template.iTotal_comRep.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penRep.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canRep.ToString("n0");

                    colName = "Case_Referral";

                    break;
            }

            if (Result.Rows.Count > 0)
            {
                obj.Rows.Clear();

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
                Debug.WriteLine("No Record Found!");
            }
        }

        // Dashboard UI
        public void SearchTerminalStatus(DataGridView obj, ComboBox Template, DateTimePicker DtFrom, DateTimePicker DtTo)
        {
            DataTable Result = new DataTable();

            switch (Template.Text)
            {
                case sAppData.Installation:

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Terminal Status";
                    Controller.SearchValue   = "tblinstallation" + "|" + 
                                                DtFrom.Value.ToString(cFunctions.Format.Date) + "|" +
                                                DtTo.Value.ToString(cFunctions.Format.Date);

                    Result = Controller.ExecuteQuery(Perform.View);

                    break;

                case sAppData.Reprogramming:
                    /*
                    Result = Method.ExecuteQuery("View",
                             "Terminal Status",
                             "tblreprogramming" + "|"
                                 + DtFrom.Value.ToString(clsFunctions.sDateFormat) + "|"
                                 + DtTo.Value.ToString(clsFunctions.sDateFormat),
                              string.Empty,
                              string.Empty,
                              clsAppController.Action.View);
                    */
                    break;

                case sAppData.Servicing:

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Terminal Status";
                    Controller.SearchValue   = "tblservicing" + "|" +
                                                DtFrom.Value.ToString(cFunctions.Format.Date) + "|" +
                                                DtTo.Value.ToString(cFunctions.Format.Date);

                    Result = Controller.ExecuteQuery(Perform.View);

                    break;

                case sAppData.Repair:

                    Controller.StatementType = "View";
                    Controller.SearchBy      = "Terminal Status";
                    Controller.SearchValue   = "tblrepair" + "|" +
                                                DtFrom.Value.ToString(cFunctions.Format.Date) + "|" +
                                                DtTo.Value.ToString(cFunctions.Format.Date);

                    Result = Controller.ExecuteQuery(Perform.View);

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
                Result = null;
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

        // Save Data
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
                    Controller.StatementType = "Delete";
                    Controller.SearchBy      = Template;
                    Controller.ExecuteQuery(Perform.Remove); // Truncate Existing Data

                }

                // Set Parameters for import
                Controller.StatementType = "Import";
                Controller.SearchBy      = Template;
                Controller.Sql           = csvPath;
                Controller.ExecuteQuery(Perform.Import); // Save Files
            }     
        }

        public void SaveGridFile(string Template, DataGridView Obj)
        {
            var queryBuilder = new StringBuilder();
            var queryValues = new StringBuilder();
            var cultureInfo = new CultureInfo("en-US");

            string TempValue = string.Empty;
            int batchSize = 150;
            int rowCount = Obj.Rows.Count;

            if (rowCount > 0)
            {
                if (MessageBox.Show("Do you want to Delete Existing " + Template + " Database?" + "\nWarning this will permanently delete the data", "Database",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Controller.StatementType = "Delete";
                    Controller.SearchBy = Template;
                    Controller.ExecuteQuery(Perform.Remove); // Delete Existing Data
                }

                for (int rowIndex = 0; rowIndex < rowCount; rowIndex++) // Total Index
                {
                    queryBuilder.Append('(');

                    for (int columnIndex = 0; columnIndex < Obj.ColumnCount; columnIndex++) // Total Columns
                    {
                        var cellValue = Obj.Rows[rowIndex].Cells[columnIndex].Value?.ToString().Trim() ?? "";

                        // Remove Special Characters
                        cellValue = string.IsNullOrWhiteSpace(cellValue) ? "-" : cFunctions.Convert.CharAndDate(cellValue);

                        queryBuilder.Append($"'{cellValue}',");
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
                        Controller.StatementType = "Insert";
                        Controller.SearchBy      = Template;
                        Controller.Sql           = queryValues.ToString();

                        Controller.ExecuteQuery(Perform.Add);

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
            Controller.StatementType = "Update";
            Controller.SearchBy      = "Dashboard";
            Controller.ExecuteQuery(Perform.Update);

            // Execute
            LoadValues();
        }

        public void LoadValues()
        {
            Controller.StatementType = "View";
            Controller.SearchBy      = "Total Counts";

            sAppData.CountDetails = Controller.ExecuteQuery(Perform.View);

            if (sAppData.CountDetails.Rows.Count > 0)
            {
                foreach (DataRow row in sAppData.CountDetails.Rows)
                {

                    // COMPLETED SUMMARY
                    sAppData.Template.iTotal_comIns     = int.Parse(row["MPComIns"].ToString().Trim())    + int.Parse(row["S1EComIns"].ToString().Trim());
                    sAppData.Template.iTotal_comReprog  = int.Parse(row["MPComReprog"].ToString().Trim()) + int.Parse(row["S1EComReprog"].ToString().Trim());
                    sAppData.Template.iTotal_comServ    = int.Parse(row["MPComServ"].ToString().Trim())   + int.Parse(row["S1EComServ"].ToString().Trim());
                    sAppData.Template.iTotal_comRep     = int.Parse(row["MPComRep"].ToString().Trim())    + int.Parse(row["S1EComRep"].ToString().Trim());

                    // PENDING SUMMARY
                    sAppData.Template.iTotal_penIns     = int.Parse(row["MPPenIns"].ToString().Trim())    + int.Parse(row["S1EPenIns"].ToString().Trim());
                    sAppData.Template.iTotal_penReprog  = int.Parse(row["MPPenReprog"].ToString().Trim()) + int.Parse(row["S1EPenReprog"].ToString().Trim());
                    sAppData.Template.iTotal_penServ    = int.Parse(row["MPPenServ"].ToString().Trim())   + int.Parse(row["S1EPenServ"].ToString().Trim());
                    sAppData.Template.iTotal_penRep     = int.Parse(row["MPPenRep"].ToString().Trim())    + int.Parse(row["S1EPenRep"].ToString().Trim());

                    // CANCELLED SUMMARY
                    sAppData.Template.iTotal_canIns     = int.Parse(row["MPCanIns"].ToString().Trim())    + int.Parse(row["S1ECanIns"].ToString().Trim());
                    sAppData.Template.iTotal_canReprog  = int.Parse(row["MPCanReprog"].ToString().Trim()) + int.Parse(row["S1ECanReprog"].ToString().Trim());
                    sAppData.Template.iTotal_canServ    = int.Parse(row["MPCanServ"].ToString().Trim())   + int.Parse(row["S1ECanServ"].ToString().Trim());
                    sAppData.Template.iTotal_canRep     = int.Parse(row["MPCanRep"].ToString().Trim())    + int.Parse(row["S1ECanRep"].ToString().Trim());

                    // Total Inventory Stocks 
                    sAppData.Template.Total_Stocks        = int.Parse(row["Total_MP200"].ToString().Trim()) + int.Parse(row["Total_S1E"].ToString().Trim());

                    // TOTAL SUMMARY
                    sAppData.Template.iTotal_Com = sAppData.Template.iTotal_comIns + sAppData.Template.iTotal_comReprog + sAppData.Template.iTotal_comServ + sAppData.Template.iTotal_comRep;
                    sAppData.Template.iTotal_Pen = sAppData.Template.iTotal_penIns + sAppData.Template.iTotal_penReprog + sAppData.Template.iTotal_penServ + sAppData.Template.iTotal_penRep;
                    sAppData.Template.iTotal_Can = sAppData.Template.iTotal_canIns + sAppData.Template.iTotal_canReprog + sAppData.Template.iTotal_canServ + sAppData.Template.iTotal_canRep;

                    // Data Volume
                    sAppData.Template.InstallSize = int.Parse(row["TotalIns"].ToString().Trim());
                    sAppData.Template.ReprogSize  = int.Parse(row["TotalReprog"].ToString().Trim());
                    sAppData.Template.ServSize    = int.Parse(row["TotalServ"].ToString().Trim());
                    sAppData.Template.RepairSize  = int.Parse(row["TotalRep"].ToString().Trim());

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

            }
            else
            {
                Debug.WriteLine("No Record Found!");
            }
        }

    }
}
