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
    public partial class Auth : Form
    {
        private DataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        public Auth()
        {
            InitializeComponent();
            usersTableAdapter = new DataSet1TableAdapters.usersTableAdapter();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин или пароль!");
            }
            else
            {
                DataSet1.usersDataTable users = usersTableAdapter.GetData();

                // Ищем пользователя с введенным логином
                DataSet1.usersRow user = users.FirstOrDefault(u => u.login == login);
                if (user == null)
                {
                    MessageBox.Show("Пользователь с таким логином не найден!");
                }
                else if (user.password != password)
                {
                    MessageBox.Show("Неверный пароль!");
                }
                else
                {
                    MessageBox.Show("Авторизация успешна!");
                    Main main = new Main(user.role);
                    main.Show();
                    this.Hide();
                }
            }
        }
    }
}