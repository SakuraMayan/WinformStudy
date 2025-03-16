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
    public partial class RadioButtonCheckBoxForm: Form
    {
        public RadioButtonCheckBoxForm()
        {
            InitializeComponent();
        }

        private void RadioButtonCheckBoxForm_Load(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton radioButton = (RadioButton)sender;

            //if (radioButton.Checked)//被选中
            //{
            //    MessageBox.Show(radioButton.Text);
            //}
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton radioButton = (RadioButton)sender;

            //if (radioButton.Checked)//被选中
            //{
            //    MessageBox.Show(radioButton.Text);
            //}
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {

            string gender=string.Empty;

            //获取选中的单选信息
            if (rbFemale.Checked) 
            {
                gender = rbFemale.Text;

            }
            else if (rbMale.Checked)
            { 
                gender = rbMale.Text;
            }

            //获取多选信息
            List<string> favorities = new List<string>();
            if (cbMusic.Checked)
                favorities.Add(cbMusic.Text);
            if (cbFootball.Checked)
                favorities.Add(cbFootball.Text);
            if (cbTableTennis.Checked)
                favorities.Add(cbTableTennis.Text);

            MessageBox.Show("单选结果：" + gender+",多选结果："+string.Join(",",favorities.ToArray()));



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
