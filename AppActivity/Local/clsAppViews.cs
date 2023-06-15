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

namespace ActivityReportSystem.AppActivity.View
{
    class clsAppViews
    {

        clsAppController Method = new clsAppController();
        clsFunctions cFunc = new clsFunctions();

        // Overview UI
        public void LoadDashboardDetails(DataGridView obj, string SearchValue)
        {
            switch(obj.Name)
            {
                // Completed Request
                case "dgv_Sum_ComReq":

                    DataTable CompletedRequest = Method.ExecuteQuery("View", "Completed Request", SearchValue, string.Empty, clsAppController.Action.View);

                    if (CompletedRequest.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in CompletedRequest.Rows)
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

                    DataTable PendingRequest = Method.ExecuteQuery("View", "Pending Request", SearchValue, string.Empty, clsAppController.Action.View);

                    if (PendingRequest.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in PendingRequest.Rows)
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

                    DataTable BreakDownPending = Method.ExecuteQuery("View", "BD of Pending", SearchValue, string.Empty, clsAppController.Action.View);

                    if (BreakDownPending.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in BreakDownPending.Rows)
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

                    DataTable BreakDownRepair = Method.ExecuteQuery("View", "BD of Pending Repair", SearchValue, string.Empty, clsAppController.Action.View);

                    if (BreakDownRepair.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in BreakDownRepair.Rows)
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

                    DataTable TerminalStatus = Method.ExecuteQuery("View", "Terminal Info", SearchValue, string.Empty, clsAppController.Action.View);

                    if (TerminalStatus.Rows.Count > 0)
                    {
                        obj.Rows.Clear();

                        foreach (DataRow row in TerminalStatus.Rows)
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

                case clsFunctions.sInstall:

                    Result = Method.ExecuteQuery("View", "Installation", SearchValue, string.Empty, clsAppController.Action.View);

                    Com.Text = sAppData.Template.iTotal_comIns.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penIns.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canIns.ToString("n0");

                    break;

                case clsFunctions.sReprog:

                    Result = Method.ExecuteQuery("View", "Reprogramming", SearchValue, string.Empty, clsAppController.Action.View);

                    Com.Text = sAppData.Template.iTotal_comReprog.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penReprog.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canReprog.ToString("n0");

                    break;

                case clsFunctions.sServ:

                    Result = Method.ExecuteQuery("View", "Servicing", SearchValue, string.Empty, clsAppController.Action.View);

                    Com.Text = sAppData.Template.iTotal_comServ.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penServ.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canServ.ToString("n0");

                    break;

                case clsFunctions.sRepair:

                    Result = Method.ExecuteQuery("View", "Repair", SearchValue, string.Empty, clsAppController.Action.View);

                    Com.Text = sAppData.Template.iTotal_comRep.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penRep.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canRep.ToString("n0");

                    obj.ClearSelection();

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
                        row["ID"].ToString().Trim(),
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
                case clsFunctions.sInstall:

                    Result = Method.ExecuteQuery("View",
                             "Terminal Status",
                             "tblinstallation" + "|"
                                 + DtFrom.Value.ToString(clsFunctions.sDateFormat) + "|"
                                 + DtTo.Value.ToString(clsFunctions.sDateFormat),
                              string.Empty,
                              clsAppController.Action.View);

                    break;

                case clsFunctions.sReprog:
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

                case clsFunctions.sServ:

                    Result = Method.ExecuteQuery("View",
                             "Terminal Status",
                             "tblservicing" + "|"
                                 + DtFrom.Value.ToString(clsFunctions.sDateFormat) + "|"
                                 + DtTo.Value.ToString(clsFunctions.sDateFormat),
                              string.Empty,
                              clsAppController.Action.View);

                    break;

                case clsFunctions.sRepair:

                    Result = Method.ExecuteQuery("View",
                             "Terminal Status",
                             "tblrepair" + "|"
                                 + DtFrom.Value.ToString(clsFunctions.sDateFormat) + "|"
                                 + DtTo.Value.ToString(clsFunctions.sDateFormat),
                              string.Empty,
                              clsAppController.Action.View); ;
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

        public void ImportDataUsingGrid(string Template, DataGridView Obj)
        {
            var queryBuilder = new StringBuilder();
            var queryValues = new StringBuilder();
            var cultureInfo = new CultureInfo("en-US");

            string TempQuery = string.Empty;
            int batchSize = 150;
            int rowCount = Obj.Rows.Count;

            if (rowCount > 0)
            {
                if (MessageBox.Show("Do you want to Delete Existing " + Template + " Database?" + "\nWarning this will permanently delete the data", "Database",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Method.ExecuteQuery("Delete", Template, string.Empty, string.Empty, clsAppController.Action.Delete); // Delete Existing Data
                }

                for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
                {
                    queryBuilder.Append('(');

                    for (int columnIndex = 0; columnIndex < Obj.ColumnCount; columnIndex++)
                    {
                        var cellValue = Obj.Rows[rowIndex].Cells[columnIndex].Value?.ToString().Trim() ?? string.Empty;

                        // Remove Special Characters
                        cellValue = cellValue.Replace("ñ", "n")
                                           .Replace("Ñ", "N")
                                           .Replace(" ", string.Empty)
                                           .Replace(",", string.Empty)
                                           .Replace("'", string.Empty)
                                           .Replace("#NAME?", string.Empty)
                                           .Replace("#VALUE!", string.Empty);

                        // Check Cell for Date Formats
                        if (DateTime.TryParse(cellValue, out DateTime tempDate))
                        {
                            cellValue = tempDate.ToString(clsFunctions.sDateTimeFormat);
                        }

                        queryBuilder.Append($"'{cellValue}',");
                    }

                    queryBuilder.Length = queryBuilder.Length - 1; // Remove Last Comma,
                    queryBuilder.Append(')'); // Closed Bracket

                    // Preserve Rows Value.
                    TempQuery = queryBuilder.ToString();

                    // Clear to Create New.
                    queryBuilder.Clear();

                    //if (queryValues.Length > 0) queryValues.Append(string.Concat(", ", Environment.NewLine, TempQuery));
                    //else queryValues.Append(TempQuery);

                    queryValues.Append(queryValues.Length > 0 ? $", {Environment.NewLine}{TempQuery}" : TempQuery);

                    if ((rowIndex + 1) % batchSize == 0 || rowIndex == rowCount - 1)
                    {
                        Method.ExecuteQuery("Insert", Template, string.Empty, queryValues.ToString(), clsAppController.Action.Insert);
                        queryValues.Clear(); // Clear the queryValues StringBuilder after executing each batch
                    }
                }

                MessageBox.Show(Template + " Import Successful", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Obj = null;
        }

        public void ProcessDataFile(TextBox Tbx, DataGridView Obj, TabControl tpcActivity, TabPage Tbp, string Template)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Excel Files|*.xls;*.xlsx";
                    ofd.Title = "Select file to import " + Template;

                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    Debug.WriteLine(ofd.FileName);

                    Tbx.Text = ofd.FileName;

                    if (!Tbx.Text.Contains(Template))
                    {
                        clsFunctions.setMessageBox("File Not a valid " + Template + " File", "Error Message", clsFunctions.IconType.iWarning);
                        Tbx.Clear();
                        return;
                    }

                    Cursor.Current = Cursors.WaitCursor;

                    try
                    {
                        string excelFilePath = ofd.FileName;
                        string csvFolderPath = sAppData.FilePath.Csv;
                        string csvFileName = Path.GetFileNameWithoutExtension(excelFilePath) + "_" + DateTime.Now.ToString("MMddyy") + ".csv";

                        clsFunctions.SetDataBind(Obj, Tbx);
                        clsFunctions.SetGridAlterBackColor(Obj);
                        //clsFunctions.GetGridHeaderList(Obj);

                        tpcActivity.SelectedTab = Tbp;

                        sAppData.FilePath.CsvLoc = cFunc.ConvertExcelToCsv(excelFilePath, Path.Combine(csvFolderPath, csvFileName));

                        Debug.WriteLine("\nConvert Excel to CSV successfull.");
                        Debug.WriteLine("File Location : " + sAppData.FilePath.CsvLoc);
                    }
                    catch (Exception e)
                    {
                        clsFunctions.setMessageBox(e.Message, "Activity Report System", clsFunctions.IconType.iError);
                    }

                    Cursor.Current = Cursors.Default;
                                            
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Open failed.");
            }
        }

        // Updates
        public void UpdateDashboard()
        {
            // Clear Parameters
            DefaultValues();

            // Update Dashboard
            Method.ExecuteQuery("Update", "Dashboard", string.Empty, string.Empty, clsAppController.Action.Update);

            // Execute
            LoadValues();
        }

        public void LoadValues()
        {
            sAppData.CountDetails = Method.ExecuteQuery("View", "Total Counts", string.Empty, string.Empty, clsAppController.Action.View);

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
                    sAppData.Template.PInstall = clsFunctions.getPercent(sAppData.Template.iTotal_comIns, sAppData.Template.InstallSize);
                }

                if (sAppData.Template.ReprogSize > 0)
                {
                    sAppData.Template.PReprog = clsFunctions.getPercent(sAppData.Template.iTotal_comReprog, sAppData.Template.ReprogSize);
                }

                if (sAppData.Template.ServSize > 0)
                {
                    sAppData.Template.PServ = clsFunctions.getPercent(sAppData.Template.iTotal_comServ, sAppData.Template.ServSize);
                }

                if (sAppData.Template.RepairSize > 0)
                {
                    sAppData.Template.PRepair = clsFunctions.getPercent(sAppData.Template.iTotal_comRep, sAppData.Template.RepairSize);
                }

            }
            else
            {
                Debug.WriteLine("No Record Found!");
            }
        }

        public void DefaultValues()
        {
            sAppData.Template.iTotal_Com = 0;
            sAppData.Template.iTotal_Pen = 0;
            sAppData.Template.iTotal_Can = 0;

            sAppData.Template.iTotal_comIns = 0;
            sAppData.Template.iTotal_penIns = 0;
            sAppData.Template.iTotal_canIns = 0;

            sAppData.Template.iTotal_comReprog = 0;
            sAppData.Template.iTotal_penReprog = 0;
            sAppData.Template.iTotal_canReprog = 0;

            sAppData.Template.iTotal_comServ = 0;
            sAppData.Template.iTotal_penServ = 0;
            sAppData.Template.iTotal_canServ = 0;

            sAppData.Template.iTotal_comRep = 0;
            sAppData.Template.iTotal_penRep = 0;
            sAppData.Template.iTotal_canRep = 0;

        }


    }
}
