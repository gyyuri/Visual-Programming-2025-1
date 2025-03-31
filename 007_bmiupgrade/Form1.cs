using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_bmiupgrade
{
    public partial class bmiForm : Form
    {
        public bmiForm()
        {
            InitializeComponent();
        }

      

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);
            h /= 100;

            double bmi = w / (h * h);


            lblBMI.Text = string.Format("당신의 BMI = {0:F1}", bmi);
            //lblBMI.Text = "BMI: " + bmi.ToString();

            //비만도 판정
            if (bmi >= 40)
            {
                lblResult.Text = "판정: 고도비만";
                pictureBox1.BackColor = Color.Red;
            }
            else if(bmi >= 30) //(30 <= bmi && bmi < 40)  *블록잡고 ctrl + kc : Comment
            {
                lblResult.Text = "판정: 비만";
                pictureBox1.BackColor = Color.OrangeRed;
            }
            else if (bmi >= 25) //(25 <= bmi && bmi < 30)
            {
                lblResult.Text = "판정: 경도비만";
                pictureBox1.BackColor = Color.YellowGreen;
            }
            else if (bmi >= 20) //(20 <= bmi && bmi < 25)
            {
                lblResult.Text = "판정: 정상체중";
                pictureBox1.BackColor = Color.Green;
            }
            else {
                lblResult.Text = "판정: 저체중";
                pictureBox1.BackColor = Color.Blue;
            }
        }

    }
}
