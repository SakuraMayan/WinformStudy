using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformStudy
{
    public partial class ProgressBarForm: Form
    {
        public ProgressBarForm()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //如果pb当前值小于最大值 就调用pb步数移动方法
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.PerformStep();
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
