using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tablesheet.Infrastructure
{
    public class ScheduleDAL
    {
        DataTable dt = new DataTable();
        
        public DataTable ReadStartEndShift(string username)
        {
            Connection conn = new Connection();
            string query = string.Format(@"select StartShift, EndShift 
                                    from Schedule join Employee on Schedule.EmployeeID = Employee.ID 
                                    join UserLogin on UserLogin.ID = Employee.UserLoginID
                                    where UserLogin.Username = @username and 
                                    Date < (select MAX(Date) from Schedule)
                                    order by Date desc");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            return conn.SelectQuery(query, sqlParameters);
        }

        public DataTable ReadNextShiftByUsername(string username)
        {
            Connection conn = new Connection();
            string query = string.Format(@"select TOP 1 Date, StartShift, EndShift 
                                    from Schedule join Employee on Schedule.EmployeeID = Employee.ID 
                                    join UserLogin on UserLogin.ID = Employee.UserLoginID
                                    where UserLogin.Username = @username and 
                                    Date >= GETDATE()
                                    order by Date");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            return conn.SelectQuery(query, sqlParameters);
        }
    }
}
