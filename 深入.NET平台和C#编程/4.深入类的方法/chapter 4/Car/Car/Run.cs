using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Run
    {
        public Run(string name,string color,string land)
        {
            Console.WriteLine("我是一辆"+name+"车，颜色是"+color+"产地在"+land+"!");
        }

        public Run(string name, string color, string land,int time)
        {
            Console.WriteLine("我是一辆" + name + "车，颜色是" + color + "产地在" + land +",最高车速"+ time+"!");

        }
    }
}
