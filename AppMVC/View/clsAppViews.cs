using ActivityReportSystem.AppMVC.Controller;
using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityReportSystem.AppMVC.View
{
    class clsAppViews
    {

        clsAppController Method = new clsAppController();

        public void LoadDashboardDetails(DataGridView obj)
        {
            switch(obj.Name)
            {
                // Completed Request
                case "dgv_Sum_ComReq":

                    DataTable CompletedRequest = Method.ExecuteQuery("View", "ComRequest", string.Empty, string.Empty, string.Empty, clsAppController.Action.View);

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

                    DataTable PendingRequest = Method.ExecuteQuery("View", "PenRequest", string.Empty, string.Empty, string.Empty, clsAppController.Action.View);

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

                    DataTable BreakDownPending = Method.ExecuteQuery("View", "BDPending", string.Empty, string.Empty, string.Empty, clsAppController.Action.View);

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

                    DataTable BreakDownRepair = Method.ExecuteQuery("View", "BDPenRepair", string.Empty, string.Empty, string.Empty, clsAppController.Action.View);

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

                    DataTable TerminalStatus = Method.ExecuteQuery("View", "TerminalStatus", string.Empty, string.Empty, string.Empty, clsAppController.Action.View);

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

            // Display Details



        }

        public void UpdateDashboard()
        {
            // Update Dashboard
            Method.ExecuteQuery("Update", "Dashboard", string.Empty, string.Empty, string.Empty, clsAppController.Action.Update);
            LoadValues();
        }

        public void LoadValues()
        {
            DataTable TotalCounts = Method.ExecuteQuery("View", "Total Counts", string.Empty, string.Empty, string.Empty, clsAppController.Action.View);

            if (TotalCounts.Rows.Count > 0)
            {

                foreach (DataRow row in TotalCounts.Rows)
                {

                    //Total Data
                    clsAppData.Template.InstallVolume   = int.Parse(row["TotalIns"].ToString().Trim());
                    clsAppData.Template.ReprogVolume    = int.Parse(row["TotalReprog"].ToString().Trim());
                    clsAppData.Template.ServVolume      = int.Parse(row["TotalServ"].ToString().Trim());
                    clsAppData.Template.RepairVolume    = int.Parse(row["TotalRep"].ToString().Trim());

                    //Terminal Inventory
                    clsAppData.Template.inMp200_Ttl_Stock   = int.Parse(row["Total_MP200"].ToString().Trim());
                    clsAppData.Template.inS1E_Ttl_Stock     = int.Parse(row["Total_S1E"].ToString().Trim());

                    // MP200

                    // INSTALLATION
                    clsAppData.Template.inMp200_Ttl_comIns = int.Parse(row["MPComIns"].ToString().Trim());
                    clsAppData.Template.inMp200_Ttl_penIns = int.Parse(row["MPPenIns"].ToString().Trim());
                    clsAppData.Template.inMp200_Ttl_canIns = int.Parse(row["MPCanIns"].ToString().Trim());

                    // REPROGRAMMING
                    clsAppData.Template.inMp200_Ttl_comReprog = int.Parse(row["MPComReprog"].ToString().Trim());
                    clsAppData.Template.inMp200_Ttl_penReprog = int.Parse(row["MPPenReprog"].ToString().Trim());
                    clsAppData.Template.inMp200_Ttl_canReprog = int.Parse(row["MPCanReprog"].ToString().Trim());

                    // SERVICING
                    clsAppData.Template.inMp200_Ttl_comServ = int.Parse(row["MPComServ"].ToString().Trim());
                    clsAppData.Template.inMp200_Ttl_penServ = int.Parse(row["MPPenServ"].ToString().Trim());
                    clsAppData.Template.inMp200_Ttl_canServ = int.Parse(row["MPCanServ"].ToString().Trim());

                    // REPAIR
                    clsAppData.Template.inMp200_Ttl_comRepair = int.Parse(row["MPComRep"].ToString().Trim());
                    clsAppData.Template.inMp200_Ttl_penRepair = int.Parse(row["MPPenRep"].ToString().Trim());
                    clsAppData.Template.inMp200_Ttl_canRepair = int.Parse(row["MPCanRep"].ToString().Trim());

                    // S1E Mini

                    // INSTALLATION
                    clsAppData.Template.inS1E_Ttl_comIns = int.Parse(row["S1EComIns"].ToString().Trim());
                    clsAppData.Template.inS1E_Ttl_penIns = int.Parse(row["S1EPenIns"].ToString().Trim());
                    clsAppData.Template.inS1E_Ttl_canIns = int.Parse(row["S1ECanIns"].ToString().Trim());

                    // REPROGRAMMING
                    clsAppData.Template.inS1E_Ttl_comReprog = int.Parse(row["S1EComReprog"].ToString().Trim());
                    clsAppData.Template.inS1E_Ttl_penReprog = int.Parse(row["S1EPenReprog"].ToString().Trim());
                    clsAppData.Template.inS1E_Ttl_canReprog = int.Parse(row["S1ECanReprog"].ToString().Trim());

                    // SERVICING
                    clsAppData.Template.inS1E_Ttl_comServ = int.Parse(row["S1EComServ"].ToString().Trim());
                    clsAppData.Template.inS1E_Ttl_penServ = int.Parse(row["S1EPenServ"].ToString().Trim());
                    clsAppData.Template.inS1E_Ttl_penServ = int.Parse(row["S1ECanServ"].ToString().Trim());

                    // REPAIR
                    clsAppData.Template.inS1E_Ttl_comRepair = int.Parse(row["S1EComRep"].ToString().Trim());
                    clsAppData.Template.inS1E_Ttl_penRepair = int.Parse(row["S1EPenRep"].ToString().Trim());
                    clsAppData.Template.inS1E_Ttl_penRepair = int.Parse(row["S1ECanRep"].ToString().Trim());
                }

            }
            else
            {
                Debug.WriteLine("No Record Found!");
            }
        }

        public void SearchTerminalStatus(DataGridView obj, ComboBox Template,  DateTimePicker DtFrom, DateTimePicker DtTo)
        {
            Template.BeginUpdate();

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

            Template.EndUpdate();
        }

    }
}
