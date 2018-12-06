using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tablesheet.Infrastructure
{
    public class EmployeeDAL
    {
        public string usernameLog { get; set; }
         
        public List<string> LoadList()
        {
            List<string> empNameList = new List<string>();
            Connection conn = new Connection();
            if (ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }

            SqlCommand cmd = new SqlCommand("Select FirstName + ' ' + LastName as FullName from Employee", conn.con);
            try
            {
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        empNameList.Add(Convert.ToString(rd[0]));
                    }
                }
                return empNameList;
            }
            catch { throw; }
        }

        public DataTable ReadEmpNameByUsername(string username)
        {
            Connection conn = new Connection();
            string query = string.Format(@"select FirstName + ' ' + LastName as FullName
                                         from Employee join UserLogin on UserLogin.ID = Employee.UserLoginID 
                                            where UserLogin.Username = @username");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            return conn.SelectQuery(query, sqlParameters);
        }

        public DataTable ReadEmpLastNameByUsername(string username)
        {
            Connection conn = new Connection();
            string query = string.Format(@"select LastName
                                         from Employee join UserLogin on UserLogin.ID = Employee.UserLoginID 
                                            where UserLogin.Username = @username");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            return conn.SelectQuery(query, sqlParameters);
        }
    }
}
