
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Count count = new Count();
            Console.WriteLine("7+10="+count.Sum(7,10));
            Console.WriteLine("4.1+2.3+3.6="+count.Sum(4.1,2.3,3.6));
            Console.WriteLine("I love+ ACCP="+count.Sum("I love", " ACCP"));
            Console.ReadLine();
        }
    }
}
