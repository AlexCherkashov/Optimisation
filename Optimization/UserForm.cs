using System;
using System.Windows.Forms;

namespace Optimization
{
    public partial class UserForm : Form
    {

        public UserForm()
        {
            InitializeComponent();
            DatabaseConnection.LoadDataTable("params", dataGridParams);
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            //labelDrawing.Text = "";

            InputData inputData = new InputData
            {
                leftBorderA1 = (double)LeftBorderA1Num.Value,
                rightBorderA1 = (double)RightBorderA1Num.Value,
                leftBorderA2 = (double)LeftBorderA2Num.Value,
                rightBorderA2 = (double)RightBorderA2Num.Value,
                step = (double)StepNum.Value,

                alpha = (double)alphaNum.Value,
                alpha1 = (double)alpha1Num.Value,
                betta = (double)bettaNum.Value,
                betta1 = (double)betta1Num.Value,
                mu = (double)muNum.Value,
                mu1 = (double)mu1Num.Value,
                N = (double)NNum.Value,
                V1 = (double)V1Num.Value,
                V2 = (double)V2Num.Value,

                workShift = (double)WorkShiftNum.Value,
                costPrice = (double)CostPriceNum.Value,
                accuracy = (double)AccuracyNum.Value,
                maxCount = (double)MaxCountNum.Value
            };

            if (inputData.leftBorderA1 > inputData.rightBorderA1 || inputData.leftBorderA2 > inputData.rightBorderA2)
            {
                MessageBox.Show("Левая граница не может быть больше правой", "Ошибка!");
                return;
            }

            if (inputData.accuracy > inputData.step)
            {
                MessageBox.Show("Погрешность не может быть больше шага", "Ошибка!");
                return;
            }

            IMethod method = null;
            if (radioBox.Checked)       method = new BoxMethod();
            if (radioScanning.Checked)  method = new ScanningMethod();

            double func(double x, double y)
            {
                return Math.Pow(inputData.alpha * (x * x + inputData.betta * y - inputData.mu * inputData.V1), inputData.N) +
                       Math.Pow(inputData.alpha1 * (inputData.betta1 * x + y * y - inputData.mu1 * inputData.V2), inputData.N);
            }

            try
            {
                Point result = method.GetMinimumValue(inputData, func);
                double minPrice = Math.Round(inputData.workShift * inputData.costPrice * result.Value, 0);
                double minF = Math.Round(result.Value, 3);
                double optimalA1 = Math.Round(result.X, 3);
                double optimalA2 = Math.Round(result.Y, 3);

                labelResult.Text = "Минимальное значение целевой функции: " + minF + " кг/ч\r\nОптимальное значение А1: "
                    + optimalA1 + " м^3/ч\r\nОптимальное значение А2: " + optimalA2 + " м^3/ч\r\n\r\nМинимальная себестоимость" +
                    " целевого\r\nпродукта за рабочую смену: " + minPrice + " у.е.";
            }
            catch (CalculationMethodException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }

            //int lengthA1 = (int)(RightBorderA1Num.Value - LeftBorderA1Num.Value);
            //int lengthA2 = (int)(RightBorderA2Num.Value - LeftBorderA2Num.Value);

            //labelDrawing.Text = "Отрисовка...";

            //var userControl2D = elementHost1.Child as wpf.UserControl2D;
            //userControl2D.Drawing2D(inputData.alpha, inputData.alpha1, inputData.betta, inputData.betta1, inputData.mu, inputData.mu1, inputData.N, inputData.V1, inputData.V2,
            //(int)LeftBorderA1Num.Value, (int)LeftBorderA2Num.Value, lengthA1, lengthA2);

            //var userControl3D = elementHost2.Child as wpf.UserControl3D;
            //userControl3D.Drawing3D(inputData.alpha, inputData.alpha1, inputData.betta, inputData.betta1, inputData.mu, inputData.mu1, inputData.N, inputData.V1, inputData.V2,
            //(int)LeftBorderA1Num.Value, (int)LeftBorderA2Num.Value, lengthA1, lengthA2);

            //labelDrawing.Text = "Отрисовка окончена";
        }

        private void dataGridParams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
            }
            catch
            {

            }
        }
    }
}

