using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using шаблон_приложения.DataSet1TableAdapters;

namespace шаблон_приложения
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Проверка на пустые поля
            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            // Проверка пользователя
            var adapter = new usersTableAdapter();
            var user = adapter.GetData().FirstOrDefault(u => u.login == login);

            if (user == null)
            {
                MessageBox.Show("Пользователь не найден!");
                return;
            }

            if (user.password != password)
            {
                MessageBox.Show("Неверный пароль!");
                count++;
                
                if (count == 3)
                {
                    MessageBox.Show("Превышено количество попыток ввода! ББ");
                    this.Close();
                    return;
                }
                return;
            }

            // Успешная авторизация
            
            new Main(user.role_id).Show();
            this.Hide();
        }

        
    }
}