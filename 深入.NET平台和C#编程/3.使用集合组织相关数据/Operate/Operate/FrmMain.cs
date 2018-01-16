using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operate
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public List<SE> list = new List<SE>();

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd add = new FrmAdd(this);
            
            add.Show();
        }
        public void AddSelct() {
            SE se = new SE();
            se.Num = 10;
            se.Age = 21;
            se.Name = "刘";
            se.Sex = "女";
            list.Add(se);
            SE se1 = new SE();
            se1.Num = 11;
            se1.Age = 23;
            se1.Name = "水";
            se1.Sex = "女";
            list.Add(se1);
        }
        public void FF() {
            dgvSelectAll.DataSource = new BindingList<SE>(list);
        }

        public void Select() {
            List<SE> list1 = new List<SE>();
            foreach (SE item in list)
            {
                if (item.Num.ToString().IndexOf(txtNum.Text.Trim())!=-1)
                {
                    list1.Add(item);
                }
            }
            dgvSelectAll.DataSource = new BindingList<SE>(list1);

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            AddSelct();
            FF();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Select();


        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (SE item in list)
            {
                if (item.Num.ToString().Equals(this.dgvSelectAll.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    item.Num = Convert.ToInt32(this.dgvSelectAll.SelectedRows[0].Cells[0].Value);
                    item.Age = Convert.ToInt32(this.dgvSelectAll.SelectedRows[0].Cells[1].Value);
                    item.Name = this.dgvSelectAll.SelectedRows[0].Cells[2].Value.ToString();
                    item.Sex = this.dgvSelectAll.SelectedRows[0].Cells[3].Value.ToString();
                    FF();
                    break;
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (SE item in list)
            {
                if (item.Num.ToString().Equals(this.dgvSelectAll.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    list.Remove(item);
                    FF();
                    break;
                }
            }
        }

        private void 打卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DK dk = new DK(this);
            dk.Show();
        }
        public Dictionary<int, SE> dic = new Dictionary<int, SE>();
        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (int item in dic.Keys)
            {
                if (item == Convert.ToInt32(this.dgvSelectAll.SelectedRows[0].Cells[0].Value))
                {
                    MessageBox.Show("您已签到过！");
                    return;
                }
            }
            SE se = new SE();
            se.Num = Convert.ToInt32(this.dgvSelectAll.SelectedRows[0].Cells[0].Value);
            se.StartTime = DateTime.Now;
            se.Name = this.dgvSelectAll.SelectedRows[0].Cells[2].Value.ToString();

            dic.Add(se.Num,se);
            MessageBox.Show("签到成功！");
        }

        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dic[Convert.ToInt32(this.dgvSelectAll.SelectedRows[0].Cells[0].Value)].EndTime!=DateTime.MinValue)
            {
                MessageBox.Show("你已签退过！");
                return;
            }
            dic[Convert.ToInt32(this.dgvSelectAll.SelectedRows[0].Cells[0].Value)].EndTime = DateTime.Now;
            MessageBox.Show("签退成功！");
        }
    }
}
