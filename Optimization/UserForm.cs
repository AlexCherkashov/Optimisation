using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using wpf = _2dWPF;

namespace Optimization
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {

            labelDrawing.Text = "";

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

            bool isBox = radioBox.Checked;
            Point result;
            if (isBox)
                result = BoxMethod.GetMinimumValue(inputData);
            else 
                result = HalfDivisionMethod.GetMinimumValue(inputData);

            double minPrice = Math.Round(inputData.workShift * inputData.costPrice * result.Value, 0);
            double minF = Math.Round(result.Value, 3);
            double optimalA1 = Math.Round(result.X, 3);
            double optimalA2 = Math.Round(result.Y, 3);

            labelResult.Text = "Минимальное значение целевой функции: " + minF + " кг/ч\r\nОптимальное значение А1: "
                + optimalA1 + " м^3/ч\r\nОптимальное значение А2: " + optimalA2 + " м^3/ч\r\n\r\nМинимальная себестоимость" +
                " целевого\r\nпродукта за рабочую смену: " + minPrice + " у.е.";

            int lengthA1 = (int)(RightBorderA1Num.Value - LeftBorderA1Num.Value);
            int lengthA2 = (int)(RightBorderA2Num.Value - LeftBorderA2Num.Value);

            //labelDrawing.Text = "Отрисовка...";

            var userControl2D = elementHost1.Child as wpf.UserControl2D;
            //userControl2D.Drawing2D(inputData.alpha, inputData.alpha1, inputData.betta, inputData.betta1, inputData.mu, inputData.mu1, inputData.N, inputData.V1, inputData.V2,
                             //(int)LeftBorderA1Num.Value, (int)LeftBorderA2Num.Value, lengthA1, lengthA2);

            var userControl3D = elementHost2.Child as wpf.UserControl3D;
            //userControl3D.Drawing3D(inputData.alpha, inputData.alpha1, inputData.betta, inputData.betta1, inputData.mu, inputData.mu1, inputData.N, inputData.V1, inputData.V2,
                             //(int)LeftBorderA1Num.Value, (int)LeftBorderA2Num.Value, lengthA1, lengthA2);

            //labelDrawing.Text = "Отрисовка окончена";


        }
    }
}

