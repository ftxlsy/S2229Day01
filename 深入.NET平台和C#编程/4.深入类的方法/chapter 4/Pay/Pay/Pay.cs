using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay
{
    class Pay
    {
        public Pay()
        {

        }
        public Pay(int num, int nums)
        {
            Console.WriteLine("基本工资：" + num);
            Console.WriteLine("考核工资：" + nums);
            Console.WriteLine("合计："+(num+nums));
        }
        public Pay(int num, int nums, int numss)
        {
            Console.WriteLine("基本工资：" + num);
            Console.WriteLine("项目工资：" + nums);
            Console.WriteLine("分红：" + numss);
            Console.WriteLine("合计："+(num+nums+numss));
        }
    }
}
