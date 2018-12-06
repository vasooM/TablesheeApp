using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tablesheet.Infrastructure;

namespace Tablesheet.Core
{
    public class LogInBLL
    {
        public DataTable GetUsernameAndPassword(string user, string pass)
        {
            try
            {
                LogInDAL objLogIn = new LogInDAL();
                DataTable dt = new DataTable();
                dt = objLogIn.SearchByUserAndPass(user, pass);

                foreach (DataRow dr in dt.Rows)
                {
                    objLogIn.username = dr["Username"].ToString();
                    objLogIn.password = dr["Password"].ToString();
                }

                return dt; 

            }
            catch { throw; }
        }
    }
}
