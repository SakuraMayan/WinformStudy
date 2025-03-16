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
    public partial class RichTextBoxForm: Form
    {
        public RichTextBoxForm()
        {
            InitializeComponent();
        }

        private void richTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTb_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //打开超链接
            System.Diagnostics.Process.Start(e.LinkText);
        }


        /// <summary>
        /// 点击插入图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //通过剪切板来实现 

            //清空剪切板的内容
            Clipboard.Clear();

            //读取图片
            Bitmap bitmap = new Bitmap("C:\\Users\\13618\\Pictures\\蓝白猫.png");
            //把图片放入剪切板
            Clipboard.SetImage(bitmap);
            //粘贴到富文本中
            richTb.Paste();
        }

        /// <summary>
        /// 文本加粗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {


            Font oldFont,newFont;

            //选中部分的字体
            oldFont = richTb.SelectionFont;

            //新的字体加粗取反
            newFont = new Font(oldFont, oldFont.Bold ? FontStyle.Regular:FontStyle.Bold);

            richTb.SelectionFont = newFont;

        }
    }
}
