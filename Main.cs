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
        private string _userRole;
        public Main(string userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            if (_userRole == "1") 
            {
                таблица1ToolStripMenuItem.Visible = true;
            }
            else if (_userRole == "2")
            {
                таблица1ToolStripMenuItem.Visible = false;
            }
        }

        private void таблица1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очистка
            foreach (Control c in Controls)
            {
                if (c != menuStrip1) Controls.Remove(c);
            }

            // Создание таблицы
            DataGridView dgv = new DataGridView();
            dgv.DataSource = usersTableAdapter.GetData();

            // Центрирование
            dgv.Location = new Point(
                (Width - dgv.Width) / 2,
                menuStrip1.Height + (Height - menuStrip1.Height - dgv.Height) / 2
            );

            Controls.Add(dgv);
        }
    }
}
