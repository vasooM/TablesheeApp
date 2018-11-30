using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tablesheet.Infrastructure;

namespace Tablesheet.Core
{
    public class TimesheetBLL
    {
        public DataTable GetEndDateWithJobCode(string code)
        {

            try
            {
                TimesheetDAL endDateObj = new TimesheetDAL();
                DataTable dt = new DataTable();
                dt = endDateObj.searchByName(code);
                foreach (DataRow dr in dt.Rows)
                {
                    endDateObj.endDate = dr["EndDate"].ToString();
                }
                return dt;
            }
            catch { throw; }

        }


    }
}
