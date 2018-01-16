
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managament_of_set_meal
{
    public class HealthCheckItem
    {
        
       private string name;
        //项目名称
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;
        //项目描述
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int price;
        //项目价格
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public HealthCheckItem()
        {
        
        }

        public HealthCheckItem(string name, int price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

        
  
      
    }
}
