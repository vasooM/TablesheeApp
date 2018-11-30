using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tablesheet.Infrastructure
{
    public class TimesheetDAL
    {
        DataTable dt = new DataTable();

        public string endDate { get; set; }

        public DataTable searchByName(string name)
        {
            Connection conn = new Connection();
            string query = string.Format(@"SELECT EndDate
                                            FROM Timesheet
                                            INNER JOIN TimesheetEntry ON Timesheet.ID = TimesheetEntry.TimesheetID
                                            INNER JOIN Job ON TimesheetEntry.ID = Job.ID
                                            where Job.Code = @jobCode");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@EndDate", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(name);
            sqlParameters[1] = new SqlParameter("@jobCode", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(name);
            return conn.SelectQuery(query, sqlParameters);
        }
    }
}
