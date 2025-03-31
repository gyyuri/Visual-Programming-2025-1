using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "abcd" && txtpw.Text == "1234")
            {
                txtResult.Text = "로그인 성공";
            }
            else
            {
                txtResult.Text = "로그인 실패";
            }
        }
    }
}
