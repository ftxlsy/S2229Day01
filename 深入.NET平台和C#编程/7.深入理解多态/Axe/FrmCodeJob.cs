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
    public partial class FrmCodeJob : Form
    {
        CodeJob job;
        public FrmCodeJob(CodeJob cj)
        {
            InitializeComponent();
            this.job = cj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isError = false;
            try
            {
                job.CodingLines = Convert.ToInt32(textBox1.Text.Trim());
                job.Bugs = Convert.ToInt32(textBox2.Text.Trim());
                job.WorkDay = Convert.ToInt32(textBox3.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                isError = true;
            }
            if (!isError)
            {
                MessageBox.Show("提交成功！");
                this.Close();
            }
        }
    }
}
