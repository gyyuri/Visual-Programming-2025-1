using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_Test
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
                double c_in = double.Parse(txtC.Text);
                double h = c_in * 9 / 5 + 32;
                txtH.Text = h.ToString("F2");
            }
            else if (txtH.Text != "")
            {
                double h_in = double.Parse(txtH.Text);
                double c = (h_in - 32) * 5 / 9;
                txtC.Text = c.ToString("F2");
            }
            else if(txtH.Text =="" && txtC.Text == "")
            {
                MessageBox.Show("섭씨온도나 화씨온도 중 하나를 입력하세요.", "Warning");
            }
        }
    }
}
