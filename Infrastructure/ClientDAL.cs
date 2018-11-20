using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tablesheet.Infrastructure
{
    public class ClientDAL
    {
        DataTable dt = new DataTable();

        public string clientName { get; set; }

        public DataTable ReadClientName()
        {
            Connection conn = new Connection();
            if (ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }

            SqlCommand cmd = new SqlCommand("Select Name from Client", conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch { throw; }
        }

        public DataTable searchByName(string name)
        {
            Connection conn = new Connection();
            string query = string.Format("select Name from Client join Job on Client.ID = Job.ClientID where Job.Code = @Code");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(name);
            sqlParameters[1] = new SqlParameter("@Code", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(name);
            return conn.SelectQuery(query, sqlParameters);
        }
    }
}
