using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Emplyee
    {
       public string Name { get; set; }

       public void GoHome(Tool tool)
       {
           tool.Run();
       }
    }
}
