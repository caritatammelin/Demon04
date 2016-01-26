using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Dictionary : Book
    {

        public string Languages { get; set; }
        public bool CD { get; set; }

        public Dictionary(string name, string covers)
            : base(name, covers)
        {

        }

        public void PrintData()
        {
            Console.WriteLine("Dictionary: ");
            Console.WriteLine("- Name: " + Name + " Covers: " + Covers + " Pictures: " + Pictures + " Pages: " + Pages + " Languages: " + Languages + " CD: " + CD);
        }
    }
}
