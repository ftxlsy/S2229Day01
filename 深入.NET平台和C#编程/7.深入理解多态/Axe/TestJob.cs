using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
   public class TestJob:Job
    {

       public int CaseNum { get; set; }
       public int FindBugs { get; set; }
       public int WorkDay { get; set; }

       public TestJob()
       {
       }

       public TestJob(string type,string name,string desc):base(type,name,desc)
       {
       }

       public override void Execute()
        {
           FrmTestJob te = new FrmTestJob(this);
           te.ShowDialog();
        }

       public override string Show()
       {
           string info = string.Format("编写用例个数：{0}\n发现的Bug数为{1}\n工作日为{2}", this.CaseNum, this.FindBugs, this.WorkDay);
           return info;
       }
    }
}
