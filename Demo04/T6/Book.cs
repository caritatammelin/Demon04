using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Book
    {
        public string Name { get; set; }
        public string Covers { get; set; }
        public bool Pictures { get; set; }
        public int Pages { get; set; }

        public Book(string name, string covers)
        {
            Name = name;
            Covers = covers;
        }

        public void PrintData()
        {
            Console.WriteLine("Book: ");
            Console.WriteLine("- Name: " + Name + " Covers: " + Covers + " Pictures: " + Pictures + " Pages: " + Pages);
        }
    }
}
