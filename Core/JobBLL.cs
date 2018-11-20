using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tablesheet.Infrastructure;

namespace Tablesheet.Core
{
    public class JobBLL
    {
        public DataTable GetJobCode()
        {
            try
            {
                JobDAL codeObj = new JobDAL();
                return codeObj.ReadJobCode();
                
            }
            catch { throw; }
        }
    }
}
