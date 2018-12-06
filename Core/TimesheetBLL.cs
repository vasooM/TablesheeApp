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
                dt = endDateObj.SearchByCode(code);
                foreach (DataRow dr in dt.Rows)
                {
                    endDateObj.endDate = dr["EndDate"].ToString();
                }
                return dt;
            }
            catch { throw; }

        }

        public string ConvertDataTableToString(DataTable dataTable)
        {
            var output = new StringBuilder();

            var columnsWidths = new int[dataTable.Columns.Count];

            // Get column widths
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    var length = row[i].ToString().Length;
                    if (columnsWidths[i] < length)
                        columnsWidths[i] = length;
                }
            }

            // Write Rows
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    var text = row[i].ToString();
                    output.Append(PadCenter(text, columnsWidths[i] + 2));
                }
            }
            return output.ToString();
        }

        private static string PadCenter(string text, int maxLength)
        {
            int diff = maxLength - text.Length;
            return new string(' ', diff / 2) + text + new string(' ', (int)(diff / 2.0 + 0.5));
        }
    }

}
