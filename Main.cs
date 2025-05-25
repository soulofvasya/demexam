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

        private void таблица1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очистка рабочей области
            foreach (Control c in Controls)
            {
                if (c != menuStrip1) Controls.Remove(c);
            }
            // заголовок
            Label label1 = new Label();
            label1.Text = "Таблица роли";
            label1.Location = new Point(150, 100);
            // таблица
            DataGridView dgv = new DataGridView();
            dgv.DataSource = usersTableAdapter.GetData();
            dgv.Size = new Size(450, 200);
            dgv.Location = new Point(150, 150);
            // добавление на форму
            Controls.Add(dgv);
            Controls.Add(label1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
