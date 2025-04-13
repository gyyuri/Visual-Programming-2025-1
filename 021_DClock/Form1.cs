using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_DClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick; //아래에 이벤트 자동 등록됨

            lblDate.Font = new Font("맑은고딕", 16, FontStyle.Bold);
            lblDate.ForeColor = Color.DarkOrange;

            lblTime.Font = new Font("맑은고딕", 32, FontStyle.Bold);
            lblTime.ForeColor = Color.DarkBlue;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일"); //m: 분,M: 월
            lblTime.Text = DateTime.Now.ToString("tt h:mm:ss"); //tt: 오전/오후. H:24시간제, h: 12시간제

            lblDate.Location = new Point(ClientSize.Width / 2 - lblDate.Width / 2,
                ClientSize.Height / 2 - lblDate.Height / 2 -30);

            lblTime.Location = new Point(ClientSize.Width / 2 - lblTime.Width / 2,
                ClientSize.Height / 2 - lblTime.Height / 2+20);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //this: 현재 class 의미
        }
    }
}
