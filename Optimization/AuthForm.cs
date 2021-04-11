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
            Tuple<bool, string> dbData = DatabaseConnection.GetPassword(login);

            if (dbData == null)
            {
                WrongInput();
                return;
            }

            bool isAdmin = dbData.Item1;
            string dbPassword = dbData.Item2;
            if (!Hashing.VerifyHash(passTextBox.Text, dbPassword))
            {
                WrongInput();
                return;
            }

            Form form = null;
            switch (isAdmin)
            {
                case true:
                    form = new AdminForm();
                    break;
                case false:
                    form = new UserForm();
                    break;
            }
            form.ShowDialog();
        }

        private void WrongInput()
        {
            MessageBox.Show("Неверный логин или пароль", "Ошибка!");
        }
    }
}
