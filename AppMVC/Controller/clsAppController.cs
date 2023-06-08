using ActivityReportSystem.AppMVC.Model;
using ActivityReportSystem.Function;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityReportSystem.AppMVC.Controller
{
    class clsAppController
    {
        clsAppStoredProc Sp = new clsAppStoredProc();

        public DataTable ExecuteQuery(string StatementType, string StatementBy, string SearchValue, string MaintenanceType, string Sql, Action Action)
        {

         #region Debug Details

            Debug.WriteLine(clsFunctions.LineSeperator);
            Debug.WriteLine("EXECUTE QUERY");
            Debug.WriteLine(clsFunctions.LineSeperator);
            Debug.WriteLine("Statement Type: " + StatementType);
            Debug.WriteLine("Statement By: "   + StatementBy);

            if (!string.IsNullOrEmpty(SearchValue))
                Debug.WriteLine("SearchValue: " + SearchValue);

            if (!string.IsNullOrEmpty(MaintenanceType))
                Debug.WriteLine("Maintenance Type: " + MaintenanceType);

            if (!string.IsNullOrEmpty(Sql))
                Debug.WriteLine("SQL: " + Sql);

            Debug.WriteLine(clsFunctions.LineSeperator);

         #endregion

            DataTable resultTable = new DataTable();

            switch (Action)
            {
                case Action.View:
                    resultTable = Sp.CollectionDetails(StatementType, StatementBy, SearchValue);
                    break;

                case Action.Update:
                    Sp.CollectionUpdate(StatementType, StatementBy, SearchValue, Sql);
                    break;

                case Action.Insert:
                    Sp.CollectionInsert(StatementType, StatementBy, SearchValue, Sql);
                    break;

                case Action.Delete:
                    Sp.CollectionDelete(StatementType, StatementBy, SearchValue);
                    break;

            }

            return resultTable;
        }


        public enum Action
        {
            View,
            Update,
            Insert,
            Delete
        }


    }
}
