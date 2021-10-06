using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Data.SqlClient;
using System.Data;
using System;
using System.Reflection;

namespace HospitalManagement.SupportingClasses
{
    class DataFactory
    {
       
        #region Private Variables
        private static SqlConnection _dbConnection;
        #endregion

        #region Public Properties
        public static SqlConnection DbConnection
        {
            get
            {
                return _dbConnection;
            }

        }

        
        #endregion

        #region Constructor

        static DataFactory()
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PT6JD7RC\SQLEXPRESS;Initial Catalog=eHospitalDB;Integrated Security=True");
            con.Open();
            _dbConnection = con;

            //if (String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings?["TheWirelessCenterEntities"]?.ToString()))
            //{throw new Exception("Connection String is not defined");}
            
            //_dbConnection = new SqlConnection(EncryptDecryptUtility.Decrypt(System.Configuration.ConfigurationManager.AppSettings["CMSEntities"].ToString()));
        }

        #endregion
        
        /// <summary>
        /// Create IDbCommand by taking CommandText and DatabaseType
        /// </summary>
        /// <param name="CommandText"></param>
        /// <param name="dbtype"></param>
        /// <param name="cnn"></param>
        /// <returns>IDbCommand</returns>
        public static SqlCommand CreateCommand(string CommandText, CommandType commandType, SqlConnection cnn)
        {
            SqlCommand cmd;
            cmd = new SqlCommand(CommandText, cnn);
            cmd.CommandTimeout = int.MaxValue;
            cmd.CommandType = commandType;
            return cmd;
        }

        /// <summary>
        /// Create DataAdapter by taking IDbCommand and DatabaseType
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="dbtype"></param>
        /// <returns>DbDataAdapter </returns>
        public static SqlDataAdapter CreateAdapter(SqlCommand command)
        {
            SqlDataAdapter da;
            da = new SqlDataAdapter((SqlCommand)command);

            return da;
        }

        public Boolean BulkSave(SqlConnection _conn, DataSet ds)
        {
            Boolean isOk = false;

            SqlConnection conn = _conn;
            conn.Open();

            SqlTransaction transaction = conn.BeginTransaction();
            try
            {

                SqlBulkCopy sqlbulk = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, transaction);
                sqlbulk.BulkCopyTimeout = int.MaxValue;
                foreach (DataTable item in ds.Tables)
                {
                    sqlbulk.DestinationTableName = item.TableName.ToString();
                    sqlbulk.WriteToServer(item);
                }

                transaction.Commit();
                isOk = true;
            }
            catch (Exception exp)
            {
                isOk = false;
                transaction.Rollback();
                throw exp;
            }
            finally
            {
                transaction.Dispose();
                conn.Close();
            }

