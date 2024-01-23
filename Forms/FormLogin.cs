using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Npgsql;
using System.Windows.Forms;
using HomeWork_ISP_203_13_01.Forms;

namespace HomeWork_ISP_203_13_01
{
    public partial class LoginForm : Form
    {

        private string login = "";
        private string password = "";

        private int passwordCount = 3;
        public LoginForm()
        {
            InitializeComponent();
            UpdatePasswordCount("Кол-во попыток: " + passwordCount, Color.Black);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login = textBoxLogin.Text;
            password = textBoxPassword.Text;

            if (login.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Длина логина и пароля не должна быть ровна 0");
                return;
            }

            #region Получение данных
            string getedPassword = "";
            Program.connection.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT password FROM users WHERE login = '{login}';", Program.connection);
            try
            {
                getedPassword = command.ExecuteScalar().ToString();
                Program.connection.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Пользователя с таким именем не существует");
                Program.connection.Close();
                return;
            }
            #endregion
            

            if (getedPassword != textBoxPassword.Text)
            {
                passwordCount--;

                if (passwordCount == 0)
                {
                    MessageBox.Show("Количество попыток превысили допустимые нормы ввода пароля");
                    UpdatePasswordCount("Вход заблокирован", Color.Red);
                    buttonLogin.Enabled = false;
                    timerBlock.Start();
                    return;
                }

                UpdatePasswordCount("Кол-во попыток: " + passwordCount, Color.Black);
            }
            else
            {
                Form formMain = new FormMain(login);
                formMain.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Метод изменения параметров строки под вводом пароля
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        private void UpdatePasswordCount(string text, Color color)
        {
            labelPasswordCount.Text = text;
            labelPasswordCount.ForeColor = color;
        }

        private void buttonRegistor_Click(object sender, EventArgs e)
        {
            Form registration = new FormRegistretion();
            registration.ShowDialog();
        }

        private void timerBlock_Tick(object sender, EventArgs e)
        {
            passwordCount = 3;
            buttonLogin.Enabled = true;
            UpdatePasswordCount("Кол-во попыток: " + passwordCount, Color.Black);   
            timerBlock.Stop();

        }
    }
}
