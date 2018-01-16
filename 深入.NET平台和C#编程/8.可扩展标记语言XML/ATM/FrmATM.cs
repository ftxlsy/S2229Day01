using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class FrmATM : Form
    {
        public FrmATM()
        {
            InitializeComponent();
            this.btnSelect.Enabled = false;
            this.btndraw.Enabled = false;
            this.btnforward.Enabled = false;
        }
        //创建父类的泛型集合
        List<BankCard> list = new List<BankCard>();
        //清空方法
        public void No()
        {
            this.lblMoney1.Text = null;
            this.txtMoney.Text = null;
            this.txtMoney2.Text = null;
            this.txtNum.Text = null;
            this.btnSelect.Enabled = false;
            this.btndraw.Enabled = false;
            this.btnforward.Enabled = false;
        }
        //添加数据
        public void Addcard()
        {
            //添加非本行卡数据
            OtherCard oth = new OtherCard("1234", "1234", "刘胖云", 200);
            //添加本行卡数据
            MyCard my = new MyCard("123", "123", "刘胖云", 500);
            //添加到父类泛型集合中
            list.Add(oth);
            list.Add(my);
        }
        //点击插卡时的方法
        public void plug_in()
        {
            bool falg = false;
            //判断账号和密码是否为空
            if ((!txtNum3.Text.Trim().Equals(string.Empty)) && (!txtPwd.Text.Trim().Equals(string.Empty)))
            {
                //遍历泛型集合
                foreach (BankCard item in list)
                {
                    //判断输入的账号和密码是否正确
                    if (txtNum3.Text.Trim().Equals(item.CardID) && txtPwd.Text.Trim().Equals(item.CardPwd))
                    {
                        if (item is OtherCard)
                        {
                            falg = true;
                            this.btnSelect.Enabled = true;
                            this.btndraw.Enabled = true;
                            this.lblNumZH.Text = item.CardID;
                            this.lblNameA.Text = item.CardName;
                        }
                        else
                        {
                            falg = true;
                            this.btnSelect.Enabled = true;
                            this.btndraw.Enabled = true;
                            this.btnforward.Enabled = true;
                            this.lblNumZH.Text = item.CardID;
                            this.lblNameA.Text = item.CardName;
                        }
                    }
                }
                if (!falg)
                {
                    MessageBox.Show("账号和密码输入错误！");
                }
            }
        }
        //插卡事件
        private void btnplug_in_Click(object sender, EventArgs e)
        {
            No();
            //调用插卡方法
            plug_in();
        }
        //点击查询时的方法
        public void SelectMoney()
        {
            //遍历泛型集合
            foreach (BankCard item in list)
            {
                if (txtNum3.Text.Trim().Equals(item.CardID))
                {
                    //判断是哪一个账号
                    if (item is OtherCard)
                    {
                        this.lblMoney1.Text = item.CardMoney.ToString();
                        break;
                    }
                    if (item is MyCard)
                    {
                        this.lblMoney1.Text = item.CardMoney.ToString();
                        break;
                    }
                }
            }
        }
        //点击的查询事件
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //调用点击查询时的方法
            SelectMoney();
        }
        //点击取款时的方法
        public void plug_off()
        {
            //判断余额是否小于要取的款
            if (Convert.ToInt32(lblMoney1.Text.Trim()) < Convert.ToInt32(txtMoney.Text.Trim()))
            {
                MessageBox.Show("余额不足");
            }
            else
            {
                double money = Convert.ToInt32(lblMoney1.Text.Trim()) - Convert.ToInt32(txtMoney.Text.Trim());
                //遍历泛型集合
                foreach (BankCard item in list)
                {
                    if (txtNum3.Text.Trim().Equals(item.CardID))
                    {
                        //判断是哪一个账号
                        if (item is OtherCard)
                        {
                            item.CardMoney = money;
                        }
                        else
                            if (item is MyCard)
                            {
                                item.CardMoney = money;
                            }
                    }
                }
            }
        }
        //取款的点击事件
        private void btndraw_Click(object sender, EventArgs e)
        {
            //No();
            //调用点击取款时的方法
            plug_off();
        }
        //转账时的方法
        public void forward()
        {
            //判断卡号是否为空
            if (!txtNum.Text.Trim().Equals(string.Empty))
            {
                //遍历集合
                foreach (BankCard item in list)
                {
                    if (txtNum3.Text.Trim().Equals(item.CardID))
                    {
                        if (item is MyCard)
                        {
                            item.CardMoney = item.CardMoney - Convert.ToInt32(txtMoney2.Text.Trim());
                        }
                        //判断是哪一个账号

                    }
                    if (txtNum.Text.Trim().Equals(item.CardID))
                    {
                        if (item is OtherCard)
                        {
                            item.CardMoney = item.CardMoney + Convert.ToInt32(txtMoney2.Text.Trim());

                        }
                    }
                }
            }
        }
        //Load事件
        private void FrmATM_Load(object sender, EventArgs e)
        {
            //调用泛型集合的填充方法
            Addcard();
        }

        private void btnforward_Click(object sender, EventArgs e)
        {
            forward();
        }

        private void btnplug_off_Click(object sender, EventArgs e)
        {
            No();
            this.txtNum3.Text = null;
            this.txtPwd.Text = null;
            this.lblNumZH.Text = null;
            this.lblNameA.Text = null;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
