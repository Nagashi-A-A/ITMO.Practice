using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ITMO.Y2020.G124.Yaroshchuk.M5.E3.Chart
{
    public partial class ChartForm : Form
    {
        static int k = 10;
        Dat d1 = new Dat(k);
        int testD = 10;
        string testS = "Wind m/s";

        private void chartPlot(int d, string leg)
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 1; i <= k; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, d1.random(d));
            }

            chart1.Series["Series1"].ChartType = SeriesChartType.SplineArea;
                chart1.Series["Series1"].IsValueShownAsLabel = true;
                    chart1.Series["Series1"].LegendText = leg;

            if (checkBox1.Checked == true)
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            else
                chart1.Series["Series1"].ChartType = SeriesChartType.SplineArea;
        }

        public ChartForm()
        {
            InitializeComponent();

            //for (int i = 1; i <= k; i++)
            //{
            //    chart1.Series["Series1"].Points.AddXY(i, d1.random(10));
            //}
            //chart1.Series["Series1"].ChartType = SeriesChartType.SplineArea;
            //    chart1.Series["Series1"].IsValueShownAsLabel = true;
            //        chart1.Series["Series1"].LegendText = "Wind m/s";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (HumidityRadioButton.Checked == true)
            {
                chartPlot(100, "Humidity");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (TemperatureRadioButton.Checked == true)
            {
                chartPlot(30, "Temperature");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //    chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            //else
            //    chart1.Series["Series1"].ChartType = SeriesChartType.SplineArea;
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            ChartForm newChartForm = new ChartForm();
            newChartForm.chartPlot(testD, testS);
        }
    }
}