            return isOk;
        }
        
        public static SqlDataReader ExecuteReaderCmd(SqlConnection SqlCon, string cmdText, CommandType cmdType)
        {
            // validate parameters
            if (cmdText == String.Empty)
                throw new ArgumentOutOfRangeException("cmdText");

            SqlConnection sqlConn = SqlCon;
            SqlCommand sqlCmd = new SqlCommand(cmdText, sqlConn);
            sqlCmd.CommandType = cmdType;
            sqlCmd.CommandTimeout = 9999;

            sqlCmd.Connection.Open();
            return sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
   
        public static SqlDataReader ExecuteReaderCmd(SqlConnection SqlCon, string cmdText, CommandType cmdType, SqlParameterCollection sqlParameters)
        {
            // validate parameters
            if (cmdText == String.Empty)
                throw new ArgumentOutOfRangeException("cmdText");

            if (sqlParameters == null)
                throw new ArgumentNullException("sqlParameters");

            SqlConnection sqlConn = SqlCon;
            SqlCommand sqlCmd = new SqlCommand(cmdText, sqlConn);
            sqlCmd.CommandType = cmdType;
            sqlCmd.CommandTimeout = 9999;

            foreach (SqlParameter p in sqlParameters)
            {
                sqlCmd.Parameters.AddWithValue(p.ParameterName, p.Value);
            }

            sqlCmd.Connection.Open();
            return sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

       

        public static SqlDataReader ExecuteReaderCmd(string connectionString, string cmdText, SqlParameterCollection sqlParameters)
        {
            // validate parameters
            if (cmdText == String.Empty)
                throw new ArgumentOutOfRangeException("cmdText");

            if (sqlParameters == null)
                throw new ArgumentNullException("sqlParameters");

            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlCmd = new SqlCommand(cmdText, sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter p in sqlParameters)
            {
                sqlCmd.Parameters.AddWithValue(p.ParameterName, p.Value);
            }

            sqlCmd.Connection.Open();
            return sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
  
        public static object ExecuteNonQuery(SqlCommand sqlCommand, SqlTransaction objSqlTransaction)
        {
            // Validating SqlCommand
            if (sqlCommand == null) throw new Exception("Error in provided parameter <SqlCommand>. Please review your SqlCommand object.");

            // Validating Connection
            if (sqlCommand.Connection == null) throw new Exception("Error in provided Connection. Please set SqlCommand.Connection = new SqlConnection(string ConnectionString); or in other ways.");

            // Validating CommandText
            if (String.IsNullOrEmpty(sqlCommand.CommandText)) throw new Exception("Error in provided Command Text. Please set SqlCommand.CommandText = \"Some SQL query or StoredProcedure name\"; or in other ways.");

            using (sqlCommand)
            {
                sqlCommand.Transaction = objSqlTransaction;

                try
                {
                    // Finally, execute the command
                    object retval = sqlCommand.ExecuteNonQuery();
                    //sqlCommand.ExecuteXmlReader();
                    // If @@Identity returned from SP then return @@Identity
                    for (Int32 i = 0; i < sqlCommand.Parameters.Count; i++)
                    {
                        if (sqlCommand.Parameters[i].Direction == ParameterDirection.ReturnValue)
                        {
                            if (sqlCommand.Parameters[i].Value != null)
                                retval = sqlCommand.Parameters[i].Value;
                            break;
                        }
                    }

                    return retval;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
     

        public static object ExecuteNonQueryCmd(SqlConnection sqlCon, string cmdText, CommandType cmdType, SqlParameterCollection sqlParameters)
        {
            // this method will return the return value parameter of the stored procedure, if there is one,
            // otherwise it will return the number of rows affected

            // validate parameters
            if (cmdText == String.Empty)
                throw new ArgumentOutOfRangeException("cmdText");

            if (sqlParameters == null)
                throw new ArgumentNullException("sqlParameters");

            SqlConnection sqlConn = sqlCon;
            SqlCommand sqlCmd = new SqlCommand(cmdText, sqlConn);
            sqlCmd.CommandType = cmdType;
            sqlCmd.CommandTimeout = 9999;
            string retParamName = String.Empty;
            object retVal = null;

            foreach (SqlParameter p in sqlParameters)
            {
                if (p.Direction == ParameterDirection.ReturnValue)
                {
                    retParamName = p.ParameterName;
                    sqlCmd.Parameters.Add(p.ParameterName, p.SqlDbType);
                    sqlCmd.Parameters[retParamName].Direction = ParameterDirection.ReturnValue;
                }
                else
                {
                    sqlCmd.Parameters.AddWithValue(p.ParameterName, p.Value);
                }
            }

            try
            {
                if (sqlCmd != null && sqlCmd.Connection.State == ConnectionState.Closed)
                {
                    sqlCmd.Connection.Open();
                }
                
                retVal = sqlCmd.ExecuteNonQuery();

                if (retParamName != String.Empty)
                {
                    retVal = sqlCmd.Parameters[retParamName].Value;
                }
            }

            finally
            {
                sqlCmd.Connection.Close();
            }

            return retVal;
        }
        
        /// <summary>
        /// Execute a SqlCommand (that returns a Dataset) against the database with specified connection string.
        /// </summary>
        /// <param name="ConStr">A connection string for a SqlConnection.</param>
        /// <param name="CmdType">The CommandType (stored procedure or text).</param>
        /// <param name="CmdText">The stored procedure name or T-SQL command.</param>
        /// <returns>A dataset containing the resultset generated by the command.</returns>
        public static DataSet ExecuteDataset(CommandType CmdType, string cmdText, SqlParameterCollection sqlParameters, SqlConnection sqlconn)
        {
            // create a new instance of SQL Connection
            //using (SqlConnection connection = new SqlConnection(sqlconn.ConnectionString))
            //{
            //connection.Open();
            if (sqlconn == null || sqlconn.State == ConnectionState.Closed)
            {
                sqlconn = new SqlConnection(@"Data Source=LAPTOP-PT6JD7RC\SQLEXPRESS;Initial Catalog=eHospitalDB;Integrated Security=True");
                sqlconn.Open();                
            }
           
            // validate parameters
            if (cmdText == String.Empty)
                throw new ArgumentOutOfRangeException("cmdText");

            if (sqlParameters == null)
                throw new ArgumentNullException("sqlParameters");

            // Create a new instance of SQL Command and set attributes
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlconn;
            cmd.CommandType = CmdType;
            cmd.CommandText = cmdText;
            cmd.CommandTimeout = 9999;

            foreach (SqlParameter p in sqlParameters)
                cmd.Parameters.AddWithValue(p.ParameterName, p.Value);

            //  Create a new instance of SQL DataAdapter and fill DataSet
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                //  connection.Close();
                if (ds.Tables.Count < 1)
                    ds.Tables.Add(new DataTable());
                return ds;
            }
            //}
        }

        /// <summary>
        /// Execute a SqlCommand (that returns a Dataset) against the database with specified connection string.
        /// </summary>
        /// <param name="ConStr">A connection string for a SqlConnection.</param>
        /// <param name="CmdType">The CommandType (stored procedure or text).</param>
        /// <param name="CmdText">The stored procedure name or T-SQL command.</param>
        /// <returns>A dataset containing the resultset generated by the command.</returns>
        public static DataSet ExecuteDataset(CommandType CmdType, string cmdText, SqlConnection sqlconn)
        {
            // create a new instance of SQL Connection
            using (SqlConnection connection = new SqlConnection(sqlconn.ConnectionString))
            {
                connection.Open();
                // validate parameters
                if (cmdText == String.Empty)
                    throw new ArgumentOutOfRangeException("cmdText");



                // Create a new instance of SQL Command and set attributes
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CmdType;
                cmd.CommandText = cmdText;
                cmd.CommandTimeout = 9999;

                //  Create a new instance of SQL DataAdapter and fill DataSet
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    connection.Close();
                    if (ds.Tables.Count < 1)
                        ds.Tables.Add(new DataTable());
                    return ds;
                }
            }
        }


        #region ------- Get ParameterCollection Constructor -------------
        public static SqlParameterCollection GetParameterCollectionConstructor()
        {
            return (SqlParameterCollection)typeof(SqlParameterCollection).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, Type.EmptyTypes, null).Invoke(null);
        }
        #endregion ------- Get ParameterCollection Constructor ----------


        internal static DataTable ExecuteDataTable(CommandType CmdType, string cmdText, SqlParameterCollection sqlParameters, SqlConnection sqlconn)
        {
            // create a new instance of SQL Connection
            //using (SqlConnection connection = new SqlConnection(sqlconn.ConnectionString))
            //{
            //connection.Open();
            // validate parameters
            if (cmdText == String.Empty)
                throw new ArgumentOutOfRangeException("cmdText");

            if (sqlParameters == null)
                throw new ArgumentNullException("sqlParameters");

            // Create a new instance of SQL Command and set attributes
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlconn;
            cmd.CommandType = CmdType;
            cmd.CommandText = cmdText;
            cmd.CommandTimeout = 9999;

            foreach (SqlParameter p in sqlParameters)
                cmd.Parameters.AddWithValue(p.ParameterName, p.Value);

            //  Create a new instance of SQL DataAdapter and fill DataSet
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable ds = new DataTable();
                da.Fill(ds);
                //  connection.Close();
                if (ds.Rows.Count < 1)
                   ds=new DataTable();
                return ds;
            }
            //}
        }

        internal static DataTable ExecuteDataTable(CommandType CmdType, string cmdText, SqlConnection sqlconn)
        {
            // create a new instance of SQL Connection
            //using (SqlConnection connection = new SqlConnection(sqlconn.ConnectionString))
            //{
            //connection.Open();
            // validate parameters
            if (cmdText == String.Empty)
                throw new ArgumentOutOfRangeException("cmdText");

            // Create a new instance of SQL Command and set attributes
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlconn;
            cmd.CommandType = CmdType;
            cmd.CommandText = cmdText;
            cmd.CommandTimeout = 9999;


            //  Create a new instance of SQL DataAdapter and fill DataSet
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable ds = new DataTable();
                da.Fill(ds);
                //  connection.Close();
                if (ds.Rows.Count < 1)
                    ds = new DataTable();
                return ds;
            }
            //}
        }
    
    
    }
}

