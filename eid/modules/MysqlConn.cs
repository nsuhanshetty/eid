using System;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;

namespace eid
{
    /// <summary>
    /// utilized to insert, update and extract database information.
    /// </summary>
    class MysqlConn
    {
        # region 'PrivateVariables
        const String DBInsert = "INSERT";
        const String DBUpdate = "UPDATE";
        //ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

        ErrorDump ed = new ErrorDump();
        # endregion 'PrivateVariables

        # region 'PublicSubsAndFunction
        public MySqlConnection getCon()
        {
            try
            {
                string connectionstring = "Server=127.0.0.1;userid=sa;password=sshetty;Database=privateeyeeid;";
               // string connectiostring = "server=127.0.0.1;uid=root;pwd=12345;database=test;";

                MySqlConnection conn = new MySqlConnection(connectionstring);
                // Dim conn As New MySqlConnection("Data source=" & datasource & ";Database=" & dbname & ";userid=" & dbuserid & ";password=" & dbpwd & ";");
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                //write Error Log with ex as explaination                 
                ed.WriteToSQLErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Unable to Connect to the Database,Please Check the Connection string and Database");
                ex.Data.Clear();
                return null;
            }
        }

        public MySqlDataReader GetSQLDataReader(string a_strSQLCommand)
        {
            MySql.Data.MySqlClient.MySqlDataReader oSQLDR;
            MySql.Data.MySqlClient.MySqlCommand objCommand;
            try
            {
                //Dim AttemptToConnect As Boolean = OpenSQLConnection()
                objCommand = new MySql.Data.MySqlClient.MySqlCommand(a_strSQLCommand);
                objCommand.Connection = getCon();
                //objCommand.CommandTimeout = ConnectionTimeOut
                objCommand.CommandType = CommandType.Text;
                oSQLDR = objCommand.ExecuteReader();
                objCommand.Dispose();
                return oSQLDR;
            }
            catch (MySqlException ex)
            {
                //write Error Log with ex as explaination
                ed.WriteToSQLErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the DataReader.");
                ex.Data.Clear();
                return null;
            }
            catch (Exception ex)
            {
                //write Error Log with ex as explaination
                ed.WriteToErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the DataReader.");
                ex.Data.Clear();
                return null;
            }
        }

        public DataTable getDataTable(String qry)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, getCon());
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adptr.Fill(ds);
                cmd.Dispose();
                return ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                //write Error Log with ex as explaination
                ed.WriteToSQLErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the GetDataTable.");
                ex.Data.Clear();
                return null;
            }
            catch (Exception ex)
            {
                //write Error Log with ex as explaination
                ed.WriteToErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the DataReader.");
                ex.Data.Clear();
                return null;
            }
        }

        public object returnFirstCell(String qry)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, getCon());
                return cmd.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                //write Error Log with ex as explaination
                ed.WriteToSQLErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the returnFirstCell.");
                ex.Data.Clear();
                return null;
            }
            catch (Exception ex)
            {
                //write Error Log with ex as explaination
                ed.WriteToErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the DataReader.");
                ex.Data.Clear();
                return null;
            }

        }

        public int dictionaryToTable( Dictionary<String, Object> dict , String QryName)  
         {
        try
        {
            StringBuilder Sb =new  StringBuilder();

            MySqlCommand cmd = new MySqlCommand(QryName);

            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection = getCon();

             foreach ( KeyValuePair<String, Object> keyval in dict)
            {
                cmd.Parameters.AddWithValue("@" + keyval.Key, keyval.Value);
            }

           return cmd.ExecuteNonQuery();
        }
        catch (MySqlException ex)
            {
                //write Error Log with ex as explaination
            ed.WriteToSQLErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the DictionaryToTable.");
            ex.Data.Clear();
            return 0;
            }
        catch (Exception ex)
        {
            //write Error Log with ex as explaination
            ed.WriteToErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the DataReader.");
            ex.Data.Clear();
            return 0;
        }
        }

        public int executeQry(String Qry)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(Qry, getCon());
                return cmd.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {
                //write Error Log with ex as explaination
                ed.WriteToSQLErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the ExecuteQuery.");
                ex.Data.Clear();
                return 0;
            }
            catch (Exception ex)
            {
                //write Error Log with ex as explaination
                ed.WriteToErrorLog(ErrorDump.ErrorDumpErrorLogType.Critical, ex, "Database Error, Check the DataReader.");
                ex.Data.Clear();
                return 0;
            }
        }
        # endregion 'PublicSubsAndFunction
    }
}
