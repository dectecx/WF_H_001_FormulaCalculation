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
                double.TryParse(LTB.Text, out double L))
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
                    L = L
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
