using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operate1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
    
        public SE[] se;
        public void B() {
            SE A = new SE();
            A.GH = "111";
            A.name = "王小毛";
            A.age = "23";
            A.PJ = "hao";
            A.DF = "43";
            se[0] = A;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            B();
        }
    }
}
