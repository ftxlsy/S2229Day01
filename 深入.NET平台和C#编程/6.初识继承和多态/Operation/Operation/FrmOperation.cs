using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operation
{
    public partial class FrmOperation : Form
    {
        public FrmOperation()
        {
            InitializeComponent();
            this.cbxSign.SelectedIndex = 0;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Trim().Equals(string.Empty)) 
            {
                MessageBox.Show("操作数不能为空！");
                this.txtNum1.Focus();
                return;
            }
            if (txtNum2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("被操作数不能为空！");
                this.txtNum2.Focus();
                return;
            }
            try
            {
                Operation oper = new Operation();
                switch(this.cbxSign.SelectedItem.ToString().Trim())
                {
                    case "+":
                        
                            oper = new OperationAdd();
                            break;
                        
                    case "-":
                        
                            oper = new OperationMinus();
                            break;
                        
                    case "*":

                            oper = new OperationRide();
                            break;
                        
                    case "/":
                        
                            oper = new OperationDiv();
                            break;
                        
                       
                }
                oper.NumberA = double.Parse(this.txtNum1.Text.Trim());
                oper.NumberB = double.Parse(this.txtNum2.Text.Trim());
                this.lblResult.Text = oper.GetReault().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
