using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ActivityReportSystem.Global;
using System.Text;
using System.Runtime.InteropServices;
using ActivityReportSystem.Function;

namespace ActivityReportSystem.Database
{
    public class cAppConfig : cSettings
    {
        public cAppConfig()
        {
            MySqlSettings();
            SystemSettings();

            #region Debug Database Details
            Debug.WriteLine(cFunctions.Format.LineSeperator);
            Debug.WriteLine("DATABASE INFORMATION");
            Debug.WriteLine(cFunctions.Format.LineSeperator);
            Debug.WriteLine(string.Concat("Persist Security Info: ", sAppData.Database.sSecurity, "; "));
            Debug.WriteLine(string.Concat("Server: ", sAppData.Database.sServer, "; "));
            Debug.WriteLine(string.Concat("Port: ", sAppData.Database.sPort, "; "));
            Debug.WriteLine(string.Concat("Database: ", sAppData.Database.sDatabase, "; "));
            Debug.WriteLine(string.Concat("Username: ", sAppData.Database.sUserName, "; "));
            Debug.WriteLine(string.Concat("Password: ", sAppData.Database.sPassword, "; "));
            Debug.WriteLine(string.Concat("Local File : ", sAppData.Database.LocalInFile, ";"));
            Debug.WriteLine(string.Concat("Connection Timeout: ", sAppData.Database.sTimeOut, ";"));
            Debug.WriteLine(cFunctions.Format.LineSeperator + "\n");
            #endregion
        }

    }

    public class cSettings
    {

    #region LIBRARY

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

    #endregion

        private string filePath { get; set; }

        private void IniFile(string sfilePath) {

            filePath = sfilePath;
        }

        private string Read(string section, string key) {

            StringBuilder Sb = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", Sb, 255, filePath);
            return Sb.ToString();
        }

        private long Write(string section, string key, string value) {

            long i = WritePrivateProfileString(section, key, value, filePath);
            return i;
        }

        private string FilePath {

            get { return filePath; }
            set { filePath = value; }
        }

        #region List Of Connections

        // READ

        public void MySqlSettings() {

            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "DatabaseSetting.ini";
            FullPath = "C:\\CASTLESTECH_ARS\\SETTINGS\\" + FileName;
            this.IniFile(FullPath);

            sAppData.Database.sSecurity   = this.Read("_Security", "Security");
            sAppData.Database.sServer     = this.Read("_Server", "Server");
            sAppData.Database.sPort       = this.Read("_Port", "Port");
            sAppData.Database.sDatabase   = this.Read("_Database", "Database");
            sAppData.Database.sUserName   = this.Read("_UserName", "UserName");
            sAppData.Database.sPassword   = this.Read("_Password", "Password");
            sAppData.Database.sSSLMode    = this.Read("_SSLMode", "SSLMode");
            sAppData.Database.LocalInFile = this.Read("_AllowLoadLocalInfile", "AllowLoadLocalInfile");
            sAppData.Database.sTimeOut    = "5000";

            sAppData.ConnectionString = string.Concat("PERSIST SECURITY INFO = ", sAppData.Database.sSecurity, "; ",
                                        "SERVER = ", sAppData.Database.sServer, "; ",
                                        "PORT = ", sAppData.Database.sPort, "; ",
                                        "DATABASE = ", sAppData.Database.sDatabase, "; ",
                                        "UID = ", sAppData.Database.sUserName, "; ",
                                        "PASSWORD = ", sAppData.Database.sPassword, "; ",
                                        "SSL MODE = ", sAppData.Database.sSSLMode, "; ",
                                        "AllowLoadLocalInfile = ", sAppData.Database.LocalInFile, ";",
                                        "CONNECT TIMEOUT = ", sAppData.Database.sTimeOut, ";");

        }

