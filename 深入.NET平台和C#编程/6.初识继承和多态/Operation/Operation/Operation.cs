using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
   public class Operation
    {
        private double numberA;

        public double NumberA
        {
            get { return numberA; }
            set { numberA = value; }
        }
        private double numberB;

        public double NumberB
        {
            get { return numberB; }
            set { numberB = value; }
        }
       public virtual double GetReault()
       {
           double result = 0;
           return result;
   }
    }
}
