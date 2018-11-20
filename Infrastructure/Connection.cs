using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tablesheet.Infrastructure
{
    public class Connection
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tablesheet.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlDataAdapter sda = new SqlDataAdapter();

        public SqlConnection openConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            return con;
        }

        public DataTable SelectQuery(String query, SqlParameter[] sqlParameter)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = query;
                cmd.Parameters.AddRange(sqlParameter);
                cmd.ExecuteNonQuery();
                sda.SelectCommand = cmd;
                sda.Fill(ds);
                dt = ds.Tables[0];
            }

            catch(SqlException e)
            {
                Console.WriteLine("Error - Connection.SelectQuery - Query: " + query + "\nException: " + e.StackTrace.ToString());
            }
            return dt;

        }
    }
}
