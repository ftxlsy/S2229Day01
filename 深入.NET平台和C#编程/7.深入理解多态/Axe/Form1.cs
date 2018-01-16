using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Employee em;
        //填充数据
        public void Init()
        {
            List<Job> listJob = new List<Job>();
            listJob.Add(new CodeJob("登陆编码","实现","编码"));
            listJob.Add(new CodeJob("后台编码", "实现", "编码"));
            listJob.Add(new TestJob("登陆编码", "实现", "测试"));
            em = new SE("111","王小毛",20,Gender.男, 99,listJob);
        }
        //绑定数据源
        public void UpdateJob()
        {
            dataGridView1.DataSource = em.WorkList;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Init();
            UpdateJob();
        }

        private void 执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;//得到下标
            em.WorkList[index].Execute();
        }

        private void 完成操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;//得到下标
            string str = em.WorkList[index].Show();
            MessageBox.Show(str,"指标完成情况");
        }
    }
}
