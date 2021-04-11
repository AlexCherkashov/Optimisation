using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Optimization
{
    public class DatabaseConnection
    {
        private static SQLiteConnection sql_con = new SQLiteConnection("DataSource=optimization.db");

        public static void LoadDataTable(string table, DataGridView dataGrid)
        {
            try
            {
                sql_con.Open();
                string CommandText = "select * from " + table;
                SQLiteDataAdapter DB = new SQLiteDataAdapter(CommandText, sql_con);
                DataSet DS = new DataSet();
                DB.Fill(DS);
                dataGrid.DataSource = DS.Tables[0];
            }
            catch
            {
                MessageBox.Show("Невозможно загрузить данные из базы", "Ошибка!");
            }
            finally
            {
                sql_con.Close();
            }
        }

        public static void ExecuteQuery(string txtQuery)
        {
            try
            {
                sql_con.Open();
                SQLiteCommand sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                sql_cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка с базой данных!", "Ошибка!");
                return;
            }
            finally
            {
                sql_con.Close();
            }

            MessageBox.Show("Запрос выполнен!");
        }

        public static Tuple<bool, string> GetPassword(string login)
        {
            Tuple<bool, string> result = null;
            try
            {
                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand
                {
                    Connection = sql_con,
                    CommandText = $"select isAdmin, password from users where name =\"{login}\""
                };
                SQLiteDataReader sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    bool isAdmin = sqlReader.GetBoolean(0);
                    string password = sqlReader.GetString(1);
                    result = new Tuple<bool, string>(isAdmin, password);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка с доступом к базе данных", "Ошибка");
                return null;
            }
            finally
            {
                sql_con.Close();
            }

            return result;
        }

        public static bool IsUserExsist(string user)
        {
            bool isExsist = true;
            sql_con.Open();
            SQLiteCommand command = new SQLiteCommand
            {
                Connection = sql_con,
                CommandText = $"select count() from users where name=\"{user}\""
            };
            SQLiteDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                isExsist = sqlReader.GetBoolean(0);
            }
            sql_con.Close();
            return isExsist;
        }

        public static bool IsLastAdmin(int id)
        {
            int count = 0;
            sql_con.Open();
            SQLiteCommand command = new SQLiteCommand
            {
                Connection = sql_con,
                CommandText = $"select count() from users where isAdmin = 1"
            };
            SQLiteDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                count = sqlReader.GetInt32(0);
            }

            bool isAdmin = false;
            command = new SQLiteCommand
            {
                Connection = sql_con,
                CommandText = $"select isAdmin from users where id = {id}"
            };
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                isAdmin = sqlReader.GetBoolean(0);
            }
            sql_con.Close();

            return isAdmin && (count == 1);
        }
    }
}
