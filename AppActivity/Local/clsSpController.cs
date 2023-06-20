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

        public DataTable ExecuteAction(eAction Action)
        {

            DataTable resultTable = new DataTable();


            Sp.StatementType = StatementType;
            Sp.SearchBy      = SearchBy;
            Sp.SearchValue   = SearchValue;
            Sp.Sql           = Sql;

            #region Debug Details

            Debug.WriteLine(cFunctions.LineSeperator);
            Debug.WriteLine("EXECUTE QUERY");
            Debug.WriteLine(cFunctions.LineSeperator);
            Debug.WriteLine("Statement Type: " + StatementType);
            Debug.WriteLine("Statement By: "   + SearchBy);

            if (!string.IsNullOrEmpty(SearchValue))
                Debug.WriteLine("SearchValue: " + SearchValue);

            if (!string.IsNullOrEmpty(Sql))
                Debug.WriteLine("SQL: \n" + Sql);

            Debug.WriteLine(cFunctions.LineSeperator);

            #endregion


            switch (Action)
            {
                case eAction.View:
                    resultTable = Sp.CollectionDetails();
                    break;

                case eAction.Modify:
                    Sp.CollectionUpdate();
                    break;

                case eAction.Add:
                    Sp.CollectionInsert();
                    break;

                case eAction.Import:
                    Sp.CollectionImport();
                    break;

                case eAction.Remove:
                    Sp.CollectionDelete();
                    break;

            }

            return resultTable;
        }

    }

}
