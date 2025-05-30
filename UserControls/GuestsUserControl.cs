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
    public partial class GuestsUserControl : UserControl
    {
        public GuestsUserControl()
        {
            InitializeComponent();
            guestsTableAdapter.Fill(dataSet1.guests);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                guestsBindingSource.EndEdit(); // Завершение редактирования
              // Сохранение изменений в базе данных
                int rowsAffected = guestsTableAdapter.Update(dataSet1.guests);
                MessageBox.Show($"Изменения сохранены. Строк затронуто: {rowsAffected}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        private void updateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                guestsTableAdapter.Fill(dataSet1.guests);
                MessageBox.Show($"Данные обнолвены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении: " + ex.Message);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены, что хотите удалить  выбранные строки? При удалении гостя будут удалены все связанные с ним записи в БД", "Предупреждение", MessageBoxButtons.YesNo);
        }
    }
}
