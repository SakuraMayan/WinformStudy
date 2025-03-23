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
    public partial class TimerForm: Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();

            //通过代码添加的Timers.Timer无法直接修改控件内容
            /*System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed; 
            timer.Start();*/


            //通过代码添加Threading.Timer
            System.Threading.Timer thTimer=new System.Threading.Timer(new System.Threading.TimerCallback(o => {
                



                Action action = () => { 
                
                label4.Text = DateTime.Now.ToString();
                   
                };
                this.Invoke(action);
            })
                ,null,100,1000
                );

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //label4.Text = DateTime.Now.ToString();

            //可以通过委托来修改
            /*Action action = () => {
                label4.Text = DateTime.Now.ToString();
            };
            this.Invoke(action);

            //停止timer
            System.Timers.Timer currentTimer = sender as System.Timers.Timer;
            currentTimer.Stop();*/
        }

        private void timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }
    }
}
