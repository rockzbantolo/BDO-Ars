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
using System.Text;
using System.Linq;

namespace AppAction
{
    public enum eAction
    {
        View,
        Modify,
        Add,
        Import,
        Remove
    }
}

namespace ActivityReportSystem.Function
{
    public class cFunctions
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
        public const string LineSeperator = "====================================================";

        #region Colors

        public static readonly Color EntryBackColor      = Color.White;
        public static readonly Color DisableBackColor    = Color.FromArgb(224, 224, 224);
        public static readonly Color ListViewBackColor   = Color.Azure;
        public static readonly Color GridViewBackColor   = Color.Azure;
        public static readonly Color DateBackColor       = Color.Lavender;
        public static readonly Color AlternateBackColor1 = Color.Snow;
        public static readonly Color AlternateBackColor2 = Color.AliceBlue;

        #endregion

        public static string getSearchValue(string SearchKey)
        {
            string pValue = cFunctions.sDash;
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
        public static string AddBracketStartEnd(string pString)
        {
            string pOutput = "";

            pOutput = "[" + pString + "]";

            return pOutput;
        }

        public static string AddBracesStartEnd(string pString)
        {
            string pOutput = "";

            pOutput = "{" + pString + "}";

            return pOutput;
        }

        // CONFIRMATION
        public static bool SavingConfirm(bool fUpdate, string pForm)
        {
            string action = fUpdate ? "Update" : "Save";
            string title = fUpdate ? "Warning" : "Information";
            string message = $"Are you sure you want to {action} Record?\n\n";

            DialogResult result = MessageBox.Show(message, $"{title} - {pForm}", MessageBoxButtons.YesNo,
                fUpdate ? MessageBoxIcon.Warning : MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            return result == DialogResult.Yes;
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
        public static void SetDataBind(DataGridView obj, TextBox tbx)
        {
            if (string.IsNullOrEmpty(tbx.Text)) return;

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            try
            {
                GetDataBind(obj, GetExcelWorkSheetName(tbx.Text), tbx.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Activity Report System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.Windows.Forms.Cursor.Current = Cursors.Default;

        }

        private static void GetDataBind(DataGridView obj, string sheetName, string pathFileName)
        {
            Debug.WriteLine("-- DataBind\n");

            string pathName = pathFileName;

            Debug.WriteLine(" Sheet Name: " + sheetName);
            Debug.WriteLine(" Path File Name: " + pathFileName);

            obj.Rows.Clear();

            try
            {
                FileInfo file = new FileInfo(pathFileName);
                if (!file.Exists)
                {
                    throw new Exception("Error, File doesn't Exist!");
                }

                string extension = file.Extension;
                string connectionStr;

                switch (extension.ToLower())
                {
                    case ".xls":
                    case ".xlsx":
                        connectionStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + pathName + "; Extended Properties = 'Excel 12.0; HDR = Yes; IMEX = 1;'";
                        break;
                    default:
                        connectionStr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pathName + "; Extended Properties = 'Excel 8.0; HDR = Yes; IMEX = 1;'";
                        break;
                }

                string query = string.Format("Select * from [{0}$]", sheetName);

                Debug.WriteLine("Connection String = " + connectionStr);
                Debug.WriteLine("Query = " + query);

                using (OleDbConnection connection = new OleDbConnection(connectionStr))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        obj.DataSource = dataTable;
                    }
                }

                file = null;
                obj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Import Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetExcelWorkSheetName(string filePath)
        {
            Debug.WriteLine("\n--- Get Excel Worksheet Name");

            string worksheetName = string.Empty;

            try
            {
                using (Workbook workbook = new Workbook())
                {
                    workbook.LoadFromFile(filePath);
                    Worksheet worksheet = workbook.Worksheets[0];

                    worksheetName = worksheet.Name;

                    if (string.IsNullOrEmpty(worksheetName))
                        worksheetName = "Sheet1";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }

            return worksheetName;
        }


        public static string CheckDate(string sValue)
        {
            if (DateTime.TryParse(sValue, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate.ToString(sDateTimeFormat);
            }

            return sValue;
        }

        // EXPORT to CSV
        public static string ExportToCSV(DataGridView obj, string fileName)
        {
            string path = string.Concat(sAppData.FilePath.Csv, "im_", fileName, "_", DateTime.Now.ToString("MMddyy"), ".csv");

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, false, Encoding.UTF8))
                {
                    // Write the column headers to the CSV file
                    string headers = string.Join(",", obj.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText.Replace(",", string.Empty)));
                    file.WriteLine(headers);

                    // Write the data rows to the CSV file
                    foreach (DataGridViewRow row in obj.Rows)
                    {
                        string rowData = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell =>
                        {
                            // Check for DBNull values and replace them with an appropriate default value
                            if (cell.Value == DBNull.Value || string.IsNullOrWhiteSpace(Convert.ToString(cell.Value)) || string.IsNullOrEmpty(Convert.ToString(cell.Value)))
                            {
                                return "-";
                            }
                            else
                            {
                                // Replace specific strings and special characters
                                string cellValue = Convert.ToString(cell.Value)
                                    .Replace("ñ", "n")
                                    .Replace("Ñ", "N")
                                    .Replace(" ", string.Empty)
                                    .Replace(",", string.Empty)
                                    .Replace("'", string.Empty)
                                    .Replace("#NAME?", "-")
                                    .Replace("#VALUE!", "-")
                                    .Replace("\"", string.Empty);

                                return cellValue;
                            }
                        }));

                        file.WriteLine(rowData);
                    }
                }

                Debug.WriteLine("----- Data exported to CSV file successfully. -----");
                return path; // Return the file path
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data to CSV file: " + ex.Message);
                return null; // Return null if an error occurs
            }
        }

        public string ConvertExcelToCsv(string excelFilePath, string csvFilePath)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(excelFilePath);
            Worksheet worksheet = workbook.Worksheets[0]; // Assuming you want to convert the first worksheet

            using (StreamWriter streamWriter = new StreamWriter(csvFilePath))
            {
                for (int row = 1; row <= worksheet.LastRow; row++)
                {
                    List<string> rowData = new List<string>();
                    for (int col = 1; col <= worksheet.LastColumn; col++)
                    {
                        CellRange cell = worksheet.Range[row, col];
                        string cellData = cell != null ? cell.Value?.ToString() : "";

                        cellData = string.IsNullOrWhiteSpace(cellData) ? "-" : ValidateData(cellData);

                        cellData = (cellData == DBNull.Value.ToString()) ? "-" : cellData;

                        if (cellData.Contains(",") || cellData.Contains("\""))
                        {
                            cellData = cellData.Replace("\"", "\"\""); // Escape double quotes by doubling them
                            cellData = $"\"{cellData}\""; // Quote the value
                        }

                        rowData.Add(cellData);
                    }

                    streamWriter.WriteLine(string.Join(",", rowData));
                }
            }

            return csvFilePath;
        }

