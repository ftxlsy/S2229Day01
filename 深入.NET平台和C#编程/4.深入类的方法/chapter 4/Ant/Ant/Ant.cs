using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant
{
    class Ant
    {
        public void SayHi(string name)
        {
            Console.WriteLine("大家好，我是一只小蚂蚁，名叫"+name+"。");
            Find("提拉米苏");
        }

        public void Find(string food)
        {
            Console.WriteLine("我找到一块甜品，"+food);
            Call(2);
        }

        public void Call(int num)
        {
            Console.WriteLine("我招呼到"+num+"个同伴！");
            Carry();
        }

        public void Carry()
        {
            Console.WriteLine("现在大家搬运甜品！");
            OK();
        }

        public void OK()
        {
            Console.WriteLine("我们完成了寻找甜品的任务！");
        }
    }
}
