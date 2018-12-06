using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;
using Tablesheet.Infrastructure;

namespace Tablesheet.Core
{
    public class ScheduleBLL
    {
        public DateTime dateTime { get; set; }
        public string nextShift { get; set; }
        public string date { get; set; }
        public string startShift { get; set; }
        public string endShift { get; set; }

        public DataTable GetShiftDetails(string username)
        {
            try
            {
                ScheduleDAL objShift = new ScheduleDAL();
                DataTable dt = new DataTable();
                dt = objShift.ReadNextShiftByUsername(username);
                foreach (DataRow dr in dt.Rows)
                {
                    date = dr["Date"].ToString();
                    dateTime = DateTime.Parse(date);
                    startShift = dr["StartShift"].ToString();
                    endShift = dr["EndShift"].ToString();
                    nextShift = startShift + " - " + endShift;
                }
                return dt;
            }
            catch { throw; }
        }

        public DataTable GetStartEndShift(string username)
        {
            try
            {
                ScheduleDAL objShift = new ScheduleDAL();
                DataTable dt = new DataTable();
                dt = objShift.ReadStartEndShift(username);
                foreach (DataRow dr in dt.Rows)
                {
                    startShift = dr["StartShift"].ToString();
                    endShift = dr["EndShift"].ToString();
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
