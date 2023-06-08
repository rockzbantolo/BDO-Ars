using ActivityReportSystem.AppMVC.Controller;
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

                    DataTable CompletedRequest = Method.ExecuteQuery(clsAppController.Action.View, "View", "ComRequest", string.Empty, string.Empty, string.Empty);

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

                    DataTable PendingRequest = Method.ExecuteQuery(clsAppController.Action.View, "View", "PenRequest", string.Empty, string.Empty, string.Empty);

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

                    DataTable BreakDownPending = Method.ExecuteQuery(clsAppController.Action.View, "View", "BDPending", string.Empty, string.Empty, string.Empty);

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

                    DataTable BreakDownRepair = Method.ExecuteQuery(clsAppController.Action.View, "View", "BDPenRepair", string.Empty, string.Empty, string.Empty);

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

                    DataTable TerminalStatus = Method.ExecuteQuery(clsAppController.Action.View, "View", "TerminalStatus", string.Empty, string.Empty, string.Empty);

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
            Method.ExecuteQuery(clsAppController.Action.Update, "Update", "Dashboard", string.Empty, string.Empty, string.Empty);

        }


    }
}
