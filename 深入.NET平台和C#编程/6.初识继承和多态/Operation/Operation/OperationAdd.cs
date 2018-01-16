using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
   public class OperationAdd:Operation
   {
       public override double GetReault()
       {
           double result = NumberA + NumberB;
           return result;
       }
    }
}
