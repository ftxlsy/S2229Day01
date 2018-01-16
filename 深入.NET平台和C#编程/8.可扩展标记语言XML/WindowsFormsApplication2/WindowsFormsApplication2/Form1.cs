using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("book.xml");
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode book in root.ChildNodes)
            {
                foreach (XmlNode item in book.ChildNodes)
                {
                    if (item.Name.Equals("bookid"))
                    {
                        Console.WriteLine("id"+item.InnerText);
                    }else if(item.Name.Equals("bookname"))
                    {
                        Console.WriteLine("name"+item.InnerText);
                    }
                }
            }
            Console.WriteLine("XXX");
        }
    }
}
