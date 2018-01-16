using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Emplyee em = new Emplyee {Name = ""};
            Tool tool = new Bike();
            Emplyee em2 = new Emplyee();
            Tool tool2 = new Car();
            em.GoHome(tool);
            em2.GoHome(tool2);
            Console.Read();
        }
    }
}
