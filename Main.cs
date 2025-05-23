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
    }
}
