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
    public partial class FrmAdd : Form
    {
        public FrmAdd(FrmMain m)
        {
            InitializeComponent();
            this.cmbSex.SelectedIndex = 0;
            this.FrmParent = m;
        }
        public FrmMain FrmParent;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SE se = new SE();
                se.Num = int.Parse(this.txtNum.Text.Trim());
                se.Age = int.Parse(this.txtAge.Text.Trim());
                se.Name = this.txtName.Text.Trim();
                if (this.cmbSex.SelectedItem.ToString() == "男")
                {
                    se.Sex = "男";
                }
                else
                {
                    se.Sex = "女";
                }
                foreach (SE item in FrmParent.list)
                {
                    if (item.Num == se.Num)
                    {
                        MessageBox.Show("此工号已存在!");
                        return;
                    }
                }
                FrmParent.list.Add(se);
                FrmParent.FF();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }
}
