using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
   public class CodeJob:Job
    {
       public CodeJob()
       {
       }

       public CodeJob(string type,string name,string desc):base(type,name,desc)
       {
           
       }

       public int CodingLines { get; set; }
       public int Bugs { get; set; }
       public int WorkDay { get; set; }

       public override void Execute()
        {
           FrmCodeJob co = new FrmCodeJob(this);
           co.ShowDialog();
        }

       public override string Show()
       {
           string info = string.Format("有效编码行数为{0}\n遗留问题为{1}个\n所需工作日为{2}",this.CodingLines,this.Bugs,this.WorkDay);
           return info;
       }
    }
}
