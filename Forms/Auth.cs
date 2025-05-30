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
        private static int error_counter = 0;
        private void button_auth_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }

            // Проверка пользователя
            var users = new usersTableAdapter().GetData().FirstOrDefault(user => user.login == login);

            if (users == null)
            {
                MessageBox.Show("Пользователь не найден!");
                return;
            }
            
            if (users.password != password)
            {
                MessageBox.Show("Неверный пароль!");
                error_counter++;
                if (error_counter == 3)
                {
                    MessageBox.Show("Слишком много неудачных попыток входа. Обратитесь к администратору.");
                    this.Hide();
                    return;
                }
                return;
            }
            
            if (users.role == 1)
            {
                new Admin().Show();
                this.Hide();
            }
            else if (users.role == 2)
            {
                new Manager().Show();
                this.Hide();
            }
            
            else
            {
                MessageBox.Show("Ошибка входа, такой роли не существует. Обратитесь к администратору.");
            }
        }
    }
}