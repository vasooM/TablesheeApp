using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tablesheet.Infrastructure;
using System.Data.SqlClient;
using Tablesheet.UI;

namespace Tablesheet.Core
{
    public class EmployeeBLL
    {
        public List<string> GetEmployeeFullName()
        {
            try
            { 
                EmployeeDAL empObj = new EmployeeDAL();
                return empObj.LoadList();

            }
            catch { throw; }
        }
    }
}
