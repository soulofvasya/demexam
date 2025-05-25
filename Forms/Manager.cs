using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using шаблон_приложения.DataSet1TableAdapters;
using шаблон_приложения.UserControls;

namespace шаблон_приложения
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_manager.Controls.Clear();
            ManagerUserControl managerUserControl = new ManagerUserControl();
            panel_manager.Controls.Add(managerUserControl);
        }
    }
}
