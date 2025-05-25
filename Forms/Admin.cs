using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace шаблон_приложения
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_admin.Controls.Clear();
            AdminUserControl adminUserControl = new AdminUserControl();
            panel_admin.Controls.Add(adminUserControl);
        }
    }
}
