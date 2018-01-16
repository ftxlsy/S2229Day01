using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operate
{
    public class SE
    {
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }

        private DateTime startTime;
        private DateTime endTime;
    }
}
