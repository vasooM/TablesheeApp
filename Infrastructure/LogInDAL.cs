using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tablesheet.Infrastructure
{
    public class LogInDAL
    {
        public string username { get; set; }
        public string password { get; set; }

        public DataTable SearchByUserAndPass(string username, string password)
        {
            Connection conn = new Connection();
            string query = string.Format(@"select Username, Password from UserLogin
                                where @username = Username and @password = Password");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            sqlParameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(password);

            return conn.SelectQuery(query, sqlParameters);
        }
    }
}