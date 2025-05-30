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
    public partial class Main : Form
    {
        private int _userRole;
        public Main(int userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            if (_userRole == 1) //админ
            {
                adminToolStripMenuItem.Visible = true;
                servicesToolStripMenuItem.Visible = true;
                bookingServicesToolStripMenuItem.Visible = true;
                bookingsToolStripMenuItem.Visible = true;
                guestsToolStripMenuItem.Visible = true;
                shiftsToolStripMenuItem.Visible = true;
                employeesToolStripMenuItem.Visible = true;
            }
            else if (_userRole == 2)//менеджер
            {
                servicesToolStripMenuItem.Visible = true;
                employeesToolStripMenuItem.Visible = true;
                shiftsToolStripMenuItem.Visible = true;
            }
        }

        
        

       

        private void guestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очистка текущего содержимого панели
            panelContent.Controls.Clear();
            // Добавление нового UserControl
            GuestsUserControl guestsTable = new GuestsUserControl();
            guestsTable.Dock = DockStyle.Fill; // Занимает всю панель
            panelContent.Controls.Add(guestsTable);
        }

        private void bookingServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очистка текущего содержимого панели
            panelContent.Controls.Clear();
            // Добавление нового UserControl
            BookingServicesUserControl bsTable = new BookingServicesUserControl();
            bsTable.Dock = DockStyle.Fill; // Занимает всю панель
            panelContent.Controls.Add(bsTable);
        }
    }
}
