using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using Microsoft.Win32;
using System.Xml;
using Microsoft.VisualBasic;
using System.Collections;

namespace Meropasal
{

    public   class CommonDBClass
    {
        //Variables required for Database connections
        public string ServerNameAddress = "";
        public string ServerLoginUID = "";
        public string ServerLoginPassword = "";
        public string CompanyDatabase = "";
        public string SqlServerConnectionString;
        public SqlConnection SqlConn;

        public void ConOpen()
        {
            //Oppening database connecion if closed
            SqlServerConnectionString = "Data Source=" + ServerNameAddress + "; Initial Catalog=" + CompanyDatabase + "; User ID=" + ServerLoginUID + "; Password=" + ServerLoginPassword + "";
            SqlConn = new SqlConnection(SqlServerConnectionString);
            if (SqlConn.State == ConnectionState.Closed)
            {
                SqlConn.Open();
        
            }
        }
        public void ConClose()
        {

            //Closing database connecion if Opened

            if (SqlConn.State ==ConnectionState.Open)
            {
                SqlConn.Close();
            }
        }
        public bool ExecuteQuery(Hashtable  Parameters=null, params string[] Queries)
        {
            //Execute database query Using in transacion control 
            ConOpen();
            SqlTransaction Transaction;
            Transaction = SqlConn.BeginTransaction();
            try
            {
                foreach (string Query in Queries)
                {
                    SqlCommand cmd = new SqlCommand(Query, SqlConn, Transaction);

                    if (Parameters != null)
                    {
                        foreach (DictionaryEntry parameter in Parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.Key.ToString(),parameter.Value);
                        }
                    }

                    cmd.ExecuteNonQuery();
                }
                Transaction.Commit();
                return true;
        }
        catch (Exception ex)
        {
            Transaction.Rollback();
            Interaction.MsgBox(ex.Message);
            return false;

        }
        finally
        {
            ConClose();
}
    }

    public DataTable LoadSqlData(params string[] Queries )
        {
            //Load database data to datatable or Execute query and get returned value
            ConOpen();
            SqlTransaction Transaction;
            var DataTables = new DataTable();
            Transaction = SqlConn.BeginTransaction();
            try
            {
                foreach (string Query in Queries)
                {
                    var cmd = new SqlCommand(Query, SqlConn, Transaction);
                    var SqlDataAdapters = new SqlDataAdapter(cmd);
                    SqlDataAdapters.Fill(DataTables);
                }
                Transaction.Commit();
                return DataTables;
            }
            catch (Exception ex)
            {
                Transaction.Rollback();
           //     DataTables.Rows.Add("");
                Interaction.MsgBox(ex.Message);
                
                return DataTables;
            }
            finally
            {
                ConClose();
            }
        }

    }
}
