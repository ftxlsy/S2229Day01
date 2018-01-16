using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class Book
    {
        private int price;
        private string name;
        private string author;

        public Book()
        {
        }

        public Book(int price, string name, string author)
        {
            this.Author = author;
            this.Name = name;
            this.Price = price;
        }

        public int Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
    }
}