        public void ApiSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "APISetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //cVariables.strAPIURL            = this.Read("_APIURL", "APIURL");
            //cVariables.strAPIPath           = this.Read("_APIPath", "APIPath");
            //cVariables.strAPIKeys           = this.Read("_APIKeys", "APIKeys");
            //cVariables.strAPIContentType    = this.Read("_APIContentType", "APIContentType");
            //cVariables.strAPIAuthUser       = this.Read("_APIAuthUser", "APIAuthUser");
            //cVariables.strAPIAuthPassword   = this.Read("_APIAuthPassword", "APIAuthPassword");
            //cVariables.strAPIDashboardURL   = this.Read("_APIDashboardPath", "APIDashboardPath");
            //cVariables.strAPIServerIPAddress = this.Read("_APIIPAddress", "APIIPAddress");
            //cVariables.strAPIImagesPath     = this.Read("_APIImagesPath", "APIImagesPath");
            //cVariables.strAPISSLEnable      = int.Parse(this.Read("_APISSLEnable", "APISSLEnable"));

            // Split IP And Port
            //string[] sIPPort = cVariables.strAPIURL.Split(':');
            //int iCount = sIPPort.Length;

            //for (int x = 0; x < iCount; x++)
            //{
            //    switch (x)
            //    {
            //        case 0:
            //            cVariables.strAPIServerIP = sIPPort[0].ToString();
            //            break;
            //        case 1:
            //            cVariables.strAPIServerPort = sIPPort[1].ToString();
            //            break;
            //    }
            //}

        }

