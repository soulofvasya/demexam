using System;
using System.Windows.Forms;

namespace шаблон_приложения
{
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
            usersTableAdapter.Fill(dataSet1.users);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (dataSet1.HasChanges())
            {
                // Сохраняем изменения в БД
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    usersTableAdapter.Update(dataSet1.users);
                    MessageBox.Show("Данные успешно сохранены.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    usersTableAdapter.Fill(dataSet1.users);
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
