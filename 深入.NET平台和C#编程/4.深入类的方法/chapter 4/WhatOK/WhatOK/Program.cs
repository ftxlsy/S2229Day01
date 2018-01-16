using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatOK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====员工=====");
            SE se = new SE("001","方大脸",50);
            Console.WriteLine(se.SayHi());

            Console.WriteLine("=====经理=====");
            PM pm = new PM("010", "方", 150);
            Console.WriteLine(pm.SayHi());

 

            Console.ReadLine();
        }
    }
}
