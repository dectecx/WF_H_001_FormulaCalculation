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
            CalculateService service = new CalculateService();
            service.inputVo = _vo;
            ;
        }
    }
}
