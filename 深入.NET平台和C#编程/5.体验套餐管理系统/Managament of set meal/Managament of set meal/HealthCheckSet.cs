using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managament_of_set_meal
{
    public class HealthCheckSet
    {
        private int price;
        //项目价格
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string name;
        //项目名称
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<HealthCheckItem> items;
        //HealthCheckItem的集合
        public List< HealthCheckItem> Items
        {
            get { return items; }
            set { items = value; }
        }

         public HealthCheckSet()
        {
            items = new List<HealthCheckItem>();
        }

         public HealthCheckSet(string name,List<HealthCheckItem> items)
        {
            this.name = name;
            this.items = items;
        }

         public void CalcPrice() {
             int totalPrice = 0;
             foreach (HealthCheckItem item in items)
             {
                 totalPrice += item.Price;
             }
             this.price = totalPrice;
         }
    }
}
