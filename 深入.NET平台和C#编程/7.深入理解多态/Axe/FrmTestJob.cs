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
    public partial class FrmTestJob : Form
    {
        private TestJob job;
        public FrmTestJob(TestJob tj)
        {
            InitializeComponent();
            this.job =tj;
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
                job.CaseNum = Convert.ToInt32(textBox1.Text.Trim());
                job.FindBugs = Convert.ToInt32(textBox2.Text.Trim());
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
