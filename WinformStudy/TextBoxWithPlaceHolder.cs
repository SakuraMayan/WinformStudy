using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformStudy
{

    /// <summary>
    /// 带有PlaceHolder属性的TextBox
    /// </summary>
    public class TextBoxWithPlaceHolder:TextBox
    {

        public string PlaceHolder { get; set; }

        /// <summary>
        /// 正则表达式对Text进行验证
        /// </summary>
        public string RegExp { get; set; }

        /// <summary>
        /// 正则表达式验证失败显示的文本
        /// </summary>
        public string RegExpFailureText { get; set; }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xF || m.Msg == 0x133)
            {
                WmPaint(ref m);
            }
        }
        private void WmPaint(ref Message m)
        {

            //显示PlaceHolder文本的颜色
            Graphics g = Graphics.FromHwnd(base.Handle);
            if (!string.IsNullOrEmpty(this.PlaceHolder) && string.IsNullOrEmpty(this.Text))
                g.DrawString(this.PlaceHolder, this.Font, new SolidBrush(Color.LightGray), 0, 0);
        }


        /// <summary>
        /// 重写文本框失去焦点事件 用于正则判断
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (!Regex.Match(this.Text, this.RegExp).Success)
            {
                MessageBox.Show(this.RegExpFailureText);
            }
           
        }
    }
}
