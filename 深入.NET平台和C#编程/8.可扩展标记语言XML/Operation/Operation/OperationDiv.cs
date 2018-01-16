using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
   public class OperationDiv:Operation
    {
       public override double GetReault()
       {
           if (NumberB == 0)
           {
               throw new Exception("除数不能为0");//抛出异常
           }
           double result = NumberA / NumberB;
           return result;
       }
    }
}
