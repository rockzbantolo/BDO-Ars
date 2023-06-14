using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using ActivityReportSystem.Global;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;
using System.Data.OleDb;
using System.Data;
using System.IO;
using Spire.Xls;
using System.Globalization;

namespace ActivityReportSystem.Function
{


    public class clsFunctions : clsStyle
    {

    // FORMATS

        public const string sDash               = "-";
        public const string sDateLengthFormat   = "0000-00-00";
        public const string sTimeFormat     = "00:00:00";
        public const string sDateDefault    = "00-00-0000";
        public const string sTimeDefault    = "00:00:00 00";

        public const string sDateDefaultFormat = "ddd, MMM-dd-yyyy";
        public const string sDateTimeFormat = "MM-dd-yyyy HH:mm tt";
        public const string sDateFormat = "yyyy-MM-dd";
        public const string sTimeDefaultFormat = "hh:mm tt";

        public static string LineSeperator = "====================================================";

    // TEMPLATE NAME

        public const string sInstall    = "Installation";
        public const string sReprog     = "Reprogramming";
        public const string sServ       = "Servicing";
        public const string sRepair     = "Repair";
        public const string sInventory  = "Inventory";

        public static string[] Templates = { string.Empty, sInstall, sReprog, sServ, sRepair };

        #region Colors

        public static readonly Color EntryBackColor      = Color.White;
        public static readonly Color DisableBackColor    = Color.FromArgb(224, 224, 224);
        public static readonly Color ListViewBackColor   = Color.Azure;
        public static readonly Color GridViewBackColor   = Color.Azure;
        public static readonly Color DateBackColor       = Color.Lavender;
        public static readonly Color AlternateBackColor1 = Color.Snow;
        public static readonly Color AlternateBackColor2 = Color.AliceBlue;

        #endregion

    //---------------------------------------------------------------------------------------------



    // Enum Types

        public enum IconType
        {
            iAsterisk, iError, iExclamation, iHand, iInformation, iNone, iQuestion, iStop, iWarning
        }

        public string getSearchValue(string SearchKey)
        {
            string pValue = clsFunctions.sDash;
            int i = 0;

            while (clsArray.SearchKey.Length > i)
            {
                if (SearchKey.ToUpper().Equals(clsArray.SearchKey[i].ToUpper()))
                {
                    pValue = clsArray.SearchValue[i];
                    break;
                }
                i++;
            }

            return pValue;
        }

    // MESSAGE BOX

