using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Run run1 = new Run("奔驰","红色","德国");
            Run run2 = new Run("宝马","银灰色","德国");
            Run run3 = new Run("宝马","银灰色","德国",200);
            Console.ReadLine();
        }
    }
}
