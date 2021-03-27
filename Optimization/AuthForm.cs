using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimization
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int login = loginTextBox.Text.GetHashCode();
            int password = passTextBox.Text.GetHashCode();

            if (login == (int)Hashes.login && password == (int)Hashes.passwordUser)
            {
                UserForm userForm = new UserForm();
                userForm.Show();
            }
            else if (login == (int)Hashes.login && password == (int)Hashes.passwordAdmin)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль", "Ошибка");
            }
        }
    }
}