        public static void setMessageBox(string sMessage, string sTitle, IconType iIcon)
        {
            switch (iIcon)
            {
                case IconType.iAsterisk:
                    MessageBox.Show(sMessage, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    break;
                case IconType.iError:
                    MessageBox.Show(sMessage, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
                case IconType.iExclamation:
                    MessageBox.Show(sMessage, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    break;
                case IconType.iHand:
                    MessageBox.Show(sMessage, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    break;
                case IconType.iInformation:
                    MessageBox.Show(sMessage, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    break;
                case IconType.iNone:
                    MessageBox.Show(sMessage, sTitle, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    break;
                case IconType.iQuestion:
                    MessageBox.Show(sMessage, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    break;
                case IconType.iWarning:
                    MessageBox.Show(sMessage, sTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    break;

            }
        }

    // RESPONSE & REQUEST

        public static string getRequestTime(string sFunction)
        {
            DateTime ProcessDateTime = DateTime.Now;
            string sProcessDateTime = "";

            sProcessDateTime = ProcessDateTime.ToString("yyyy-MM-dd H:mm:ss");

            Debug.WriteLine("Request Time " + "[" + sFunction + "]" + ":" + sProcessDateTime);

            return sProcessDateTime;
        }

        public static string getResponseTime(string sFunction)
        {
            DateTime ProcessDateTime = DateTime.Now;
            string sProcessDateTime = "";

            sProcessDateTime = ProcessDateTime.ToString("yyyy-MM-dd H:mm:ss");

            Debug.WriteLine("Response Time " + "[" + sFunction + "]" + ":" + sProcessDateTime);

            return sProcessDateTime;
        }

    // ADD BRACKETS

        public string AddBracketStartEnd(string pString)
        {
            string pOutput = "";

            pOutput = "[" + pString + "]";

            return pOutput;
        }

        public string AddBracesStartEnd(string pString)
        {
            string pOutput = "";

            pOutput = "{" + pString + "}";

            return pOutput;
        }

    // CONFIRMATION

        public bool SavingConfirm(bool fUpdate, string pForm)
        {
            bool fConfirm = true;

            if (MessageBox.Show("Are you sure you want to " + (fUpdate == true ? "Update" : "Save") + " " + "Record?" +
                                    "\n\n",
                                    (fUpdate ? "Warning" : "Information") + " - " + pForm, MessageBoxButtons.YesNo,
                                    (fUpdate ? MessageBoxIcon.Warning : MessageBoxIcon.Question),
                                    MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                fConfirm = false;
            }

            return fConfirm;
        }

    // ADD VALUES

        public static int AddLabelValues(Label Obj1, Label Obj2)
        {
            int result = (
                           int.Parse(Obj1.Text.ToString()) +
                           int.Parse(Obj2.Text.ToString())
                         );

            return result;
        }

        public static double getPercent(double Result, double DataSize)
        {
            var percentage = (Result / DataSize) * 100;

            return percentage;
        }

    // DATABIND

        public void setDataBind(DataGridView Obj, TextBox Tbx)
        {
            if (Tbx.TextLength > 0)
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

                try
                {
                    getDataBind(Obj, getExcelWorkSheetName(Tbx.Text), Tbx.Text);
                }
                catch (Exception e)
                {
                    setMessageBox(e.Message, "Activity Report System", clsFunctions.IconType.iError);
                }

                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }

        }

        private void getDataBind(DataGridView Obj, string sSheetName, string PathFileName)
        {
            Debug.WriteLine("--- DataBind\n");

            string pathName = PathFileName;
            DataTable Dt = new DataTable();

            string sConn = string.Empty;
            string sQuery = string.Empty;
            string sheetName = sSheetName;

            //Debug.WriteLine("--DataBind--");
            Debug.WriteLine("Sheet Name = " + sSheetName);
            Debug.WriteLine("Path File Name = " + PathFileName);

            ClearGridRows(Obj);

            try
            {
                FileInfo file = new FileInfo(PathFileName);
                if (!file.Exists) { throw new Exception("Error, File doesn't Exists!"); }
                string extension = file.Extension;

                switch (extension.ToLower())
                {
                    case ".xls":
                        sConn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + pathName + "; Extended Properties = 'Excel 12.0; HDR = Yes; IMEX = 1;'";
                        break;
                    case ".xlsx":
                        sConn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + pathName + "; Extended Properties = 'Excel 12.0; HDR = Yes; IMEX = 1;'";
                        break;
                    default:
                        sConn = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pathName + "; Extended Properties = 'Excel 8.0; HDR = Yes; IMEX = 1;'";
                        break;
                }

                sQuery = string.Format("Select * from [{0}$]", sheetName);

                Debug.WriteLine("String Conn = " + sConn);
                Debug.WriteLine("Query = " + sQuery);

                OleDbConnection cnnxls  = new OleDbConnection(sConn);
                OleDbDataAdapter Oda    = new OleDbDataAdapter(sQuery, cnnxls);

                Oda.Fill(Dt);
                Obj.DataSource = Dt;

                Dt.Dispose();
                cnnxls.Dispose();
                Oda.Dispose();

                file = null;
                Obj  = null;

            }
            catch (Exception ex)
            {
                setMessageBox(ex.Message, "Import Data Failed", clsFunctions.IconType.iError);
            }

        }

        public string getExcelWorkSheetName(string pFilePath) {

            Debug.WriteLine("\n--- Get Excel Work Sheetname");

            string sWorkSheetName = string.Empty;

            // CREATE EXCEL WORKSHEET
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(pFilePath);
            Worksheet worksheet = workbook.Worksheets[0];

            sWorkSheetName = worksheet.Name;

            if (sWorkSheetName.Length <= 0)
                sWorkSheetName = "Sheet1";

            workbook.Dispose();
            worksheet.Dispose();

            return sWorkSheetName;
        }

        public string CheckDate(string sValue)
        {

            string TempDate = string.Empty;
            var cultureInfo = new CultureInfo("en-US");
            DateTime xTempDate;
            bool isDateTime = false;


            isDateTime = DateTime.TryParse(sValue, cultureInfo, DateTimeStyles.NoCurrentDateDefault, out xTempDate);

            if(!isDateTime)
            {
                TempDate = sValue;
                return TempDate;
            }

            TempDate = xTempDate.ToString(sDateTimeFormat);
            return TempDate;
        }

    }


    public class clsStyle : clsGrid
    {
    
    // REMOVES FLICKERING & LAG IN CONTROLS

        public void setDoubleBuffer(Control ctl, bool DoubleBuffered)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, ctl, new object[] { DoubleBuffered });
        }

        public void LocationHighlight(object Sender, Panel obj)
        {
            if (!obj.Visible)
            {
                obj.Visible = true;
            }

            Button btn = (Button)Sender;
            obj.Location = new Point(btn.Location.X + 12, btn.Location.Y + 30);
            obj.BringToFront();

        }

        public void BorderShadow(PaintEventArgs e, Panel Obj, int Left, int Top, int Right, int Bottom)
        {
            try
            {
                ControlPaint.DrawBorder(e.Graphics, Obj.ClientRectangle,
                Color.FromArgb(189, 195, 199), Left, ButtonBorderStyle.Solid,   // LEFT
                Color.FromArgb(189, 195, 199), Top, ButtonBorderStyle.Solid,    // TOP
                Color.FromArgb(189, 195, 199), Right, ButtonBorderStyle.Solid,  // RIGHT
                Color.FromArgb(189, 195, 199), Bottom, ButtonBorderStyle.Solid);// BOTTOM
            }
            finally
            {
                e.Dispose();
            }
        }

        public void ListItemsAlterBackColor(ListView lv)
        {
            lv.BeginUpdate();

            for (int x = 0; x < lv.Items.Count; ++x)
            {
                var item = lv.Items[x];
                item.BackColor = (x % 2 == 0) ? Color.LightSteelBlue : Color.Empty;
            }

            lv.EndUpdate();
        }

        public void RowsColorChange(DataGridView Obj)
        {
            for (int i = 0; i < Obj.Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                    Obj.Rows[i].DefaultCellStyle.BackColor = clsFunctions.AlternateBackColor1;
                else
                    Obj.Rows[i].DefaultCellStyle.BackColor = clsFunctions.AlternateBackColor2;

                Obj.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

    // EFFECTS

        public void FadeIn(Form Frms, Timer Timer)
        {

            if (Frms.Opacity == 1)
            {
                Timer.Stop();
            }

            Frms.Opacity += .2;
        }

        public void FadeOut(Form Frms, Timer Timer)
        {

            if (Frms.Opacity <= 0)
            {
                Frms.Close();
            }

            Frms.Opacity -= .2;
        }

    }


    public class clsGrid : clsCharts
    {

        public int setGridCellValue(DataGridView Obj, int rowNum1, int cellNum1)
        {
            int result = (int.Parse(Obj.Rows[rowNum1].Cells[cellNum1].Value.ToString()));
            return result;
        }

        public void ClearDataGrid(DataGridView Obj)
        {
            if (Obj.RowCount > 0)
            {
                if (Obj.DataSource != null)
                {
                    Obj.DataSource = null;
                    Obj.Rows.Clear();
                }
                else
                {
                    Obj.Rows.Clear();
                }
                Obj.Refresh();
            }

            Obj.Rows.Clear();
            Obj.ColumnCount = 0;
            Obj.RowCount = 0;
            Obj = null;
        }

        public void ClearGridRows(DataGridView Obj)
        {
            if (Obj.RowCount > 0)
            {
                if (Obj.DataSource != null)
                {
                    Obj.DataSource = null;
                    Obj.Rows.Clear();
                }
                else
                {
                    Obj.Rows.Clear();
                }

                Obj.Refresh();
            }

            Obj.Rows.Clear();
            Obj.RowCount = 0;
            Obj = null;
        }

        public void setGridAlterBackColor(DataGridView Obj)
        {
            for (int i = 0; i < Obj.Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                    Obj.Rows[i].DefaultCellStyle.BackColor = clsFunctions.AlternateBackColor1;
                else
                    Obj.Rows[i].DefaultCellStyle.BackColor = clsFunctions.AlternateBackColor2;

                Obj.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        public string getGridHeaderList(DataGridView Obj)
        {
            string sOutput = string.Empty;
            string sTemp = string.Empty;

            for (int i = 0; i < Obj.ColumnCount; i++)
            {
                sTemp += Obj.Columns[i].Name + "," + Environment.NewLine;
            }
            sOutput = sTemp;

            Debug.WriteLine("\nHeader List, Output = " + Environment.NewLine + sOutput);
            return sOutput;

        }

        public string getGridSelectedRow(DataGridView Obj, int Rows)
        {
            int iLineNo = 0;
            string sTemp = "";
            int iColCount = Obj.Columns.Count;

            if (Obj.Rows.Count > 0)
            {
                List<string> SearchKeyCol = new List<String>();
                List<string> SearchValueCol = new List<String>();

                Rows = Obj.CurrentRow.Index;

                for (int i = 0; i < iColCount; i++)
                {
                    iLineNo++;
                    string pSearchKey = Obj.Columns[i].Name; // Param
                    string pSearchValue = Obj.Rows[Rows].Cells[i].Value.ToString().Trim(); // Value

                    //Debug.WriteLine("-"+pSearchKey+"+");

                    sTemp = sTemp +
                           " [ " + i.ToString() + " ]" +
                           pSearchKey +
                           Environment.NewLine + " { " + pSearchValue + " }" + Environment.NewLine;

                    // Set Search Array
                    SearchKeyCol.Add(pSearchKey);
                    SearchValueCol.Add(pSearchValue);
                }

                clsArray.SearchKey = SearchKeyCol.ToArray();
                clsArray.SearchValue = SearchValueCol.ToArray();

            }

            return sTemp;
        }

        public int getHeader_Col_Index(DataGridView Obj, string Header)
        {
            int iColIndex = 0;

            for (int i = 0; i < Obj.ColumnCount; i++)
            {
                string cellParam = Obj.Columns[i].Name;

                if (Header.CompareTo(cellParam) == 0)
                {
                    iColIndex = i;
                    break;
                }
            }

            return iColIndex;
        }

    // ADD

        public void addGridLineNo(object sender, DataGridViewRowPostPaintEventArgs e, Font font)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerformat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, font, SystemBrushes.ControlText, headerBounds, centerformat);
        }

        public int addGridValues(DataGridView Obj1, int rowNum1, int cellNum1, DataGridView Obj2, int rowNum2, int cellNum2)
        {
            int result = (
                           int.Parse(Obj1.Rows[rowNum1].Cells[cellNum1].Value.ToString()) +
                           int.Parse(Obj2.Rows[rowNum2].Cells[cellNum2].Value.ToString())
                         );

            return result;
        }

        public int addGridCellValues(DataGridView Obj1, int rowNum1, int cellNum1, DataGridView Obj2, int rowNum2, int cellNum2)
        {
            int result = (
                           int.Parse(Obj1.Rows[rowNum1].Cells[cellNum1].Value.ToString()) +
                           int.Parse(Obj2.Rows[rowNum2].Cells[cellNum2].Value.ToString())
                         );

            return result;
        }

    }


    public class clsCharts
    {
        public void setChartGridValue(System.Windows.Forms.DataVisualization.Charting.Chart Chart, int Series, string Title, DataGridView Obj, int rowNum, int cellNum)
        {
            int result = int.Parse(Obj.Rows[rowNum].Cells[cellNum].Value.ToString());
            Chart.Series[Series].Points.AddXY(Title, result);
        }

        public void setChartValue(System.Windows.Forms.DataVisualization.Charting.Chart Chart, int Series, string Title, int Val)
        {
            int result;
            result = Val;
            Chart.Series[Series].Points.AddXY(Title, result);
        }

        public void ClearCharts(System.Windows.Forms.DataVisualization.Charting.Chart Obj, int Series)
        {
            Obj.Series[Series].Points.Clear();
        }

    }

}
