using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatOK
{
    class PM
    {
        private string id;
        private string name;
        private int age;

        public PM(string id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;

           
        }
        public string SayHi()
        {
            return "编号：" + id + "\t姓名：" + name + "\t年龄：" + age;
        }
    }
}
