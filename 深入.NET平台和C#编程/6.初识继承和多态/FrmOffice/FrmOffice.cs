using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmOffice
{
    public partial class FrmOffice : Form
    {
        public FrmOffice()
        {
            InitializeComponent();
            Init();
        }
        List<Employee> empls = new List<Employee>();
        public void Init() {
            List<Job> list1 = new List<Job>();
            list1.Add(new Job("编码","购物车模块"));
            list1.Add(new Job("测试","给购物车模块做单元测试"));
            SE ai = new SE("113","爱变成",24,Gender.男,100,list1);

            List<Job> list2 = new List<Job>();
            list2.Add(new Job("设计", "数据库建模"));
            list2.Add(new Job("编写文档", "详细设计说明书"));
            SE ai2 = new SE("114", "Joe", 24, Gender.男, 200, list2);

            PM pm = new PM("8901", Gender.男, 30, "盖茨", 50,null);
            empls.Add(ai);
            empls.Add(ai2);
            empls.Add(pm);
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            foreach (Employee item in empls)
            {
                if (item is PM)
                {
                    MessageBox.Show(((PM)item).DoWork(),"汇报");
                }
                if (item is SE)
                {
                    MessageBox.Show(((SE)item).DoWork(),"汇报");
                }
            }
        }
    }
}
