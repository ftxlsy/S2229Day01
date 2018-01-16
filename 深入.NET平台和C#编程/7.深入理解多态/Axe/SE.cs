using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
   public class SE:Employee
    {
       public SE()
       {
       }

       public SE(string id, string name, int age, Gender gender, int popularity, List<Job> list)
           : base(id, name,age,gender,list)
       {
           this.Popularity = popularity;
       }

       public int Popularity { get; set; }

       public override string DoWork()
       {
           StringBuilder sb = new StringBuilder();
           sb.Append(this.Name + ":\n");
           for (int i = 0; i < this.WorkList.Count; i++)
           {
               sb.Append((i + 1) + "," + WorkList[i].Name + "," + WorkList[i].Description + "\n");
           }
           return base.DoWork();
       }
    }
}
