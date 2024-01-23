using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HomeWork_ISP_203_13_01.Forms
{
    public partial class FormRegistretion : Form
    {
        private string login = "";
        private string password = "";

        public FormRegistretion()
        {
            InitializeComponent();
        }
        
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            login = loginTextBox.Text;
            password = passwordTextBox.Text;

            #region Проверки правильности ввода
            if (password == "" || password.Length < 4)
            {
                MessageBox.Show("Введите пароль не меньше 4 символов");
                return;
            }
            if (login == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            #endregion

            #region Проверка на наличие пользователя
            string userLogin = "";
            Program.connection.Open();
            NpgsqlCommand selectLoginToCheck = new NpgsqlCommand($"SELECT login FROM users WHERE login = '{login}'", Program.connection);
            try
            {
                userLogin = selectLoginToCheck.ExecuteScalar().ToString();
            }
            catch (NullReferenceException) { }

            Program.connection.Close();

            if (login == userLogin)
            {
                MessageBox.Show("Имя пользователя занято");
                return;
            }
            #endregion

            #region Диалоговое окно создания пользователя
            DialogResult confirmResult = MessageBox.Show($"Вы уверены что хотите зарегестрироваться под этим именем: {login}", "Потвердите выбор!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Program.connection.Open();

                NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"INSERT INTO public.users(login, password) VALUES ('{login}', '{password}');", Program.connection);
                npgsqlCommand.ExecuteNonQuery();

                this.Close();

                Program.connection.Close();
            }
            else
            {
                return;
            }
            #endregion
        }
    }
}
