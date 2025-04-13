using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; //라이브러리 추가 설정

namespace _020_Chart3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Paint 이벤트 처리 함수 ▶ 시작할때부터
        protected override void OnPaint(PaintEventArgs e)
        {
            //배경색 검은색
            chart1.ChartAreas[0].BackColor = Color.Black;


            //ChartArea의 x축 설정
            chart1.ChartAreas[0].AxisX.Minimum = -20;
            chart1.ChartAreas[0].AxisX.Maximum = 20;
            chart1.ChartAreas[0].AxisX.Interval = 2; //간격
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            
            //ChartArea의 y축 설정 (Alt키 누른 상태에서 드레그 X->Y 한번에 변경)
            chart1.ChartAreas[0].AxisY.Minimum = -2;
            chart1.ChartAreas[0].AxisY.Maximum = 2;
            chart1.ChartAreas[0].AxisY.Interval = 0.5; //간격
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            //Series[0] 설정: sin(x)/x
            chart1.Series[0].ChartType = SeriesChartType.Line;  //선그래프 설정
            chart1.Series[0].Color = Color.LightGreen;
            chart1.Series[0].BorderWidth = 2; //굵기
            chart1.Series[0].LegendText = "sin(x)/x";

            //Series[1] 설정: cos(x)/x
            if (chart1.Series.Count == 1)
            {
                chart1.Series.Add("Cos"); //Cos -> Series[1]이 됨
                chart1.Series[1].ChartType = SeriesChartType.Line;  //선그래프 설정
                chart1.Series[1].Color = Color.Orange;
                chart1.Series[1].BorderWidth = 2; //굵기
                chart1.Series[1].LegendText = "cos(x)/x";
            }


            //Series에 데이터 추가
            for(double x=-20; x<=20; x += 0.1)
            {
                double y = Math.Sin(x) / x;
                chart1.Series[0].Points.AddXY(x, y);

                y = Math.Cos(x) / x;
                chart1.Series[1].Points.AddXY(x, y);
            }

        }

    }
}
