using System;
using System.Windows.Forms;
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
