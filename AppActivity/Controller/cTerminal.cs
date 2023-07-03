using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using AppAction;
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
    class cTerminal
    {
        cSpModel Sp = new cSpModel();

        public string Template { get; set; }
        public DateTimePicker DateFrom { get; set; }
        public DateTimePicker DateTo { get; set; }
        public string HeaderName { get; set; }
        public string SearchValue { get; set; } = string.Empty;


        public void GetDetails(DataGridView obj)
        {
            DataTable Result = new DataTable();

            obj.Rows.Clear();

            switch (obj.Name)
            {
                // Completed Request
                case "dgv_Sum_ComReq":

                    Sp.StatementType = "View";
                    Sp.SearchBy = "Terminal" + cFunctions.Pipe + "Completed";
                    Sp.SearchValue = SearchValue;

                    Result = Sp.ExecuteQuery(Perform.View);

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

                    Sp.StatementType = "View";
                    Sp.SearchBy = "Terminal" + cFunctions.Pipe + "Pending";
                    Sp.SearchValue = SearchValue;

                    Result = Sp.ExecuteQuery(Perform.View);

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

                    Sp.StatementType = "View";
                    Sp.SearchBy = "Terminal" + cFunctions.Pipe + "Status";
                    Sp.SearchValue = SearchValue;

                    Result = Sp.ExecuteQuery(Perform.View);

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


                //Terminal Status Remarks
                case "dgv_Status_Remarks":

                    Sp.StatementType = "View";
                    Sp.SearchBy = "Terminal" + cFunctions.Pipe + "Status Remarks";
                    Sp.SearchValue = SearchValue;

                    Result = Sp.ExecuteQuery(Perform.View);

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

                    Sp.StatementType = "View";
                    Sp.SearchBy = "Terminal" + cFunctions.Pipe + "Duplicate Request";
                    Sp.SearchValue = SearchValue;

                    Result = Sp.ExecuteQuery(Perform.View);

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

        public void GetHistory(DataGridView obj)
        {
            DataTable Result = new DataTable();

            switch (Template)
            {
                case sAppData.Installation:

                    Sp.StatementType = "View";
                    Sp.SearchBy = "Terminal" + cFunctions.Pipe + "History";
                    Sp.SearchValue = "tblinstallation" + cFunctions.Pipe +
                                                DateFrom.Value.ToString(cFunctions.Format.Date) + cFunctions.Pipe +
                                                DateTo.Value.ToString(cFunctions.Format.Date);

                    Result = Sp.ExecuteQuery(Perform.View);

                    break;

                case sAppData.Reprogramming:
                    /*
                    Ctrl.StatementType = "View";
                    Ctrl.SearchBy      = "Terminal" + cFunctions.Pipe + "History";
                    Ctrl.SearchValue   = "tblreprogramming" + "|" + 
                                                DtFrom.Value.ToString(cFunctions.Format.Date) + cFunctions.Pipe +
                                                DtTo.Value.ToString(cFunctions.Format.Date);

                    Result = Ctrl.ExecuteQuery(Perform.View);
                    */
                    break;

                case sAppData.Servicing:

                    Sp.StatementType = "View";
                    Sp.SearchBy = "Terminal" + cFunctions.Pipe + "History";
                    Sp.SearchValue = "tblservicing" + cFunctions.Pipe +
                                                DateFrom.Value.ToString(cFunctions.Format.Date) + cFunctions.Pipe +
                                                DateTo.Value.ToString(cFunctions.Format.Date);

                    Result = Sp.ExecuteQuery(Perform.View);

                    break;

                case sAppData.Repair:

                    Sp.StatementType = "View";
                    Sp.SearchBy = "Terminal" + cFunctions.Pipe + "History";
                    Sp.SearchValue = "tblrepair" + cFunctions.Pipe +
                                                DateFrom.Value.ToString(cFunctions.Format.Date) + cFunctions.Pipe +
                                                DateTo.Value.ToString(cFunctions.Format.Date);

                    Result = Sp.ExecuteQuery(Perform.View);

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

    }
}

