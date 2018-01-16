using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Waiter
    {
        public void Order(string name)
        {
            Console.WriteLine("您点了："+name);
            Cook cook = new Cook();
            cook.Order(name);
        }

        public void Orders()
        {
            Console.WriteLine("上菜");
        }
    }
}
