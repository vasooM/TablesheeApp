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

        public DataTable SearchByCode(string code)
        {
            Connection conn = new Connection();
            string query = string.Format(@"SELECT EndDate
                                            FROM Timesheet
                                            JOIN TimesheetEntry ON Timesheet.ID = TimesheetEntry.TimesheetID
                                            JOIN Job ON TimesheetEntry.ID = Job.ID
                                            where Job.Code = @jobCode");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@jobCode", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(code);
            return conn.SelectQuery(query, sqlParameters);
        }
    }
}