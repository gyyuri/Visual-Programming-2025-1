using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_ScoreCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //double sum = double.Parse(txtKor.Text + txtEng.Text + txtMath.Text);
            double sum = Convert.ToDouble(txtKor.Text) + Convert.ToDouble(txtEng.Text) + Convert.ToDouble(txtMath.Text);
            double avg = sum / 3;

            txtSum.Text = sum.ToString();
            txtAvg.Text = avg.ToString("F2");
            // #.## -> 결과값이 정수이면 소수점 출력 안됨
            // 0.00 -> 결과값이 정수여도 소수점 출력 됨
        }
    }
}
