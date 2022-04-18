using System;
using System.Windows.Forms;
using WF_H_001.Models;
using WF_H_001.Service;

namespace WF_H_001
{
    public partial class SubForm : Form
    {
        private readonly InputVo _vo;

        public SubForm(InputVo vo)
        {
            InitializeComponent();
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
                            index++;
                        }
                    }
                }
            }
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
