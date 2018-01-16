using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmOffice
{
    public class PM:Employee
    {
        private int yearOfExperience;

        public int YearOfExperience
        {
            get { return yearOfExperience; }
            set { yearOfExperience = value; }
        }
        public PM(string id, Gender genter, int age, string name, int yearOfExperience,List<Job> list):base(id,age,name,genter,list)
        {
            this.YearOfExperience = yearOfExperience;
        }
        public string DoWork() {
            string message = this.Name + "管理员完成工作内容！";
            return message;
        }
    }
}
