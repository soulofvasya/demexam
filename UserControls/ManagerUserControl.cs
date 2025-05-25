using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace шаблон_приложения.UserControls
{
    public partial class ManagerUserControl : UserControl
    {
        public ManagerUserControl()
        {
            InitializeComponent();
            bookingsTableAdapter.Fill(dataSet1.bookings);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (dataSet1.HasChanges())
            {
                // Сохраняем изменения в БД
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bookingsTableAdapter.Update(dataSet1.bookings);
                    MessageBox.Show("Данные успешно сохранены.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    bookingsTableAdapter.Fill(dataSet1.bookings);
                }
            }
            else if (!dataSet1.HasChanges())
            {
                MessageBox.Show("Нет изменений для сохранения.");
            }
            else
            {
                MessageBox.Show("Ошибка, обратитесь к администратору");
            }
        }
    }
}
