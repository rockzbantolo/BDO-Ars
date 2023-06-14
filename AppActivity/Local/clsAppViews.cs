using ActivityReportSystem.AppActivity.Controller;
using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace ActivityReportSystem.AppActivity.View
{
    class clsAppViews
    {

        clsAppController Method = new clsAppController();

        // Overview UI
        public void LoadDashboardDetails(DataGridView obj, string SearchValue)
        {
            switch(obj.Name)
            {
                // Completed Request
                case "dgv_Sum_ComReq":

                    DataTable CompletedRequest = Method.ExecuteQuery("View", "Completed Request", SearchValue, string.Empty, string.Empty, clsAppController.Action.View);

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

                    DataTable PendingRequest = Method.ExecuteQuery("View", "Pending Request", SearchValue, string.Empty, string.Empty, clsAppController.Action.View);

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

                    DataTable BreakDownPending = Method.ExecuteQuery("View", "BD of Pending", SearchValue, string.Empty, string.Empty, clsAppController.Action.View);

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

                    DataTable BreakDownRepair = Method.ExecuteQuery("View", "BD of Pending Repair", SearchValue, string.Empty, string.Empty, clsAppController.Action.View);

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

                    DataTable TerminalStatus = Method.ExecuteQuery("View", "Terminal Info", SearchValue, string.Empty, string.Empty, clsAppController.Action.View);

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

            switch (sAppData.DataParam.TempName)
            {

                case clsFunctions.sInstall:

                    Result = Method.ExecuteQuery("View", "Installation", SearchValue, string.Empty, string.Empty, clsAppController.Action.View);

                    Com.Text = sAppData.Template.iTotal_comIns.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penIns.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canIns.ToString("n0");

                    break;

                case clsFunctions.sReprog:

                    Result = Method.ExecuteQuery("View", "Reprogramming", SearchValue, string.Empty, string.Empty, clsAppController.Action.View);

                    Com.Text = sAppData.Template.iTotal_comReprog.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penReprog.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canReprog.ToString("n0");

                    break;

                case clsFunctions.sServ:

                    Result = Method.ExecuteQuery("View", "Servicing", SearchValue, string.Empty, string.Empty, clsAppController.Action.View);

                    Com.Text = sAppData.Template.iTotal_comServ.ToString("n0");
                    Pen.Text = sAppData.Template.iTotal_penServ.ToString("n0");
                    Can.Text = sAppData.Template.iTotal_canServ.ToString("n0");

                    break;

                case clsFunctions.sRepair:

                    Result = Method.ExecuteQuery("View", "Repair", SearchValue, string.Empty, string.Empty, clsAppController.Action.View);

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

        // Updates
        public void UpdateDashboard()
        {
            // Clear Parameters
            DefaultValues();

            // Update Dashboard
            Method.ExecuteQuery("Update", "Dashboard", string.Empty, string.Empty, string.Empty, clsAppController.Action.Update);

            // Execute
            LoadValues();
        }

        public void LoadValues()
        {
            sAppData.CountDetails = Method.ExecuteQuery("View", "Total Counts", string.Empty, string.Empty, string.Empty, clsAppController.Action.View);

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
