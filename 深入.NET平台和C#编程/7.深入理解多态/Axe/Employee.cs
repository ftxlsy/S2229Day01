using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
   public class Employee
    {
       public string ID { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }
       public Gender Gender { get; set; }

       public Employee()
       {
       }

       public List<Job> WorkList
       {
           get ; set;
       }

       public Employee(string id,string name,int age,Gender gender,List<Job> list )
       {
           this.ID = id;
           this.Name = name;
           this.Age = age;
           this.Gender = gender;
           this.WorkList = list;
       }

       public virtual string DoWork()
       {
           return "工作列表";
       }

    }
}
