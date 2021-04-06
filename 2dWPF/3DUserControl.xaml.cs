using System;
using System.Windows.Controls;
using SciChart.Charting3D.Model;
using SciChart.Charting.Visuals;

namespace _2dWPF
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl3D : UserControl
    {
        public UserControl3D()
        {
            // Set this code once in App.xaml.cs or application startup
            //SciChartSurface.SetRuntimeLicenseKey("wQ3ubo6xxwmyuf9HPLLBkrmuh37aKwUwPc4SpMd++em/4gwJXNuG/7ypSaCHlH3gPXdJ9n4LQOICLqA4pYThVGTWqKL1/C6mxbLMwT5WhHha5Fl+aIXVQWio5vUTutcQU0oegcT8y3PTiDRxN7z0R5eyPQZJaCdzhXhBdeAkIk9hTxur4b2UYQ8sZycPhc/No0zZl1ANa25T/m+FYPtpYMDl+3qQ6fK+C1VpV+IheFPldCqyEJ/NJVMV0OtLMz4WrTUNFsnthwg0oHez0bdimaHV6d6M1VsGUAkpnmZ5B9BA9eY71ZEvqFrJTjKwOA+oZ8x3BYiu0mGx9qPOPCpFwEjtp+B0rcYkWX7EniTf9/SCz+PstMLCM8aNJsLlrwIG1B85SQq37hPBVp+ROdhl+zkoR9SKD1gQPUQVnH4aZ1pQZtkUZyzgYl8ekUEJrV9Cki58/5CQcAb9eDm8ID0MMHdqdaW3tm2bJR9kXc9hF6pA12ZIbjpmKqDrsQAsoXITgB4XxkeDoxDw5sbBWfjz3tYE5Ji3+4czmaEIuHLDr9hxTVsjDwl34/aZqdzw886RB34GVH1o94CTvPDM");
            InitializeComponent();

            //var meshDataSeries = FillSeries(10, 10);
            //surfaceMeshRenderableSeries.DataSeries = meshDataSeries;
            
        }

        private IDataSeries3D FillSeries(double alpha, double alpha1, double betta, double betta1, double mu, double mu1,
                                         double N, double V1, double V2, int startX, int startY, int lengthX, int lengthY)
        {
           int w = lengthY, h = lengthX;

            var dataSeries = new UniformGridDataSeries3D<double>(h, w)
            {
                StepX = 1,
                StepZ = 1,
            };

            for (int x = startX; x < h; x++)
            {
                for (int y = startY; y < w; y++)
                {
                    dataSeries[x, y] = Math.Pow(alpha * (x * x + betta * y - mu * V1), N) +
                                       Math.Pow(alpha1 * (betta1 * x + y * y - mu1 * V2), N);
                }
            }
            return dataSeries;
        }

        public void Drawing3D(double alpha, double alpha1, double betta, double betta1, double mu, double mu1,
                         double N, double V1, double V2, int startX, int startY, int lengthX, int lengthY)
        {
            var meshDataSeries = FillSeries(alpha, alpha1, betta, betta1, mu, mu1, N, V1, V2, startX, startY, lengthX, lengthY);
            surfaceMeshRenderableSeries.DataSeries = meshDataSeries;
        }
    }
}
