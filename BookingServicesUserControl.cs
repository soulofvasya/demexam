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
    public partial class BookingServicesUserControl : UserControl
    {
        public BookingServicesUserControl()
        {
            InitializeComponent();
            booking_servicesTableAdapter.Fill(dataSet1.booking_services);
            servicesTableAdapter.Fill(dataSet1.services);
            bookingsTableAdapter.Fill(dataSet1.bookings);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                bookingservicesBindingSource.EndEdit(); // Завершение редактирования
                                               // Сохранение изменений в базе данных
                int rowsAffected = booking_servicesTableAdapter.Update(dataSet1.booking_services);
                MessageBox.Show($"Изменения сохранены. Строк затронуто: {rowsAffected}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        private void refreshToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                booking_servicesTableAdapter.Fill(dataSet1.booking_services);
                servicesTableAdapter.Fill(dataSet1.services);
                bookingsTableAdapter.Fill(dataSet1.bookings);
                MessageBox.Show($"Данные обнолвены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении: " + ex.Message);
            }
        }
    }
}
