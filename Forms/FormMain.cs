using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_ISP_203_13_01.Forms
{
    public partial class FormMain : Form
    {
        private string login;
        private bool swapForm = false;

        public FormMain(string login)
        {
            InitializeComponent();
            this.login = login;
            showLoginLabel.Text = login;
        }

        private void goSecondFormButton_Click(object sender, EventArgs e)
        {
            Form formSecond = new FormSecond(login);
            formSecond.Show();
            swapForm = true;
            this.Close();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!swapForm)
            {
                Application.Exit();
            }
        }
    }
}
