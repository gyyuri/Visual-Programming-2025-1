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
    public partial class Form1 : Form //public partial 부분 공용 클래스 / Form 클래스를 상속받은 Form1 클래스
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

            titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
            crds = new ComboBox[] {crd1, crd2, crd3, crd4, crd5, crd6, crd7};
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };

            int[] arrCredit = { 1, 2, 3, 4, 5 };
            List<String> lstGrade = new List<String> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };
            //배열ver: string[] Gradelst = new string[] { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };

            foreach (var combo in crds) //foreach with collection
            {
                foreach (var i in arrCredit)
                    combo.Items.Add(i);
                combo.SelectedItem = 2; //2를 default로(직접 설정)
                //combo.SelectedIndex = 2; //index num기준
            }

            foreach(var combo in grds)
            {
                foreach (var i in lstGrade)
                    combo.Items.Add(i);
                combo.SelectedItem = "A+";
            }

            /* 배열ver foreach문
             foreach(var combo in grds)
            {
                foreach (var i in Gradelst)
                    combo.Items.Add(i);
                combo.SelectedItem = "A+";
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tScore = 0;
            double tCredits = 0;

            for(int i=0; i<crds.Length; i++)
            {
                if (titles[i].Text != "")
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    tCredits += crd;
                    tScore += (crd * GetScore(grds[i].SelectedItem.ToString()));
                }
            }
            txtGrade.Text = (tScore / tCredits).ToString("F2");
        }

        private double GetScore(string v)
        {
            if (v == "A+") return 4.5;
            else if (v == "A0") return 4.0;
            else if (v == "B+") return 3.5;
            else if (v == "B0") return 3.0;
            else if (v == "C+") return 2.5;
            else if (v == "C0") return 2.0;
            else if (v == "D+") return 1.5;
            else if (v == "D0") return 1.0;
            else return 0;
        }
    }
}
