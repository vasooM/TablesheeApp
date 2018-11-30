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
    }
}
