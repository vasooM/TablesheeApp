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
using Tablesheet.Infrastructure;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timesheet_Load(object sender, EventArgs e)
        {
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


        }

        private void cbJobCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbJobCode.Text;
            cbAccount.DisplayMember = "Name";
            cbAccount.ValueMember = "ID";
            cbAccount.DataSource = clientName.GetClientNameWithJobCode(name);

            txtDeadline.Text = endDate.GetEndDateWithJobCode(name).ToString();
        }
        
    }
}
