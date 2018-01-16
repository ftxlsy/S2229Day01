using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Cook
    {
        public void Order(string name)
        {
            Console.WriteLine("菜品"+name+"进行加工");
            Console.WriteLine("...........................");
            Console.WriteLine("制作加工完毕！");
            Waiter waiter = new Waiter();
            waiter.Orders();
        }
    }
}
