using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck tr = new Truck("奥迪A6","德国");
            tr.VehicleRun();
            tr.TruckRun();
            Console.ReadLine();
        }
    }
}
