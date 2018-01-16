using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    class Choose
    {
        public static Operation choose(string s)
        {
            switch (s)
            {
                case "+":

                    oper = new OperationAdd();
                    break;

                case "-":

                    oper = new OperationMinus();
                    break;

                case "*":

                    oper = new OperationRide();
                    break;

                case "/":

                    oper = new OperationDiv();
                    break;
            }
            return s;
        }
    }
}
