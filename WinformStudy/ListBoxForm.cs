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
    public partial class ListBoxForm: Form
    {
        public ListBoxForm()
        {
            InitializeComponent();
        }

        private void ListBoxForm_Load(object sender, EventArgs e)
        {


            //构造数据源的数据
            List<StudentInfo> students = new List<StudentInfo>
            {
                new StudentInfo() { Id = 1, Name = "zhangsan" },
                new StudentInfo() { Id = 2, Name = "李四" },
                new StudentInfo() { Id = 3, Name = "wanger" }
            };

            //绑定Items之前都需要先清除项
            listb.Items.Clear();

            //设置数据源
            listb.DataSource = students;

            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = students;
            //listb.DataSource = bindingSource;
            //设置显示值 显示给用户看的内容
            listb.DisplayMember = nameof(StudentInfo.Name);
            //设置真实值 一般为id等唯一标识符号
            listb.ValueMember = nameof(StudentInfo.Id);
        }

        private void listb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            //单选选中值显示
            //MessageBox.Show(listb.SelectedValue.ToString());

            //查看多选中项值  SelectedIndices这个是选中项的索引值
            StringBuilder sb = new StringBuilder();
            //foreach (int i in listb.SelectedIndices)
            //{ 
            //    sb.Append(i.ToString()+",");
            //}
                

            //查看选中项
            //foreach (StudentInfo studentInfo in listb.SelectedItems)
            //{

            //    sb.Append(studentInfo.Id + ",");
            //}

            //MessageBox.Show(sb.ToString());


            //更新datasource的方法  完全重置数据源 重新绑定
            listb.BeginUpdate();
            List<StudentInfo> newStudents=((List<StudentInfo>)listb.DataSource);
            newStudents.RemoveAt(1);
            listb.DataSource = null;
            listb.DataSource = newStudents;
            //设置显示值 显示给用户看的内容
            listb.DisplayMember = nameof(StudentInfo.Name);
            //设置真实值 一般为id等唯一标识符号
            listb.ValueMember = nameof(StudentInfo.Id);
            listb.EndUpdate();
            
              

            //listb.Items.RemoveAt(1);//设置DataSource不能移除项和添加项

        }
    }
}
