using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Optimization
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con = new SQLiteConnection("DataSource=optimization.db;Version=3;New=False;Compress=True");

        private void StartButton_Click(object sender, EventArgs e)
        {

            string login = loginTextBox.Text;
            string password = passTextBox.Text.GetHashCode().ToString();
            object result = null;
            try
            {
                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand
                {
                    Connection = sql_con,
                    CommandText = $"select password FROM users where name =\"{login}\""
                };
                SQLiteDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                    result = sqlReader.GetValue(0);
            }
            catch
            {
                MessageBox.Show("Ошибка с доступом к базе данных", "Ошибка");
                return;
            }
            finally
            {
                sql_con.Close();
            }

            if (result == null)
            {
                WrongInput();
                return;
            }

            string dbPassword = result.ToString();
            if (!(dbPassword == password))
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
