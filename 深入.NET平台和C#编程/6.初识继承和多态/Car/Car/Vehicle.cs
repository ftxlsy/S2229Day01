using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
   public class Vehicle
    {
       public string Type { set; get; }
       public string Place { set; get; }
       public Vehicle(string type,string place) {
           this.Type = type;
           this.Place = place;
       }
      public void VehicleRun(){
          Console.WriteLine("汽车在行驶！");
       }
    }
}
