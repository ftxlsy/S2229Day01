using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizard
{
    class Wizad
    {
        private string grade;
        private string comat;
        private string hp;

        public Wizad()
        {
            hp = "10000";
        }

        public Wizad(string grade, string comat, string hp)
        {
            this.grade = grade;
            this.comat = comat;
            this.hp = hp;
        }

        public string Grade { get => grade; set => grade = value; }
        public string Comat { get => comat; set => comat = value; }
        public string Hp { get => hp; set => hp = value; }
    }
}
