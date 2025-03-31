using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_1_Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {            
            if (txtC.Text != "")
            {
                double F = double.Parse(txtC.Text) * 9 / 5 + 32;
                txtF.Text = F.ToString("#.##"); //#.## 소수점 2자리
            }
            else if(txtF.Text != "")
            {
                double C = (double.Parse(txtF.Text) - 32) * 5 / 9;
                txtC.Text = C.ToString("#.##");
            }
            if (txtC.Text == "" && txtF.Text == "")
                return;
        }
    }
}
