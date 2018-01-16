using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmOffice
{
    public class Employee
    {
        public int Age { get; set; }

        public Gender Genter { get; set; }

        public string ID { get; set; }

        public string Name { get; set; }

        protected List<Job> WorkList { get; set; }

        public Employee(string id,int age,string name,Gender gender,List<Job> list) {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.Genter = gender;
            this.WorkList = list;
        }
    }
}