        public void SystemSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "SystemSetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //clsSystemSetting.ClassSystemSplashInterval      = int.Parse(this.Read("_SplashInterval", "SplashInterval"));
            //clsSystemSetting.ClassSystemSplashTimeOut       = int.Parse(this.Read("_SplashTimeOut", "SplashTimeOut"));
            //clsSystemSetting.ClassSystemCheckNetLink        = int.Parse(this.Read("_CheckNetLink", "CheckNetLink"));
            //clsSystemSetting.ClassSystemNetLink             = this.Read("_NetLink", "NetLink");
            //clsSystemSetting.ClassSystemCheckIPAddress      = int.Parse(this.Read("_CheckIPAddress", "CheckIPAddress"));
            //clsSystemSetting.ClassSystemIPAddress           = this.Read("_IPAddress", "IPAddress");
            //clsSystemSetting.ClassSystemConnectionType      = this.Read("_ConnectionType", "ConnectionType");
            //clsSystemSetting.ClassSystemPromptAPIRequest    = int.Parse(this.Read("_PromptAPIRequest", "PromptAPIRequest"));
            //clsSystemSetting.ClassSystemPromptAPIResponse   = int.Parse(this.Read("_PromptAPIResponse", "PromptAPIResponse"));
            //clsSystemSetting.ClassSystemLogInCheck          = int.Parse(this.Read("_LogInCheck", "LogInCheck"));
            //clsSystemSetting.ClassSystemImportCheck         = int.Parse(this.Read("_ImportCheck", "ImportCheck"));
            //clsSystemSetting.ClassSystemMSOffice            = this.Read("_MSOffice", "MSOffice");
            //clsSystemSetting.ClassSystemShowTaskBar         = int.Parse(this.Read("_ShowTaskBar", "ShowTaskBar"));
            //clsSystemSetting.ClassSystemExntededMonitor     = int.Parse(this.Read("_ExntededMonitor", "ExntededMonitor"));
            //clsSystemSetting.ClassSystemAutoPulse           = int.Parse(this.Read("_AutoPulse", "AutoPulse"));
            //clsSystemSetting.ClassSystemPulseInterval       = int.Parse(this.Read("_PulseInterval", "PulseInterval"));
            //clsSystemSetting.ClassSystemAutoCheckServer     = int.Parse(this.Read("_AutoCheckServer", "AutoCheckServer"));
            //clsSystemSetting.ClassSystemCheckServerInterval = int.Parse(this.Read("_CheckServerInterval", "CheckServerInterval"));
            //clsSystemSetting.ClassSystemReaderInterval      = int.Parse(this.Read("_ReaderInterval", "ReaderInterval"));
            //clsSystemSetting.ClassSystemReaderTimeOut       = int.Parse(this.Read("_ReaderTimeOut", "ReaderTimeOut"));
            //clsSystemSetting.ClassSystemSerialNoMaxLength   = int.Parse(this.Read("_SerialNoMaxLength", "SerialNoMaxLength"));
            //clsSystemSetting.ClassSystemSkinColor           = this.Read("_SkinColor", "SkinColor");
            //clsSystemSetting.ClassSystemImportIRFieldCheck  = this.Read("_ImportIRFieldCheck", "ImportIRFieldCheck");
            //clsSystemSetting.ClassSystemImportTerminalFieldCheck = this.Read("_ImportTerminalFieldCheck", "ImportTerminalFieldCheck");
            //clsSystemSetting.ClassSystemImportSIMFieldCheck = this.Read("_ImportSIMFieldCheck", "ImportSIMFieldCheck");
            //clsSystemSetting.ClassSystemImportFSRFieldCheck = this.Read("_ImportFSRFieldCheck", "ImportFSRFieldCheck");
            //clsSystemSetting.ClassSystemCheckServiceRequest = int.Parse(this.Read("_CheckServiceRequest", "CheckServiceRequest"));
            //clsSystemSetting.ClassSystemDeveloperMode       = int.Parse(this.Read("_DeveloperMode", "DeveloperMode"));
            //clsSystemSetting.ClassSystemPageLimit           = int.Parse(this.Read("_PageLimit", "PageLimit"));
            //clsSystemSetting.ClassSystemNoOfDayPending      = int.Parse(this.Read("_NoOfDayPending", "NoOfDayPending"));
            //clsSystemSetting.ClassSystemRecordMinLimit      = int.Parse(this.Read("_RecordMinLimit", "RecordMinLimit"));
            //clsSystemSetting.ClassGenerateResponseFile      = int.Parse(this.Read("_GenerateResponseFile", "GenerateResponseFile"));
            //clsSystemSetting.ClassApplicationName           = this.Read("_ApplicationName", "ApplicationName");
            //clsSystemSetting.ClassCompanyName               = this.Read("_CompanyName", "CompanyName");
            //clsSystemSetting.ClassCompanyAddress            = this.Read("_CompanyAddress", "CompanyAddress");
            //clsSystemSetting.ClassProviderName              = this.Read("_ProviderName", "ProviderName");
        }

        public void ODBCSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "ODBCSetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //clsODBC.ClassODBCServerName     = this.Read("_ServerName", "ServerName");
            //clsODBC.ClassODBCDSNName        = this.Read("_DSNName", "DSNName");
            //clsODBC.ClassODBCDriverName     = this.Read("_DriverName", "DriverName");
            //clsODBC.ClassODBCDatabaseName   = this.Read("_DatabaseName", "DatabaseName");
            //clsODBC.ClassODBCDescription    = this.Read("_Description", "Description");
            //clsODBC.ClassODBCUser           = this.Read("_User", "User");
            //clsODBC.ClassODBCPassword       = this.Read("_Password", "Password");

        }

        public void FTPSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "FTPSetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //cVariables.strFTPEnable         = int.Parse(this.Read("_FTPEnable", "FTPEnable"));
            //cVariables.strFTPURL            = this.Read("_FTPURL", "FTPURL");
            //cVariables.strFTPPORT           = this.Read("_FTPPORT", "FTPPORT");
            //cVariables.strFTPUploadPath     = this.Read("_FTPUploadPath", "FTPUploadPath");
            //cVariables.strFTPDownloadPath   = this.Read("_FTPDownloadPath", "FTPDownloadPath");
            //cVariables.strFTPUserName       = this.Read("_FTPUserName", "FTPUserName");
            //cVariables.strFTPPassword       = this.Read("_FTPPassword", "FTPPassword");
            //cVariables.strFTPLocalPath      = this.Read("_FTPLocalPath", "FTPLocalPath");

        }

        public void VersionSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "VersionSetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //cVariables.strCheckUpdate     = this.Read("_CheckUpdate", "CheckUpdate");
            //cVariables.strPublishDate     = this.Read("_PublishDate", "PublishDate");
            //cVariables.strPublishVersion  = this.Read("_PublishVersion", "PublishVersion");

        }

        public void MariaDBSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "DatabaseSettingMariaServer.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //cVariables.strServerEnable  = this.Read("_ServerEnable", "ServerEnable");
            //cVariables.strSource        = this.Read("_Source", "Source");
            //cVariables.strServer        = this.Read("_Server", "Server");
            //cVariables.strDatabase      = this.Read("_Database", "Database");
            //cVariables.strUserName      = this.Read("_UserName", "UserName");
            //cVariables.strPassword      = this.Read("_Password", "Password");
            //cVariables.strSecurity      = this.Read("_Security", "Security");
            //cVariables.strPort          = this.Read("_Port", "Port");
            //cVariables.strSSLMode       = this.Read("_SSLMode", "SSLMode");

            //// SSH
            //cVariables.strSSHMode        = this.Read("_SSHMode", "SSHMode");
            //cVariables.strSSHServer      = this.Read("_SSHServer", "SSHServer");
            //cVariables.strSSHDatabase    = this.Read("_Database", "Database");
            //cVariables.strSSHUserName    = this.Read("_SSHUserName", "SSHUserName");
            //cVariables.strSSHPassword    = this.Read("_SSHPassword", "SSHPassword");

        }

        public void SQLServerSetting()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "DatabaseSettingSQLServer.ini";
            FullPath = "C:\\BIR_EIS_CONNECT\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //cVariables.strServerEnable  = this.Read("_ServerEnable", "ServerEnable");
            //cVariables.strSource        = this.Read("_Source", "Source");
            //cVariables.strServer        = this.Read("_Server", "Server");
            //cVariables.strDatabase      = this.Read("_Database", "Database");
            //cVariables.strUserName      = this.Read("_UserName", "UserName");
            //cVariables.strPassword      = this.Read("_Password", "Password");
            //cVariables.strSecurity      = this.Read("_Security", "Security");
            //cVariables.strPort          = this.Read("_Port", "Port");
        }

    // WRITE

        private void WriteApiSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "APISetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //this.Write("_APIURL", "APIURL", cVariables.strAPIURL);
            //this.Write("_APIPath", "APIPath", cVariables.strAPIPath);
            //this.Write("_APIKeys", "APIKeys", cVariables.strAPIKeys);
            //this.Write("_APIContentType", "APIContentType", cVariables.strAPIContentType);
            //this.Write("_APIAuthUser", "APIAuthUser", cVariables.strAPIAuthUser);
            //this.Write("_APIAuthPassword", "APIAuthPassword", cVariables.strAPIAuthPassword);
            //this.Write("_APIImagesPath", "APIImagesPath", cVariables.strAPIImagesPath);
        }

        private void WriteFTPSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "FTPSetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //this.Write("_FTPURL", "FTPURL", cVariables.strFTPURL);
            //this.Write("_FTPPORT", "FTPPORT", cVariables.strFTPPORT);
            //this.Write("_FTPUploadPath", "FTPUploadPath", cVariables.strFTPUploadPath);
            //this.Write("_FTPDownloadPath", "FTPDownloadPath", cVariables.strFTPDownloadPath);
            //this.Write("_FTPUserName", "FTPUserName", cVariables.strFTPUserName);
            //this.Write("_FTPPassword", "FTPPassword", cVariables.strFTPPassword);
            //this.Write("_FTPLocalPath", "FTPLocalPath", cVariables.strFTPLocalPath);
        }

        private void WriteDatabaseSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "DataSettings.ini";
            FullPath = "C:\\Base-Project\\Settings\\" + FileName;
            this.IniFile(FullPath);

            //this.Write("_Source", "Source", cVariables.strSource);
            //this.Write("_Server", "Server", cVariables.strServer);
            //this.Write("_Database", "Database", cVariables.strDatabase);
            //this.Write("_UserName", "UserName", cVariables.strUserName);
            //this.Write("_Password", "Password", cVariables.strPassword);
            //this.Write("_Security", "Security", cVariables.strSecurity);
            //this.Write("_Port", "Port", cVariables.strPort);
        }

        private void WriteODBCSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "ODBCSetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //this.Write("_ServerName", "ServerName", clsODBC.ClassODBCServerName);
            //this.Write("_DSNName", "DSNName", clsODBC.ClassODBCDSNName);
            //this.Write("_DriverName", "DriverName", clsODBC.ClassODBCDriverName);
            //this.Write("_DatabaseName", "DatabaseName", clsODBC.ClassODBCDatabaseName);
            //this.Write("_Description", "Description", clsODBC.ClassODBCDescription);
            //this.Write("_User", "User", clsODBC.ClassODBCUser);
            //this.Write("_Password", "Password", clsODBC.ClassODBCPassword);
        }

        private void WriteSystemSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "SystemSetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //this.Write("_SplashInterval", "SplashInterval", clsSystemSetting.ClassSystemSplashInterval.ToString());
            //this.Write("_SplashTimeOut", "SplashTimeOut", clsSystemSetting.ClassSystemSplashTimeOut.ToString());
            //this.Write("_CheckNetLink", "CheckNetLink", clsSystemSetting.ClassSystemCheckNetLink.ToString());
            //this.Write("_NetLink", "NetLink", clsSystemSetting.ClassSystemNetLink);
            //this.Write("_CheckIPAddress", "CheckIPAddress", clsSystemSetting.ClassSystemCheckIPAddress.ToString());
            //this.Write("_IPAddress", "IPAddress", clsSystemSetting.ClassSystemIPAddress);
            //this.Write("_ConnectionType", "ConnectionType", clsSystemSetting.ClassSystemConnectionType);
            //this.Write("_PromptAPIRequest", "PromptAPIRequest", clsSystemSetting.ClassSystemPromptAPIRequest.ToString());
            //this.Write("_PromptAPIResponse", "PromptAPIResponse", clsSystemSetting.ClassSystemPromptAPIResponse.ToString());
            //this.Write("_LogInCheck", "LogInCheck", clsSystemSetting.ClassSystemLogInCheck.ToString());
            //this.Write("_ImportCheck", "ImportCheck", clsSystemSetting.ClassSystemImportCheck.ToString());
            //this.Write("_ExntededMonitor", "ExntededMonitor", clsSystemSetting.ClassSystemShowTaskBar.ToString());
            //this.Write("_MSOffice", "MSOffice", clsSystemSetting.ClassSystemMSOffice);
            //this.Write("_SkinColor", "SkinColor", clsSystemSetting.ClassSystemSkinColor);
        }

        private void WriteVersionSettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "VersionSetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //this.Write("_PublishVersion", "PublishVersion", cGvar.strPublishVersion);
        }

        private void WriteCompanySettings()
        {
            string Path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string FullPath = string.Empty;
            string FileName = string.Empty;

            FileName = "SystemSetting.ini";
            FullPath = "C:\\SBSD_TLSYSTEM\\SETTING\\" + FileName;
            this.IniFile(FullPath);

            //this.Write("_CompanyName", "CompanyName", clsSystemSetting.ClassCompanyName);
            //this.Write("_CompanyAddress", "CompanyAddress", clsSystemSetting.ClassCompanyAddress);
            //this.Write("_ApplicationName", "ApplicationName", clsSystemSetting.ClassApplicationName);

        }

    #endregion

    }

}
