using ActivityReportSystem.AppActivity.Local.SpMainActivity;
using ActivityReportSystem.Function;
using ActivityReportSystem.Global;
using MySqlConnector;
using System.Data;
using System.Diagnostics;
using AppAction;

namespace ActivityReportSystem.AppActivity.Controller
{
    class clsSpController
    {
        clsSpModel.MySqlProcedure Sp = new clsSpModel.MySqlProcedure();

        public string StatementType { get; set; }
        public string SearchBy { get; set; }
        public string SearchValue { get; set; }
        public string Sql { get; set; }

        public DataTable ExecuteQuery(Perform Action)
        {
            DataTable resultTable = new DataTable();

            Sp.StatementType = StatementType;
            Sp.SearchBy      = SearchBy;
            Sp.SearchValue   = SearchValue;
            Sp.Sql           = Sql;

            #region Debug Details

            Debug.WriteLine(cFunctions.Format.LineSeperator);
            Debug.WriteLine("EXECUTE QUERY");
            Debug.WriteLine(cFunctions.Format.LineSeperator);
            Debug.WriteLine("Statement Type: " + StatementType);
            Debug.WriteLine("Statement By: "   + SearchBy);

            if (!string.IsNullOrEmpty(SearchValue))
                Debug.WriteLine("SearchValue: " + SearchValue);

            if (!string.IsNullOrEmpty(Sql))
                Debug.WriteLine("SQL: \n" + Sql);

            Debug.WriteLine(cFunctions.Format.LineSeperator);

            #endregion


            switch (Action)
            {
                case Perform.View:
                    resultTable = Sp.CollectionDetails();
                    break;

                case Perform.Update:
                    Sp.CollectionUpdate();
                    break;

                case Perform.Add:
                    Sp.CollectionInsert();
                    break;

                case Perform.Import:
                    Sp.CollectionImport();
                    break;

                case Perform.Remove:
                    Sp.CollectionDelete();
                    break;
            }

            return resultTable;
        }

    }

}
