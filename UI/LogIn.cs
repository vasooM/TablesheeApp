using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tablesheet.Core;

namespace Tablesheet.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LogInBLL objLog = new LogInBLL();
        ScheduleBLL objSch = new ScheduleBLL();
        DataTable dt = new DataTable();

        public static string user = string.Empty;
        string pass = string.Empty;

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            pass = txtPass.Text;
            dt = objLog.GetUsernameAndPassword(user, pass);
            
            if (dt.Rows.Count > 0)
            {
                this.Hide();

                Timesheet ts = new Timesheet();
                ts.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}