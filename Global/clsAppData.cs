

using ActivityReportSystem.Function;

namespace ActivityReportSystem.Global
{
    struct clsAppData
    {

        public static int sSQLServerEnable  { get; set; }
        public static int sMySQLEnable      { get; set; }
        public static int iDataSize         { get; set; }

        public class DataParam
        {
            public static string sSource { get; set; }
            public static string sServer { get; set; }
            public static string sDatabase { get; set; }
            public static string sUserName { get; set; }
            public static string sPassword { get; set; }
            public static string sSecurity { get; set; } = "False";
            public static string sPort { get; set; }
            public static string sTimeOut { get; set; } = "5000";

            public static string sMySQLDatabase { get; set; }
            public static string sSQLServerDatabase { get; set; }

            public static string sSSLMode { get; set; }
            public static string outMessage { get; set; }
            public static string outLastInserted { get; set; }


            public static string strLogUsername { get; set; }
            public static string strLogPassword { get; set; }
            public static string strLogUserLevel { get; set; }
            public static string strLogUserId { get; set; }
            public static string TempName { get; set; }
            public static string MenuControls { get; set; }

            public static string ConnString { get; set; }

        }

        public class Template
        {
            public static int InstallVolume { get; set; }
            public static int ReprogVolume { get; set; }
            public static int ServVolume { get; set; }
            public static int RepairVolume { get; set; }

            public static double PInstall { get; set; }
            public static double PReprog { get; set; }
            public static double PServ { get; set; }
            public static double PRepair { get; set; }


            public static int inSum_Ttl_Com { get; set; }
            public static int inSum_Ttl_Pen { get; set; }
            public static int inSum_Ttl_Can { get; set; }
            public static int Total_Stocks { get; set; }


            public static int inSum_Ttl_comIns { get; set; }
            public static int inSum_Ttl_penIns { get; set; }
            public static int inSum_Ttl_canIns { get; set; }

            public static int inSum_Ttl_comReprog { get; set; }
            public static int inSum_Ttl_penReprog { get; set; }
            public static int inSum_Ttl_canReprog { get; set; }

            public static int inSum_Ttl_comServ { get; set; }
            public static int inSum_Ttl_penServ { get; set; }
            public static int inSum_Ttl_canServ { get; set; }

            public static int inSum_Ttl_comRep { get; set; }
            public static int inSum_Ttl_penRep { get; set; }
            public static int inSum_Ttl_canRep { get; set; }

            public static int inMp200_Ttl_Stock { get; set; }
            public static int inMp200_Ttl_comIns { get; set; }
            public static int inMp200_Ttl_comReprog { get; set; }
            public static int inMp200_Ttl_comServ { get; set; }
            public static int inMp200_Ttl_comRepair { get; set; }

            public static int inMp200_Ttl_penIns { get; set; }
            public static int inMp200_Ttl_penReprog { get; set; }
            public static int inMp200_Ttl_penServ { get; set; }
            public static int inMp200_Ttl_penRepair { get; set; }

            public static int inMp200_Ttl_canIns { get; set; }
            public static int inMp200_Ttl_canReprog { get; set; }
            public static int inMp200_Ttl_canServ { get; set; }
            public static int inMp200_Ttl_canRepair { get; set; }

            public static int inS1E_Ttl_Stock { get; set; }
            public static int inS1E_Ttl_comIns { get; set; }
            public static int inS1E_Ttl_comReprog { get; set; }
            public static int inS1E_Ttl_comServ { get; set; }
            public static int inS1E_Ttl_comRepair { get; set; }

            public static int inS1E_Ttl_penIns { get; set; }
            public static int inS1E_Ttl_penReprog { get; set; }
            public static int inS1E_Ttl_penServ { get; set; }
            public static int inS1E_Ttl_penRepair { get; set; }

            public static int inS1E_Ttl_canIns { get; set; }
            public static int inS1E_Ttl_canReprog { get; set; }
            public static int inS1E_Ttl_canServ { get; set; }
            public static int inS1E_Ttl_canRepair { get; set; }
        }
    }



}
