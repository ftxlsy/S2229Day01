
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====程序员艾编程=====");
            Pay pay1 = new Pay(4000,3000);

            Console.WriteLine("=====项目经理乔布斯=====");
            Pay pay2 = new Pay(8000, 4000,2000);

            Console.ReadLine();
        }
    }
}
