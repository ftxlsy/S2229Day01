using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managament_of_set_meal
{
    public partial class FrmMain : Form
    {
        HealthCheckItem height, weight, sight, hearing, liverFun, ekg,BC;
        HealthCheckSet setA;

        public FrmMain()
        {
            InitializeComponent();
        }
        //所有的体检项目
        List<HealthCheckItem> AllItems = new List<HealthCheckItem>();
        //体检的检查项目
        List<HealthCheckItem> items = new List<HealthCheckItem>();
        //datagirdview中的一个集合
         Dictionary<string, HealthCheckSet> healthset = new Dictionary<string, HealthCheckSet>();
                    //键    --->     值 

        //在集合中添加元素的方法
        public void dgv() {
            height = new HealthCheckItem("身高", 5, "用于检测身高");
            weight = new HealthCheckItem("体重", 5, "用于检测体重");
            sight = new HealthCheckItem("视力", 20, "用于检测视力");
            hearing = new HealthCheckItem("听力", 20, "用于检测听力");
            liverFun = new HealthCheckItem("心电图", 50, "用于检测心电图");
            ekg = new HealthCheckItem("肝功能", 50, "用于检测肝功能");
            BC = new HealthCheckItem("B超", 50, "用于检测B超");
            AllItems.Add(height);
            AllItems.Add(weight);
            AllItems.Add(sight);
            AllItems.Add(hearing);
            AllItems.Add(liverFun);
            AllItems.Add(ekg);
            AllItems.Add(BC);
            this.cbxManage.DataSource = new BindingList<HealthCheckItem>(AllItems);
            this.cbxManage.DisplayMember = "name";

        }
        //入学体检时的方法
        public void Iniset()
        {
            items = new List<HealthCheckItem>();
            items.Add(height);
            items.Add(weight);
            items.Add(sight);
            HealthCheckSet set = new HealthCheckSet("请选择",items);
            set.CalcPrice();
            setA = new HealthCheckSet("入学体检", items);
            setA.CalcPrice();
            this.healthset.Add(set.Name, set);
            this.healthset.Add(setA.Name, setA);
        }

        //cbxList填充
        public void BinDing()
        {
            BindingSource source = new BindingSource();
            source.DataSource = healthset.Keys;
            this.cbxList.DataSource = source;
        }
        //将初始化套餐信息绑定到下拉框当中
        public void Inits()
        {
            this.cbxList.Items.Clear();
            this.cbxList.Items.Add("请选择");
            foreach (string item in healthset.Keys)
            {
                this.cbxList.Items.Add(item);
            }
            this.cbxList.SelectedIndex = 0;
        }

        //刷新dataGirdView1中的数据
        public void UpdateSet(HealthCheckSet set)
        {
            this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(set.Items.ToList());
        }

        //Load事件
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //集合添加元素
            dgv();
            //调用入学体检时的方法
            Iniset();
            BinDing();
           
        }
        //套餐名称下拉框
        private void cbxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string setName = this.cbxList.Text;
            if (setName == "请选择")
            {
                this.dataGridView1.DataSource = new BindingList<HealthCheckItem>();
                txtSetName2.Text = "";
                txtAllPrice.Text = "";
                return;
            }
            txtSetName2.Text = this.healthset[setName].Name;
            txtAllPrice.Text = this.healthset[setName].Price.ToString();
            UpdateSet(healthset[setName]); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtSetName.Text.Trim() != null && this.txtSetName.Text.Trim() != "")
            {
                HealthCheckSet set = new HealthCheckSet();
                healthset.Add(this.txtSetName.Text.Trim(), set);
                Inits();

                this.cbxList.SelectedIndex = healthset.Count;
            }
            else
            {
                MessageBox.Show("请输入添加的套餐名称");
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (this.cbxManage.SelectedIndex == 0)
            {
                MessageBox.Show("请选择套餐项");
                return;
            }
            string name = this.cbxList.Text;
            if (name == "请选择")
            {
                MessageBox.Show("请选择套餐");
                return;
            }
            if (!healthset[name].Items.Keys.ToList().Contains(this.cbxManage.Text))
            {
                healthset[name].Items.Add(this.cbxManage.Text, cbxManage[this.cbxManage.Text]);
                healthset[name].CalcPrice();
                this.txtSetName2.Text = name;
                this.txtAllPrice.Text = healthset[name].Price.ToString();
                UpdateSet(healthset[name]);
            }
            else
            {
                MessageBox.Show("该项已经存在！");
            }
        }

        private void btnDelect_Click(object sender, EventArgs e)
        {
            string name = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string healthname = this.cbxList.Text;
            healthset[healthname].Items.Remove(name);
            UpdateSet(healthset[healthname]);
        }



    }
}
