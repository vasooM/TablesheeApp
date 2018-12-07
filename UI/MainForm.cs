using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tablesheet.Core;
using System.Configuration;

using Tablesheet.UI;

namespace Tablesheet
{
    public partial class Timesheet : Form
    {

        public Timesheet()
        {
            InitializeComponent();
        }


        ClientBLL clientName = new ClientBLL();
        JobBLL jobCode = new JobBLL();
        ActivityBLL activityName = new ActivityBLL();
        EmployeeBLL empName = new EmployeeBLL();
        TimesheetBLL endDate = new TimesheetBLL();
        ScheduleBLL nextShift = new ScheduleBLL();
        ScheduleBLL objSch = new ScheduleBLL();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtShift = new DataTable();
        string deadline = string.Empty;
        string employee = string.Empty;
        string shift = string.Empty;

        TimeSpan start = new TimeSpan();
        TimeSpan end = new TimeSpan();
        TimeSpan now = DateTime.Now.TimeOfDay;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timesheet_Load(object sender, EventArgs e)
        {
            
            dtShift = objSch.GetStartEndShift(Form1.user);
            start = TimeSpan.Parse(objSch.startShift);
            end = TimeSpan.Parse(objSch.endShift);
            
            if ((now > start) && (now < end))
            {
                stripStatus.Text = "                         Open Timesheet";
            }
            else
            {
                stripStatus.Text = "                        Timesheet Closed";

                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }

                btnClose.Enabled = true;
            }


            cbJobCode.DisplayMember = "Code";
            cbJobCode.ValueMember = "ID";
            cbJobCode.DataSource = jobCode.GetJobCode();
            cbJobCode.SelectedIndex = -1;

            cbAccount.SelectedIndex = -1;

            cbActivity.DisplayMember = "Name";
            cbActivity.ValueMember = "ID";
            cbActivity.DataSource = activityName.GetActivityName();
            cbActivity.SelectedIndex = -1;

            txtJobAdmin.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtJobAdmin.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection name = new AutoCompleteStringCollection();
            name.AddRange(empName.GetEmployeeFullName().ToArray());
            txtJobAdmin.AutoCompleteCustomSource = name;
            
            dt = empName.GetEmpNameByUsername(Form1.user);
            employee = empName.ConvertDataTableToString(dt);
            stripEmpName.Text = employee + "        ";

            dt2 = nextShift.GetShiftDetails(Form1.user);
            shift = nextShift.ConvertDataTableToString(dt2);
            DateTime date = nextShift.dateTime;
            stripNextShift.Spring = true;
            stripNextShift.Text = "Next Shift:  " + date.ToShortDateString() + "   " + nextShift.nextShift;

        }

        private void cbJobCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbJobCode.Text;
            cbAccount.DisplayMember = "Name";
            cbAccount.ValueMember = "ID";
            cbAccount.DataSource = clientName.GetClientNameWithJobCode(name);

            dt.Clear();
            dt = endDate.GetEndDateWithJobCode(name);
            deadline = endDate.ConvertDataTableToString(dt);
            txtDeadline.Text = deadline;
        }
    }
}
