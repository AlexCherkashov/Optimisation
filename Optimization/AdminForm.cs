using System;
using System.Windows.Forms;

namespace Optimization
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
            DatabaseConnection.LoadDataTable("users", dataGridUsers);
            DatabaseConnection.LoadDataTable("params", dataGridParams);
        }

        private void ChangeUsersButton_Click(object sender, EventArgs e)
        {
            bool isCorrectID = Int32.TryParse(UserIDLabel.Text, out int id);
            if (!isCorrectID)
            {
                MessageBox.Show("Выберите запись из таблицы", "Ошибка!");
                return;
            }

            if (UserTextBox.Text == "")
            {
                MessageBox.Show("Заполните поле логина", "Ошибка!");
                return;
            }

            try
            {
                if (DatabaseConnection.IsLastAdmin(id) && !isAdminCheckBox.Checked)
                {
                    MessageBox.Show("Это последний администратор, не удаляйте его", "Ошибка!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка с базой данных!", "Ошибка!");
                return;
            }

            string login = UserTextBox.Text;
            int isAdmin = isAdminCheckBox.Checked ? 1 : 0;
            string password = Hashing.GetHash(textBoxPassword.Text);

            string CommandText = "update users set";
            if (textBoxPassword.Text.Length != 0) CommandText += $" password = \"{password}\",";
            CommandText += $" isAdmin = \"{isAdmin}\"," +
                           $" name = \"{login}\" where id = {id}";

            DatabaseConnection.ExecuteQuery(CommandText);

            DatabaseConnection.LoadDataTable("users", dataGridUsers);
        }

        private void dataGridUsers_CellClick(object sender, EventArgs e)
        {
            try
            {
                UserIDLabel.Text = dataGridUsers.SelectedRows[0].Cells[0].Value.ToString();
                UserTextBox.Text = dataGridUsers.SelectedRows[0].Cells[1].Value.ToString();
                isAdminCheckBox.Checked = dataGridUsers.SelectedRows[0].Cells[2].Value.ToString() == "1";
                textBoxPassword.Text = "";//dataGridUsers.SelectedRows[0].Cells[3].Value.ToString();
            } catch { }
        }

        private void dataGridParams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelID.Text = dataGridParams.SelectedRows[0].Cells[0].Value.ToString();
                LeftBorderA1Num.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[1].Value.ToString());
                RightBorderA1Num.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[2].Value.ToString());
                LeftBorderA2Num.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[3].Value.ToString());
                RightBorderA2Num.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[4].Value.ToString());
                StepNum.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[5].Value.ToString());

                alphaNum.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[6].Value.ToString());
                alpha1Num.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[7].Value.ToString());
                bettaNum.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[8].Value.ToString());
                betta1Num.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[9].Value.ToString());
                muNum.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[10].Value.ToString());
                mu1Num.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[11].Value.ToString());
                NNum.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[12].Value.ToString());
                V1Num.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[13].Value.ToString());
                V2Num.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[14].Value.ToString());

                WorkShiftNum.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[15].Value.ToString());
                CostPriceNum.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[16].Value.ToString());
                AccuracyNum.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[17].Value.ToString());
                MaxCountNum.Value = Decimal.Parse(dataGridParams.SelectedRows[0].Cells[18].Value.ToString());
            } catch { }
        }

        private void buttonAddParams_Click(object sender, EventArgs e)
        {
            string CommandText = $"insert into params(leftBorderA1, rightBorderA1, leftBorderA2, rightBorderA2, step," +
            $" alpha, alpha1, betta, betta1, mu, mu1, N, V1, V2, workShift, costPrice, accuracy, maxCount)" +
            $" values ({DecimalToString(LeftBorderA1Num.Value)},{DecimalToString(RightBorderA1Num.Value)}," +
                     $"{DecimalToString(LeftBorderA2Num.Value)},{DecimalToString(RightBorderA2Num.Value)}," +
                     $"{DecimalToString(StepNum.Value)}," +
                     $"{DecimalToString(alphaNum.Value)},{DecimalToString(alpha1Num.Value)}," +
                     $"{DecimalToString(bettaNum.Value)},{DecimalToString(betta1Num.Value)}," +
                     $"{DecimalToString(muNum.Value)},{DecimalToString(mu1Num.Value)}," +
                     $"{DecimalToString(NNum.Value)},{DecimalToString(V1Num.Value)},{DecimalToString(V2Num.Value)}," +
                     $"{DecimalToString(WorkShiftNum.Value)},{DecimalToString(CostPriceNum.Value)}," +
                     $"{DecimalToString(AccuracyNum.Value)},{DecimalToString(MaxCountNum.Value)})";
            DatabaseConnection.ExecuteQuery(CommandText);
            DatabaseConnection.LoadDataTable("params", dataGridParams);
        }

        private string DecimalToString(decimal value)
        {
            return value.ToString().Replace(',', '.');
        }

        private void buttonDeleteParams_Click(object sender, EventArgs e)
        {
            bool isCorrectID = Int32.TryParse(labelID.Text, out int id);
            if (!isCorrectID)
            {
                MessageBox.Show("Выберите запись из таблицы", "Ошибка!");
                return;
            }

            string CommandText = $"delete from params where id = {id}";
            DatabaseConnection.ExecuteQuery(CommandText);
            DatabaseConnection.LoadDataTable("params", dataGridParams);
        }

        private void buttonUpdateParams_Click(object sender, EventArgs e)
        {
            bool isCorrectID = Int32.TryParse(labelID.Text, out int id);
            if (!isCorrectID)
            {
                MessageBox.Show("Выберите запись из таблицы", "Ошибка!");
                return;
            }

            string CommandText = $"update params set " +
                $" leftBorderA1 = {DecimalToString(LeftBorderA1Num.Value)}," +
                $" rightBorderA1 = {DecimalToString(RightBorderA1Num.Value)}," +
                $" leftBorderA2 = {DecimalToString(LeftBorderA2Num.Value)}," +
                $" rightBorderA2 = {DecimalToString(RightBorderA2Num.Value)}," +
                $" step = {DecimalToString(StepNum.Value)}," +
                $" alpha = {DecimalToString(alphaNum.Value)}," +
                $" alpha1 = {DecimalToString(alpha1Num.Value)}," +
                $" betta = {DecimalToString(bettaNum.Value)}," +
                $" betta1 = {DecimalToString(betta1Num.Value)}," +
                $" mu = {DecimalToString(muNum.Value)}," +
                $" mu1 = {DecimalToString(mu1Num.Value)}," +
                $" N = {DecimalToString(NNum.Value)}," +
                $" V1 = {DecimalToString(V1Num.Value)}," +
                $" V2 = {DecimalToString(V2Num.Value)}," +
                $" workShift = {DecimalToString(WorkShiftNum.Value)}," +
                $" costPrice = {DecimalToString(CostPriceNum.Value)}," +
                $" accuracy = {DecimalToString(AccuracyNum.Value)}," +
                $" maxCount = {DecimalToString(MaxCountNum.Value)}" +
                $" where id = {id}";

            DatabaseConnection.ExecuteQuery(CommandText);
            DatabaseConnection.LoadDataTable("params", dataGridParams);
        }

        private void AddUsersButton_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Заполните поле логина и пароля", "Ошибка!");
                return;
            }

            string login = UserTextBox.Text;
            int isAdmin = isAdminCheckBox.Checked ? 1 : 0;
            string password = Hashing.GetHash(textBoxPassword.Text);
            if (DatabaseConnection.IsUserExsist(login))
            {
                MessageBox.Show("Пользователь с таким именем уже есть", "Ошибка!");
                return;
            }

            string CommandText = $"insert into users(name, isAdmin, password) values" +
                                $" (\"{login}\", {isAdmin}, \"{password}\")";
            DatabaseConnection.ExecuteQuery(CommandText);
            DatabaseConnection.LoadDataTable("users", dataGridUsers);
        }

        private void DeleteUsersButton_Click(object sender, EventArgs e)
        {
            bool isCorrectID = Int32.TryParse(UserIDLabel.Text, out int id);
            if (!isCorrectID)
            {
                MessageBox.Show("Выберите запись из таблицы", "Ошибка!");
                return;
            }
            try
            {
                if (DatabaseConnection.IsLastAdmin(id))
                {
                    MessageBox.Show("Это последний администратор, не удаляйте его", "Ошибка!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка с базой данных!", "Ошибка!");
                return;
            }

            string CommandText = $"delete from users where id = {id}";
            DatabaseConnection.ExecuteQuery(CommandText);
            DatabaseConnection.LoadDataTable("users", dataGridUsers);
        }
    }
}
