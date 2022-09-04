using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WF_H_001.FormulaCalculation.Models;
using WF_H_001.FormulaCalculation.Service;

namespace WF_H_001.FormulaCalculation
{
    public partial class SubForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly InputVo _vo;

        public SubForm(MainForm mainForm, InputVo vo)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _vo = vo;
        }

        private void CalBtn_Click(object sender, System.EventArgs e)
        {
            DataGridView resultGV  = ResultGV;
            resultGV.Rows.Clear();

            CalculateService service = new CalculateService
            {
                inputVo = _vo
            };
            int index = 0;
            List<double> x2List = new List<double>();
            List<double> y2List = new List<double>();
            List<double> z2List = new List<double>();
            if (service.inputVo.AI > 0)
            {
                if (service.inputVo.CI > 0)
                {
                    for (double ac = service.inputVo.AS; ac <= service.inputVo.AE; ac += service.inputVo.AI)
                    {
                        service.inputVo.CurrentA = ac;
                        for (double cc = service.inputVo.CS; cc <= service.inputVo.CE; cc += service.inputVo.CI)
                        {
                            service.inputVo.CurrentC = cc;
                            AddGrid(resultGV, service, index);
                            AddTmpList(service, x2List, y2List, z2List);
                            index++;
                        }
                    }
                }
                else
                {
                    for (double ac = service.inputVo.AS; ac <= service.inputVo.AE; ac += service.inputVo.AI)
                    {
                        service.inputVo.CurrentA = ac;
                        for (double cc = service.inputVo.CS; cc >= service.inputVo.CE; cc += service.inputVo.CI)
                        {
                            service.inputVo.CurrentC = cc;
                            AddGrid(resultGV, service, index);
                            AddTmpList(service, x2List, y2List, z2List);
                            index++;
                        }
                    }
                }
            }
            else
            {
                if (service.inputVo.CI > 0)
                {
                    for (double ac = service.inputVo.AS; ac >= service.inputVo.AE; ac += service.inputVo.AI)
                    {
                        service.inputVo.CurrentA = ac;
                        for (double cc = service.inputVo.CS; cc <= service.inputVo.CE; cc += service.inputVo.CI)
                        {
                            service.inputVo.CurrentC = cc;
                            AddGrid(resultGV, service, index);
                            AddTmpList(service, x2List, y2List, z2List);
                            index++;
                        }
                    }
                }
                else
                {
                    for (double ac = service.inputVo.AS; ac >= service.inputVo.AE; ac += service.inputVo.AI)
                    {
                        service.inputVo.CurrentA = ac;
                        for (double cc = service.inputVo.CS; cc >= service.inputVo.CE; cc += service.inputVo.CI)
                        {
                            service.inputVo.CurrentC = cc;
                            AddGrid(resultGV, service, index);
                            AddTmpList(service, x2List, y2List, z2List);
                            index++;
                        }
                    }
                }
            }
            _mainForm.SetX2List(x2List);
            _mainForm.SetY2List(y2List);
            _mainForm.SetZ2List(z2List);
        }

        private static void AddTmpList(CalculateService service, List<double> x2List, List<double> y2List, List<double> z2List)
        {
            x2List.Add(Math.Round(service.P2[0, 0], 4, MidpointRounding.AwayFromZero));
            y2List.Add(Math.Round(service.P2[1, 0], 4, MidpointRounding.AwayFromZero));
            z2List.Add(Math.Round(service.P2[2, 0], 4, MidpointRounding.AwayFromZero));
        }

        private void AddGrid(DataGridView resultGV, CalculateService service, int index)
        {
            resultGV.Rows.Add();
            resultGV.Rows[index].Cells["AC"].Value = service.inputVo.CurrentA;
            resultGV.Rows[index].Cells["CC"].Value = service.inputVo.CurrentC;
            resultGV.Rows[index].Cells["X2"].Value = Math.Round(service.P2[0, 0], 4, MidpointRounding.AwayFromZero);
            resultGV.Rows[index].Cells["Y2"].Value = Math.Round(service.P2[1, 0], 4, MidpointRounding.AwayFromZero);
            resultGV.Rows[index].Cells["Z2"].Value = Math.Round(service.P2[2, 0], 4, MidpointRounding.AwayFromZero);
        }
    }
}
