using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
   public class Truck:Vehicle
    {
       public Truck(string type,string place):base(type,place) { }
       public void TruckRun() {
           Console.WriteLine(string.Format("型号为{0}，产地为{1}的卡车在行驶！",this.Type,this.Place));
       }
    }
}
