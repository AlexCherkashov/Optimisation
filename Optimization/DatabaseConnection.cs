using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Optimization
{
    public class DatabaseConnection
    {
        private static SQLiteConnection sql_con = new SQLiteConnection("DataSource=optimization.db;Version=3;New=False;Compress=True");

        public static void LoadDataTable(string table, DataGridView dataGrid)
        {
            sql_con.Open();
            SQLiteCommand sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from " + table;
            SQLiteDataAdapter DB = new SQLiteDataAdapter(CommandText, sql_con);
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGrid.DataSource = DT;
            sql_con.Close();
        }

        public static bool ExecuteQuery(string txtQuery)
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
                return false;
            }
            finally
            {
                sql_con.Close();
            }

            MessageBox.Show("Запрос выполнен!");
            return true;
        }

        public static object GetPassword(string login)
        {
            object result = new object();
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
                return null;
            }
            finally
            {
                sql_con.Close();
            }

            return result;
        }
    }
}
