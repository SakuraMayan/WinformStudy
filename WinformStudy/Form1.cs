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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtUserName.Text);
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            //form2.Activate();//激活窗体
            //form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textBoxWithPlaceHolder1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbWithph_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
