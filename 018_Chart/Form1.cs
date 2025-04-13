using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Random r = new Random();

            chart1.Titles.Add("성적"); //차트 제목 설정

            for(int i=0; i<10; i++) //10개 데이터 생성
            {
                //chart1.Series[0].Points.Add((i + 1) * 10); //Series[0]에 10개의 데이터 추가
                chart1.Series[0].Points.Add(r.Next(101));  //Next(num): 지정된 최대값(num)보다 작은 음수가 아닌 임의의 정수를 반환
            }
            chart1.Series[0].LegendText = "비주얼\n프로그래밍"; //범례제목 설정
        }
    }
}
