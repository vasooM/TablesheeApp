using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tablesheet.Infrastructure;

namespace Tablesheet.Core
{
    public class ClientBLL
    { 
        public DataTable GetClientNameWithJobCode(string code)
        {
            try
            {
                ClientDAL clientNameObj = new ClientDAL();
                DataTable dt = new DataTable();
                dt = clientNameObj.searchByName(code);
                foreach (DataRow dr in dt.Rows)
                {
                    clientNameObj.clientName = dr["Name"].ToString();
                }
                return dt;
            }
            catch { throw; }
        }   
    }
}
