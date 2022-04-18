﻿using System;
using System.Windows.Forms;
using WF_H_001.Models;

namespace WF_H_001
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            X1TB.Text = "-12";
            Y1TB.Text = "58";
            Z1TB.Text = "-150";
            XOCTB.Text = "0.06";
            YOCTB.Text = "-0.013";
            YOATB.Text = "0.0015";
            ZOATB.Text = "-530";
            LTB.Text = "150";
            ASTB.Text = "0";
            AETB.Text = "-30";
            AITB.Text = "-15";
            CSTB.Text = "0";
            CETB.Text = "360";
            CITB.Text = "30";
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(X1TB.Text, out double x1) &&
                double.TryParse(Y1TB.Text, out double y1) &&
                double.TryParse(Z1TB.Text, out double z1) &&
                double.TryParse(XOCTB.Text, out double xoc) &&
                double.TryParse(YOCTB.Text, out double yoc) &&
                double.TryParse(YOATB.Text, out double yoa) &&
                double.TryParse(ZOATB.Text, out double zoa) &&
                double.TryParse(LTB.Text, out double L) &&
                double.TryParse(ASTB.Text, out double as_) &&
                double.TryParse(AETB.Text, out double ae) &&
                double.TryParse(AITB.Text, out double ai) &&
                double.TryParse(CSTB.Text, out double cs) &&
                double.TryParse(CETB.Text, out double ce) &&
                double.TryParse(CITB.Text, out double ci))
            {
                var vo = new InputVo
                {
                    x1 = x1,
                    y1 = y1,
                    z1 = z1,
                    xoc = xoc,
                    yoc = yoc,
                    yoa = yoa,
                    zoa = zoa,
                    L = L,
                    AS = as_,
                    AE = ae,
                    AI = ai,
                    CS = cs,
                    CE = ce,
                    CI = ci,
                };
                var subForm = new SubForm(vo);
                subForm.Show();
            }
            else
            {
                MessageBox.Show("輸入內容有誤，請確認是否皆為數值");
                return;
            }
        }
    }
}
