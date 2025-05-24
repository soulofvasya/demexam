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

namespace шаблон_приложения
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.bookings". При необходимости она может быть перемещена или удалена.
            this.bookingsTableAdapter.Fill(this.dataSet1.bookings);

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (dataSet1.HasChanges())
            {
                bookingsTableAdapter.Update(this.dataSet1.bookings);
                MessageBox.Show("Данные успешно сохранены!");
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
