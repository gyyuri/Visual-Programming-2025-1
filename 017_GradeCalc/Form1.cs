using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_GradeCalc
{
    public partial class Form1 : Form
    {
        TextBox[] titles; //교과목 텍스트 박스 배열
        ComboBox[] crds;  //학점 콤보박스 배열
        ComboBox[] grds;  //성적 콤보박스 배열

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의구조와기능I";
            txt2.Text = "일반수학I";
            txt3.Text = "웹프로그래밍";
            txt4.Text = "데이터 사이언스";
            txt5.Text = "비주얼프로그래밍";
            txt6.Text = "기업가정신";

            

        }
    }
}
