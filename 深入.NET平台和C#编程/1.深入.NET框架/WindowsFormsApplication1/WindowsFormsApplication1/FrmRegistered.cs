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
    public partial class FrmRegistered : Form
    {
        public FrmRegistered()
        {
            InitializeComponent();
        }
        public FrmLogin f1;
        private void FrmRegistered_Load(object sender, EventArgs e)
        {

        }
        //点击免费注册按钮时执行的代码
        private void button1_Click(object sender, EventArgs e)
        {
            //调用判断是否为空的方法
            ISNULL();
            LoginInfo info = new LoginInfo();
            info._name = txtname.Text;
            info._id = txtId.Text;
            info._email = txtEmail.Text;
            info._password = txtPwd.Text;
            if (txtEmail.Text.Trim() != "" && txtEmail2.Text.Trim() != "" && txtId.Text.Trim() != "" && txtname.Text.Trim() != "" && txtPwd.Text.Trim() != "" && txtPwd2.Text.Trim() != "")
            {
                MessageBox.Show("恭喜,通过验证!");
                for (int i = 0; i < f1.array.Length; i++)
                {
                    if (f1.array[i] == null)
                    {
                        f1.array[i] = info;
                        break;
                    }
                }
                f1.Visible = true;
                this.Close();
            }
        }
        //创建一个方法,判断txt文本是否为空
        private void ISNULL() {
            if (txtEmail.Text.Trim() == "" || txtEmail2.Text.Trim() == "" || txtId.Text.Trim() == "" || txtname.Text.Trim() == "" || txtPwd.Text.Trim() == "" || txtPwd2.Text.Trim() == "")
            {
                MessageBox.Show("请填写所有信息!");
            }
            if(txtPwd.Text.Trim() != txtPwd2.Text.Trim())
            {
                MessageBox.Show("两次密码输入不同,请重新输入!");
                txtPwd2.Focus();
            }
            if (txtEmail2.Text.Trim() != txtEmail2.Text.Trim())
            {
                MessageBox.Show("两次邮箱地址输入不同,请重新输入!");
                txtEmail2.Focus();
            }
        }

    }
}
