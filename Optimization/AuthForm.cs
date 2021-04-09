using System;
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
            string login = loginTextBox.Text;
            object result = DatabaseConnection.GetPassword(login);

            if (result == null)
            {
                WrongInput();
                return;
            }

            string dbPassword = result.ToString();
            if (!Hashing.VerifyHash(passTextBox.Text, dbPassword))
            {
                WrongInput();
                return;
            }

            switch (login)
            {
                case "admin":
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    break;
                case "user":
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    break;
                default:
                    WrongInput();
                    return;
            }
        }

        private void WrongInput()
        {
            MessageBox.Show("Неверный логин или пароль", "Ошибка!");
        }
    }
}
