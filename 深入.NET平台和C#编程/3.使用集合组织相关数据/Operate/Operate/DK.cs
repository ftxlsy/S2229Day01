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
    public partial class DK : Form
    {
        public DK(FrmMain main)
        {
            InitializeComponent();
            this.main = main;
        }
        public FrmMain main;
        private void DK_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            BindingSource source = new BindingSource();
            source.DataSource = main.dic.Values;
            this.dataGridView1.DataSource = source;

        }
    }
}
