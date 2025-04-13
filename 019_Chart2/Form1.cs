using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_Chart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("중간고사 성적");

            //Series 하나 추가(Series1은 default)
            chart1.Series.Add("Series2");


            //레전드
            chart1.Series[0].LegendText = "국어";
            chart1.Series[1].LegendText = "수학";

            Random r = new Random();
            for (int i =0; i<10; i++)
            {
                chart1.Series[0].Points.AddXY(i, r.Next(101)); 
                chart1.Series[1].Points.AddXY(i, r.Next(101));
                
            }
        }

        //나누어 그리기: chartArea 추가하고, series와 매핑
        private void btnTwoChart_Click(object sender, EventArgs e)
        { 
            if(chart1.ChartAreas.Count == 1) //chart가 1개일때만 나누기
            {
                chart1.ChartAreas.Add("ChartArea2");  //차트 컨트롤에 새로운 차트 영역을 추가함.
                chart1.Series[1].ChartArea = "ChartArea2";  //chart1의 두 번째 시리즈(Series[1]) 가 "chartArea2" 차트 영역을 사용하도록 지정
            }

        }

        private void btnOneChart_Click(object sender, EventArgs e)
        {
            if(chart1.ChartAreas.Count == 2) //chart가 2개일때만 삭제
            {
                chart1.ChartAreas.RemoveAt(1);  //두 번째(1번 인덱스) 차트 영역을 제거
                chart1.Series[1].ChartArea = "ChartArea1";  //chart1의 두 번째 시리즈(Series[1])가 "ChartArea1" 차트 영역을 사용하도록 설정
            }
        }
    }
}
