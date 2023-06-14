using ActivityReportSystem.Global;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityReportSystem.AppActivity.Model
{
    class clsAppStoredProc
    {
        private MySqlConnection Conn;
        private MySqlCommand Cmd;
        private MySqlDataReader Reader;

        public DataTable CollectionDetails(string StatementType, string StatementBy, string SearchValue)
        {
            DataTable dataTable = new DataTable();

            using (Conn = new MySqlConnection(sAppData.DataParam.ConnString))
            {
                Conn.Open();

                Debug.WriteLine(string.Concat("CALL spCollectionDetails ", "(\"", StatementType, "\"", ",\"", StatementBy, "\"", ",\"", SearchValue, "\"", ")"));

                using (Cmd = new MySqlCommand("spCollectionDetails", Conn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                    Cmd.Parameters.AddWithValue("@SearchBy", StatementBy);
                    Cmd.Parameters.AddWithValue("@SearchVal", SearchValue);

                    try
                    {
                        using (Reader = Cmd.ExecuteReader())
                        {
                            dataTable.Load(Reader);
                        }

                        return dataTable;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error Executing Stored Procedure: " + ex.Message);
                    }
                }
            }

            return dataTable; // Return an empty DataTable in case of an error
        }

        public void CollectionUpdate(string StatementType, string StatementBy, string SearchValue, string Sql)
        {
            using (Conn = new MySqlConnection(sAppData.DataParam.ConnString))
            {
                Conn.Open();

                Debug.WriteLine(string.Concat("CALL spCollectionUpdate ", "(\"", StatementType, "\"", ",\"", StatementBy, "\"", ",\"", SearchValue, "\"", ")"));

                using (Cmd = new MySqlCommand("spCollectionUpdate", Conn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                    Cmd.Parameters.AddWithValue("@SearchBy", StatementBy);
                    Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);
                    Cmd.Parameters.AddWithValue("@pSql", Sql);

                    try
                    {
                        Cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error Executing Stored Procedure: " + ex.Message);
                    }

                }
            }
        }

        public void CollectionInsert(string StatementType, string StatementBy, string SearchValue, string Sql)
        {
            using (Conn = new MySqlConnection(sAppData.DataParam.ConnString))
            {

                Conn.Open();

                Debug.WriteLine(string.Concat("CALL spCollectionInsert ", "(\"", StatementType, "\"", ",\"", StatementBy, "\"", ",\"", SearchValue, "\"", ")"));

                using (Cmd = new MySqlCommand("spCollectionInsert", Conn))
                {

                    Cmd.CommandType = CommandType.StoredProcedure;

                    Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                    Cmd.Parameters.AddWithValue("@StatementBy", StatementBy);
                    Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);
                    Cmd.Parameters.AddWithValue("@pSQL", Sql);

                    Cmd.Parameters.Add("@outLastInsertID", MySqlDbType.VarChar, 255).Direction = ParameterDirection.Output;
                    Cmd.Parameters.Add("@outErrorMessage", MySqlDbType.VarChar, 255).Direction = ParameterDirection.Output;

                    try
                    {

                        Cmd.ExecuteNonQuery();

                        // Retrieve the value of the output parameter
                        sAppData.DataParam.outLastInserted = Cmd.Parameters["@outLastInsertID"].Value.ToString().Trim();
                        sAppData.DataParam.outMessage = Cmd.Parameters["@outErrorMessage"].Value.ToString().Trim();

                    }
                    catch (Exception ex)
                    {

                        Debug.WriteLine("Error Executing Stored Procedure: " + ex.Message);
                    }
                }

                Debug.WriteLine("Last Inserted ID : " + sAppData.DataParam.outLastInserted);
            }
        }

        public void CollectionDelete(string StatementType, string StatementBy, string SearchValue)
        {
            using (Conn = new MySqlConnection(sAppData.DataParam.ConnString))
            {
                Conn.Open();

                Debug.WriteLine(string.Concat("CALL spCollectionUpdate ", "(\"", StatementType, "\"", ",\"", StatementBy, "\"", ",\"", SearchValue, "\"", ")"));

                using (Cmd = new MySqlCommand("spCollectionUpdate", Conn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    Cmd.Parameters.AddWithValue("@StatementType", StatementType);
                    Cmd.Parameters.AddWithValue("@SearchBy", StatementBy);
                    Cmd.Parameters.AddWithValue("@SearchValue", SearchValue);

                    try
                    {
                        Cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error Executing Stored Procedure: " + ex.Message);
                    }

                }
            }

        }

    }
}
