using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_answer
{
    class Program
    {

        //#region 简答1

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("请输入数字:");
        //    int parameter = int.Parse(Console.ReadLine());
        //    if (parameter > 100)
        //    {
        //        DoSomething(ref parameter);
        //        Console.WriteLine(parameter);
        //    }
        //    else
        //    {
        //        Console.WriteLine(parameter);
        //    }
        //    Console.ReadLine();
        //}


        //static void DoSomething(ref int parameter)
        //{
        //    parameter -= 50;
        //}
        //#endregion

        #region 简答2
                
        static void Main(string [] args) {
            int [] a = new int[3];
            Console.WriteLine("请输入三个数字");
            for (int i = 0; i < a.Length; i++)
            {
             a[i] = int.Parse(Console.ReadLine());
             DoSomething(ref a[i]);
             Console.WriteLine(a[i]);
            }
        }
        static void DoSomething(ref int parameter)
        {
            parameter+=5;
        }  
        #endregion
    }
}
