using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tablesheet.Infrastructure;

namespace Tablesheet.Core
{
    public class ActivityBLL
    {
        public DataTable GetActivityName()
        {
            try
            {
                ActivityDAL activityNameObj = new ActivityDAL();
                return activityNameObj.ReadActivityName();
            }
            catch { throw; }
        }
    }
}
