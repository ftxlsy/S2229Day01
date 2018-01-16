using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void linklblZC_Click(object sender, EventArgs e)
        {
            FrmRegistered re = new FrmRegistered();
            re.f1 = this;
            re.Show();
            //登陆窗体隐藏
            this.Hide();
        }
        //创建一个LoginInfo的数组
        public LoginInfo [] array;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            array = new LoginInfo[7];
            LoginInfo info1 = new LoginInfo();
            info1._name = "刘";
            info1._id = "123456";
            info1._email = "li@qq.com";
            info1._password = "123456";
            array[0] = info1;
        
        }
        //创建一个方法
        private void IsNULL() {
            if (txtEmail.Text.Trim() == "" || txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空!", "提示");
            }
            else {
                string EmailName = txtEmail.Text;
                string Pwd = txtPwd.Text;
                bool ISOK = false;
                foreach (LoginInfo item in array)
                {
                    if (item != null)
                    {
                        if (item._email == EmailName && item._password == Pwd)
                        {
                            this.Hide();
                            ISOK = true;
                           //出现主窗体
                            FrmMain fm = new FrmMain();
                            fm.lblName.Text = "欢迎," + item._name;
                            fm.Show();
                            break;
                        }
                    }
                }
                if (ISOK == false)
                {
                    txtPwd.Text = "";
                    txtPwd.Focus();
                }

            }
        }
        //点击登录时所发生的事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //调用方法
            IsNULL();
        }

        private void linklblZC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
