using ActivityReportSystem.Function;
using System.Data;

namespace ActivityReportSystem.Global
{
    struct sAppData
    {

        public static int sSQLServerEnable  { get; set; }
        public static int sMySQLEnable      { get; set; }
        public static string TemplateName { get; set; }

        public const string Installation  = "Installation";
        public const string Reprogramming = "Reprogramming";
        public const string Servicing     = "Servicing";
        public const string Repair        = "Repair";
        public const string Inventory     = "Inventory";

        public static string[] Templates = { string.Empty, Installation, Reprogramming, Servicing, Repair };

        public static string ConnectionString { get; set; }
        public static DataTable CountDetails { get; set; }

        public class Database
        {
            public static string sSource { get; set; }
            public static string sServer { get; set; }
            public static string sDatabase { get; set; }
            public static string sUserName { get; set; }
            public static string sPassword { get; set; }
            public static string sSecurity { get; set; } = "False";
            public static string sPort { get; set; }
            public static string sTimeOut { get; set; } = "5000";
            public static string LocalInFile { get; set; }
            public static string sMySQLDatabase { get; set; }
            public static string sSQLServerDatabase { get; set; }

            public static string sSSLMode { get; set; }
            public static string outMessage { get; set; }
            public static int outLastInserted { get; set; }
        }

        public class FilePath
        {
            public const string Csv = "C:\\CASTLESTECH_ARS\\IMPORTS\\";

            public const string Report = @"C:\\CASTLESTECH_ARS\\REPORTS\\";
        }

        public class DataParam
        {
            public static string strLogUsername { get; set; }
            public static string strLogPassword { get; set; }
            public static string strLogUserLevel { get; set; }
            public static string strLogUserId { get; set; }
            public static string MenuControls { get; set; }
        }

        public class Template
        {
            public static string iTotal_Installation { get; set; }

            // Data Size
            public static int InstallSize { get; set; }
            public static int ReprogSize { get; set; }
            public static int ServSize { get; set; }
            public static int RepairSize { get; set; }

            // Total Percentage
            public static double PInstall { get; set; }
            public static double PReprog { get; set; }
            public static double PServ { get; set; }
            public static double PRepair { get; set; }

            // Total Stocks
            public static int iTotal_Com { get; set; }
            public static int iTotal_Pen { get; set; }
            public static int iTotal_Can { get; set; }
            public static int iTotal_Wait { get; set; }
            public static int Total_Stocks { get; set; }

            // Total Installation
            public static int iTotal_comIns { get; set; }
            public static int iTotal_penIns { get; set; }
            public static int iTotal_canIns { get; set; }
            public static int iTotal_waitIns { get; set; }

            // Total Reprogramming
            public static int iTotal_comReprog { get; set; }
            public static int iTotal_penReprog { get; set; }
            public static int iTotal_canReprog { get; set; }
            public static int iTotal_waitReprog { get; set; }

            // Total Servicing
            public static int iTotal_comServ { get; set; }
            public static int iTotal_penServ { get; set; }
            public static int iTotal_canServ { get; set; }
            public static int iTotal_waitServ { get; set; }

            // Total Repair
            public static int iTotal_comRep { get; set; }
            public static int iTotal_penRep { get; set; }
            public static int iTotal_canRep { get; set; }
            public static int iTotal_waitRep { get; set; }

        }
    }
}
