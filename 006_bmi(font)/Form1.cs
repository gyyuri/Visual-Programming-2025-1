﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_bmi_font_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {

            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);
            h /= 100;
            double bmi = w / (h * h);

            lblBMI.Text = "BMI = " + bmi;
        }
    }
}