        public static string ValidateData(string input)
        {
            input = input.Replace("ñ", "n")
                         .Replace("Ñ", "N")
                         .Replace("\t", "")
                         .Replace("\n", "")
                         .Replace("\r", "")
                         .Replace(" ", "")
                         .Replace(",", "")
                         .Replace(" ", "")
                         .Replace("'", "");

            if (DateTime.TryParse(input, out DateTime tempDate))
            {
                input = tempDate.ToString(cFunctions.sDateTimeFormat);
            }

            return input;
        }



        public class Effects
        {

            // REMOVES FLICKERING & LAG IN CONTROLS
            public static void setDoubleBuffer(Control ctl, bool DoubleBuffered)
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctl, new object[] { DoubleBuffered });
            }

            public static void LocationHighlight(object Sender, Panel obj)
            {
                if (!obj.Visible)
                {
                    obj.Visible = true;
                }

                Button btn = (Button)Sender;
                obj.Location = new Point(btn.Location.X + 12, btn.Location.Y + 30);
                obj.BringToFront();

            }

            public static void BorderShadow(PaintEventArgs e, Panel Obj, int Left, int Top, int Right, int Bottom)
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

            public static void ListItemsAlterBackColor(ListView lv)
            {
                lv.BeginUpdate();

                for (int x = 0; x < lv.Items.Count; ++x)
                {
                    var item = lv.Items[x];
                    item.BackColor = (x % 2 == 0) ? Color.LightSteelBlue : Color.Empty;
                }

                lv.EndUpdate();
            }

            public static void RowsColorChange(DataGridView Obj)
            {
                for (int i = 0; i < Obj.Rows.Count - 1; i++)
                {
                    if (i % 2 == 0)
                        Obj.Rows[i].DefaultCellStyle.BackColor = cFunctions.AlternateBackColor1;
                    else
                        Obj.Rows[i].DefaultCellStyle.BackColor = cFunctions.AlternateBackColor2;

                    Obj.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            // EFFECTS
            public static void FadeIn(Form Frms, Timer Timer)
            {

                if (Frms.Opacity == 1)
                {
                    Timer.Stop();
                }

                Frms.Opacity += .2;
            }

            public static void FadeOut(Form Frms, Timer Timer)
            {

                if (Frms.Opacity <= 0)
                {
                    Frms.Close();
                }

                Frms.Opacity -= .2;
            }

        }


        public class Grid
        {

            public int setGridCellValue(DataGridView Obj, int rowNum1, int cellNum1)
            {
                int result = (int.Parse(Obj.Rows[rowNum1].Cells[cellNum1].Value.ToString()));
                return result;
            }

            public static void ClearDataGrid(DataGridView Obj)
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

            public static void ClearGridRows(DataGridView Obj)
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

            public static void SetGridAlterBackColor(DataGridView obj)
            {
                for (int i = 0; i < obj.Rows.Count; i++)
                {
                    obj.Rows[i].DefaultCellStyle.BackColor = (i % 2 == 0) ? cFunctions.AlternateBackColor1 : cFunctions.AlternateBackColor2;
                    obj.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            public static string GetGridHeaderList(DataGridView obj)
            {
                StringBuilder sb = new StringBuilder();

                foreach (DataGridViewColumn column in obj.Columns)
                {
                    sb.AppendLine(column.Name);
                }

                string output = sb.ToString();
                Debug.WriteLine("\nHeader List, Output = \n" + output);
                return output;
            }

            public static string getGridSelectedRow(DataGridView Obj, int Rows)
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

            public static int getHeader_Col_Index(DataGridView Obj, string Header)
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

            public static void addGridLineNo(object sender, DataGridViewRowPostPaintEventArgs e, Font font)
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

            public static int addGridValues(DataGridView Obj1, int rowNum1, int cellNum1, DataGridView Obj2, int rowNum2, int cellNum2)
            {
                int result = (
                               int.Parse(Obj1.Rows[rowNum1].Cells[cellNum1].Value.ToString()) +
                               int.Parse(Obj2.Rows[rowNum2].Cells[cellNum2].Value.ToString())
                             );

                return result;
            }

            public static int addGridCellValues(DataGridView Obj1, int rowNum1, int cellNum1, DataGridView Obj2, int rowNum2, int cellNum2)
            {
                int result = (
                               int.Parse(Obj1.Rows[rowNum1].Cells[cellNum1].Value.ToString()) +
                               int.Parse(Obj2.Rows[rowNum2].Cells[cellNum2].Value.ToString())
                             );

                return result;
            }

        }


        public class Charts
        {
            public static void setChartGridValue(System.Windows.Forms.DataVisualization.Charting.Chart Chart, int Series, string Title, DataGridView Obj, int rowNum, int cellNum)
            {
                int result = int.Parse(Obj.Rows[rowNum].Cells[cellNum].Value.ToString());
                Chart.Series[Series].Points.AddXY(Title, result);
            }

            public static void setChartValue(System.Windows.Forms.DataVisualization.Charting.Chart Chart, int Series, string Title, int Val)
            {
                int result;
                result = Val;
                Chart.Series[Series].Points.AddXY(Title, result);
            }

            public static void ClearCharts(System.Windows.Forms.DataVisualization.Charting.Chart Obj, int Series)
            {
                Obj.Series[Series].Points.Clear();
            }

        }

    }



}
