using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Client
    {
        public void Order()
        {
            Console.WriteLine("点菜：");
            string name = Console.ReadLine();
            Waiter waiter = new Waiter();
            waiter.Order(name);
            
        }
    }
}