using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var user = (new BLUser()).Get(StaticVariables.userName);

            lblUserName.Text = user.UserName;
            lblFullname.Text = user.FullName;

            if (user.Group != null)
            {
                lblGroupName.Text = user.Group.GroupName;
                dataGridView1.DataSource = user.Group.Roles;
            }
            if (user.Roles != null)
            {
                dataGridView2.DataSource = user.Roles;
            }
        }
    }
}
